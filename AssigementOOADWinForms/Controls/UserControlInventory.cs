using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlInventory : UserControl
    {
        // ============================
        // 🔹 DATA FIELDS & SERVICES
        // ============================
        private List<InventoryTransactionDto> transactionsList = new(); // Local data cache
        private readonly InventoryTransactionService _inventoryService = new(); // Database logic (Inventory)
        private readonly ProductService _productService = new(); // Database logic (Product)

        // ============================
        // 🔹 FORM INITIALIZATION LOGIC
        // ============================
        public UserControlInventory()
        {
            InitializeComponent();

            // ===== UI Design Helpers =====
            DesignHelper.MakeAllInputs(this);
            DesignHelper.StyleDataGridView(dgvinventory);
            dgvinventory.CellPainting += DesignHelper.dataGridView1_CellPainting;

            // ===== Event Bindings (Form Logic) =====
            dateTimeSearchStart.ValueChanged += (s, e) => FilterTransactions();
            dateTimeSearchStart.MouseUp += (s, e) => FilterTransactions();
            dateTimeSearchEnd.ValueChanged += (s, e) => FilterTransactions();
            dateTimeSearchEnd.MouseUp += (s, e) => FilterTransactions();
            comboSearchByProduct.SelectedIndexChanged += (s, e) => FilterTransactions();
            textsearchBycustomerName.TextChanged += (s, e) => FilterTransactions();

            btnSave.Click += (s, e) => SaveOrUpdateTransation();
            dgvinventory.SelectionChanged += (s, e) => SelectionRowChanges();
            dgvinventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnClear.Click += (s, e) => HandleClearTextBox();

            // ===== Date Format Setup (Form Logic) =====
            datetimeTransactionDate.Format = DateTimePickerFormat.Custom;
            datetimeTransactionDate.CustomFormat = "dd/MM/yyyy";

            dateTimeSearchStart.Format = DateTimePickerFormat.Custom;
            dateTimeSearchStart.CustomFormat = "dd/MM/yyyy";

            dateTimeSearchEnd.Format = DateTimePickerFormat.Custom;
            dateTimeSearchEnd.CustomFormat = "dd/MM/yyyy";

            // Initialize combo items
            InitializeTransactionTypeCombo();

            // ===== Form Load Events (Form Logic) =====
            this.Load += (s, e) =>
            {
                LoadProductsToCombo();   // ⬅️ Database logic
                LoadTransactions();      // ⬅️ Database logic
                if (dgvinventory.Columns["TransactionDate"] != null)
                    dgvinventory.Columns["TransactionDate"].DefaultCellStyle.Format = "dd/MM/yy";
                filterSeacrhProduct();
            };
        }

        // =======================================
        // 🔹 DATABASE LOGIC: Load All Transactions
        // =======================================
        private void LoadTransactions()
        {
            try
            {
                transactionsList = _inventoryService.GetAllTransactions(); // Call database
                FilterTransactions(); // Apply UI filter after loading
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load transactions:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // =======================================
        // 🔹 FORM LOGIC: Initialize Transaction Combo
        // =======================================
        private void InitializeTransactionTypeCombo()
        {
            comboTransaction.Items.Clear();
            comboTransaction.Items.AddRange(new string[]
            {
                "ReturnIn",
                "ReturnOut",
                "Transfer",
                "Sale",
                "Purchase",
                "Adjustment"
            });
            comboTransaction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTransaction.SelectedIndex = 0;
        }

        // =======================================
        // 🔹 DATABASE LOGIC: Load Products to Combo
        // =======================================
        private List<ProductDto> _productList; // Keep this at form level

        private void LoadProductsToCombo()
        {
            try
            {
                // Fetch all products (ID, Name, and Price)
                _productList = _productService.GetProductIDAndName();

                comboProduct.DataSource = _productList;
                comboProduct.DisplayMember = "ProductName";
                comboProduct.ValueMember = "ProductID";

                // Subscribe to event only once
                comboProduct.SelectedIndexChanged -= comboProduct_SelectedIndexChanged;
                comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;

                // Show the price for the first product initially (optional)
                if (_productList.Count > 0)
                {
                    var first = _productList.First();
                    textUnitPrice.Text = first.UnitPrice.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load products: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboProduct_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                if (comboProduct.SelectedValue == null || _productList == null)
                    return;

                int selectedProductId = Convert.ToInt32(comboProduct.SelectedValue);

                var selectedProduct = _productList.FirstOrDefault(p => p.ProductID == selectedProductId);
                if (selectedProduct != null)
                {
                    textUnitPrice.Text = selectedProduct.UnitPrice.ToString("N2");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error changing product: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void filterSeacrhProduct()
        {
            var product = transactionsList.Select(l => new { l.ProductID, l.ProductName })
                .Distinct()
                .ToList();
            product.Insert(0, new { ProductID = 0, ProductName = "All Product" });
            comboSearchByProduct.DataSource = product;
            comboSearchByProduct.DisplayMember = "ProductName";
            comboSearchByProduct.ValueMember = "ProductID";
            comboSearchByProduct.SelectedValue = 0;
            comboSearchByProduct.SelectedIndexChanged += (s, e) => FilterTransactions();

        }
        // =======================================
        // 🔹 DATABASE LOGIC: save or update transation to database
        // =======================================
        private void SaveOrUpdateTransation()
        {
            DateTime getDate = datetimeTransactionDate.Value;

            var model = new InventoryTransaction
            {
                TransactionID = string.IsNullOrWhiteSpace(textTransactionID.Text)
                    ? 0
                    : int.Parse(textTransactionID.Text),
                ProductID = Convert.ToInt32(comboProduct.SelectedValue),
                TransactionType = comboTransaction.Text,
                QuantityChange = Convert.ToInt32(textQuantityChange.Text),
                TransactionDate = getDate,
            };

            bool isNew = model.TransactionID == 0;
            _inventoryService.SaveTransaction(model);

            MessageBox.Show(
                isNew ? "Transaction saved successfully." : "Transaction updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LoadTransactions();
        }
        // =======================================
        // 🔹 FORM LOGIC: Filter Transactions
        // =======================================
        private void FilterTransactions()
        {
            string customerKeyword = textsearchBycustomerName.Text.Trim().ToLower();

            // Safely get selected ProductID from search combo
            int selectedProductID = 0;
            if (comboSearchByProduct != null && comboSearchByProduct.SelectedValue != null)
            {
                int.TryParse(comboSearchByProduct.SelectedValue.ToString(), out selectedProductID);
            }

            // Date range filter
            DateTime? startDate = dateTimeSearchStart.Checked ? dateTimeSearchStart.Value.Date : (DateTime?)null;
            DateTime? endDate = dateTimeSearchEnd.Checked ? dateTimeSearchEnd.Value.Date.AddDays(1).AddTicks(-1) : (DateTime?)null;

            // Perform filtering in memory (Form logic)
            var filtered = transactionsList
                .Where(t =>
                    (selectedProductID == 0 || t.ProductID == selectedProductID) &&
                    (string.IsNullOrEmpty(customerKeyword) || t.ProductName!.ToLower().Contains(customerKeyword)) &&
                    (!startDate.HasValue || t.TransactionDate >= startDate.Value) &&
                    (!endDate.HasValue || t.TransactionDate <= endDate.Value)
                )
                .ToList();

            // Display filtered data
            dgvinventory.DataSource = null;
            dgvinventory.DataSource = filtered;
            var hiddenColumns = new List<string> { "TransactionID", "ProductID", "" };
            DesignHelper.HideColumns(dgvinventory, hiddenColumns);

            if (dgvinventory.Columns["TransactionDate"] != null)
                dgvinventory.Columns["TransactionDate"].DefaultCellStyle.Format = "dd/MM/yy";
             lbTransactionTotal.Text = transactionsList.Count.ToString();
        }

        // =======================================
        // 🔹 FORM LOGIC: Update Inputs When Selecting Row
        // =======================================
        private void SelectionRowChanges()
        {
            var map = new Dictionary<string, Control>
            {
                { "TransactionID", textTransactionID },
                { "ProductID", comboProduct },
                { "UnitPrice", textUnitPrice },
                { "TransactionType", comboTransaction },
                { "QuantityChange", textQuantityChange },
                { "TransactionDate", datetimeTransactionDate }
            };

            // Helper handles UI population
            DesignHelper.PopulateRowControls(dgvinventory, map);
        }
        // =======================================
        // 🔹 FORM LOGIC: Clear Text
        // =======================================
        private void HandleClearTextBox()
        {
            DateTime date = DateTime.Now;
            textTransactionID.Clear();
            comboProduct.SelectedIndex = - 1;
            textUnitPrice.Clear();
            comboTransaction.SelectedIndex = -1;
            textQuantityChange.Clear();
            datetimeTransactionDate.Value = date;
        }
    }
}
