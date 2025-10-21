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
        private List<InventoryTransactionDto> transactionsList = new();
        private readonly InventoryTransactionService _inventoryService = new();
        private readonly ProductService _productService = new();

        public UserControlInventory()
        {
            InitializeComponent();

            DesignHelper.MakeAllInputs(this);
            DesignHelper.ApplyRoundedStyle(panel1, 5);
            DesignHelper.ApplyRoundedStyle(panel2, 5);
            DesignHelper.ApplyRoundedStyle(panel3, 5);
            DesignHelper.StyleDataGridView(dgvinventory);
            dgvinventory.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dateTimeSearchStart.ValueChanged += (s, e) => FilterTransactions();
            dateTimeSearchStart.MouseUp += (s, e) => FilterTransactions();
            dateTimeSearchEnd.ValueChanged += (s, e) => FilterTransactions();
            dateTimeSearchEnd.MouseUp += (s, e) => FilterTransactions();
            comboSearchByProduct.SelectedIndexChanged += (s, e) => FilterTransactions();
            textsearchBycustomerName.TextChanged += (s, e) => FilterTransactions();


            btnRefresh.Click += (s, e) => LoadTransactions();
            dgvinventory.SelectionChanged += (s, e) => SelectionRowChanges();
            dgvinventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            textsearchBycustomerName.TextChanged += (s, e) => FilterTransactions();
            datetimeTransactionDate.Format = DateTimePickerFormat.Custom;
            datetimeTransactionDate.CustomFormat = "dd/MM/yyyy";

            dateTimeSearchStart.Format = DateTimePickerFormat.Custom;
            dateTimeSearchStart.CustomFormat = "dd/MM/yyyy";

            dateTimeSearchEnd.Format = DateTimePickerFormat.Custom;
            dateTimeSearchEnd.CustomFormat = "dd/MM/yyyy";
            InitializeTransactionTypeCombo();

            this.Load += (s, e) =>
            {
                LoadProductsToCombo();
                LoadTransactions();
                if (dgvinventory.Columns["TransactionDate"] != null)
                    dgvinventory.Columns["TransactionDate"].DefaultCellStyle.Format = "dd/MM/yy";
            };
        }

        private void LoadTransactions()
        {
            try
            {
                transactionsList = _inventoryService.GetAllTransactions();
                FilterTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load transactions:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeTransactionTypeCombo()
        {
            comboTransaction.Items.Clear();
            comboTransaction.Items.AddRange(new string[]
            {
                "Purchase",
                "Sale",
                "Adjustment",
                "ReturnIn",
                "ReturnOut",
                "Transfer"
            });
            comboTransaction.SelectedIndex = 0;
        }
        private void LoadProductsToCombo()
        {
            try
            {
                var products = _productService.GetProductIDAndName();
                comboProduct.DataSource = products;
                comboProduct.DisplayMember = "ProductName";
                comboProduct.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FilterTransactions()
        {
            string customerKeyword = textsearchBycustomerName.Text.Trim().ToLower();

            // Safely get selected ProductID from the search combo
            int selectedProductID = 0;
            if (comboSearchByProduct != null && comboSearchByProduct.SelectedValue != null)
            {
                int.TryParse(comboSearchByProduct.SelectedValue.ToString(), out selectedProductID);
            }

            DateTime? startDate = dateTimeSearchStart.Checked ? dateTimeSearchStart.Value.Date : (DateTime?)null;
            DateTime? endDate = dateTimeSearchEnd.Checked ? dateTimeSearchEnd.Value.Date.AddDays(1).AddTicks(-1) : (DateTime?)null;

            var filtered = transactionsList
                .Where(t =>
                    (selectedProductID == 0 || t.ProductID == selectedProductID) &&
                    (string.IsNullOrEmpty(customerKeyword) || t.ProductName!.ToLower().Contains(customerKeyword)) &&
                    (!startDate.HasValue || t.TransactionDate >= startDate.Value) &&
                    (!endDate.HasValue || t.TransactionDate <= endDate.Value)
                )
                .ToList();

            dgvinventory.DataSource = null;
            dgvinventory.DataSource = filtered;

            if (dgvinventory.Columns["TransactionDate"] != null)
                dgvinventory.Columns["TransactionDate"].DefaultCellStyle.Format = "dd/MM/yy";
        }


        private void SelectionRowChanges()
        {
            var map = new Dictionary<string, Control>
            {
                { "ProductID", comboProduct },
                { "UnitPrice", textUnitPrice },
                { "TransactionType", comboTransaction },
                { "QuantityChange", textQuantityChange },
                { "TransactionDate", datetimeTransactionDate }
            };
            DesignHelper.PopulateRowControls(dgvinventory, map);
        
        }

    }
}
