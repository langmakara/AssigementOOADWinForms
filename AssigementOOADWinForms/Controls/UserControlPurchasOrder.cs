using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlPurchasOrder : UserControl
    {
        private List<PurchaseOrderDto> purchaseOrderDtos = new();
        private readonly PurchaseOrderService _purchaseOrderService = new();
        private readonly BindingSource purchaseBinding = new();

        public UserControlPurchasOrder()
        {
            InitializeComponent();
            // UI design helpers
            DesignHelper.MakeAllInputs(this);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvPurchase);
            // DataGridView config
            dgvPurchase.SelectionChanged += SelectionRowChanges;
            dgvPurchase.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvPurchase.DataError += DgvPurchase_DataError; // suppress default error dialog
            dgvPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchase.AutoGenerateColumns = true;
            // Bind via BindingSource to avoid CurrencyManager / index issues
            dgvPurchase.DataSource = purchaseBinding;
            // Events
            btClear.Click += HandleClearTextBox;
            btSave.Click += HandleSavePurchaseOrder;
            btRemove.Click += HandleRemovePurchaseOrder;
            // Filter should respond to EmployeeName input
            tbSearchEmployeeName.TextChanged += (s, e) => FilterPurchaseOrders();
            btnCreatePurchase.Click += (s, e) => HandleChangeUserControlInvoiceToCreatePurchasDetail();
            this.Load += (s, e) => LoadPurchaseOrders();
        }

        private void DgvPurchase_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            // Prevent the default DataGridView error dialog and stop propagation.
            // For debugging you can log e.Exception, column/row indexes.
            e.ThrowException = false;
            e.Cancel = true;
        }

        private void HandleChangeUserControlInvoiceToCreatePurchasDetail()
        {
            if (this.FindForm() is Mainform main)
            {
                main.HandleUserControlReplacseItselfMainForm(new UserControlPurchaseDetail(), "PurchaseDetail");
            }
        }
        // ===============================
        // Load PurchaseOrders from database
        // ===============================
        private void LoadPurchaseOrders()
        {
            try
            {
                var purchaseOrders = _purchaseOrderService.GetAllPurchaseOrders();
                purchaseOrderDtos = purchaseOrders.Select(p => new PurchaseOrderDto
                {
                    PurchaseID = p.PurchaseID,
                    SupplierID = p.SupplierID,
                    SupplierName = p.SupplierName,
                    EmployeeID = p.EmployeeID,
                    EmployeeName = p.EmployeeName,
                    OrderDate = p.OrderDate,
                    TotalAmount = p.TotalAmount
                }).ToList();

                // Use BindingSource to safely update grid
                purchaseBinding.DataSource = null;
                purchaseBinding.DataSource = purchaseOrderDtos;
                dgvPurchase.ClearSelection();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===============================
        // Filter PurchaseOrders by EmployeeName
        // ===============================
        private void FilterPurchaseOrders()
        {
            try
            {
                if (purchaseOrderDtos == null || purchaseOrderDtos.Count == 0)
                {
                    purchaseBinding.DataSource = null;
                    return;
                }

                var filtered = purchaseOrderDtos.AsEnumerable();

                // Use employee name textbox for searching
                var searchName = tbSearchEmployeeName.Text.Trim();
                if (!string.IsNullOrEmpty(searchName))
                {
                    filtered = filtered.Where(e => !string.IsNullOrEmpty(e.EmployeeName) &&
                                                   e.EmployeeName.Contains(searchName, StringComparison.OrdinalIgnoreCase));
                }

                // Update binding source safely
                dgvPurchase.SelectionChanged -= SelectionRowChanges;
                try
                {
                    purchaseBinding.DataSource = filtered.ToList();
                    dgvPurchase.ClearSelection();
                }
                finally
                {
                    dgvPurchase.SelectionChanged += SelectionRowChanges;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while filtering: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===============================
        // Clear all input fields
        // ===============================
        private void HandleClearTextBox(object sender, EventArgs e)
        {
            tbPuchaseOderID.Clear();
            tbSupplierID.Clear();
            tbSupplierName.Clear();
            tbEmployeeID.Clear();
            tbEmployeeName.Clear();
            DTPOrderDate.Value = DateTime.Now;
            tbTotal.Clear();
            dgvPurchase.ClearSelection();
        }
        // -------------------------
        // Selection & Form Controls
        // -------------------------
        private void SelectionRowChanges(object sender, EventArgs e)
        {
            // Defensive: ensure there is a valid current row and data
            if (dgvPurchase.CurrentRow == null)
                return;

            if (dgvPurchase.CurrentRow.DataBoundItem is not PurchaseOrderDto dto)
                return;

            // Populate controls directly from the DTO to avoid index/column binding issues
            tbPuchaseOderID.Text = dto.PurchaseID.ToString();
            tbSupplierID.Text = dto.SupplierID?.ToString() ?? string.Empty;
            tbSupplierName.Text = dto.SupplierName ?? string.Empty;
            tbEmployeeID.Text = dto.EmployeeID?.ToString() ?? string.Empty;
            tbEmployeeName.Text = dto.EmployeeName ?? string.Empty;
            DTPOrderDate.Value = dto.OrderDate;
            tbTotal.Text = dto.TotalAmount.ToString("F2");
        }
        // ===============================
        // CRUD Logic
        // ===============================

        private void HandleSavePurchaseOrder(object sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(tbSupplierID.Text) || !int.TryParse(tbSupplierID.Text, out int supplierId))
                {
                    MessageBox.Show("Please enter a valid Supplier ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbEmployeeID.Text) || !int.TryParse(tbEmployeeID.Text, out int employeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(tbTotal.Text, out decimal total))
                {
                    MessageBox.Show("Please enter a valid total amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var model = new PurchaseOrder
                {
                    // Use the purchase-order textbox that this form actually uses
                    PurchaseID = string.IsNullOrWhiteSpace(tbPuchaseOderID.Text) ? 0 : int.Parse(tbPuchaseOderID.Text),
                    SupplierID = supplierId,
                    EmployeeID = employeeId,
                    OrderDate = DTPOrderDate.Value,
                    TotalAmount = total
                };

                _purchaseOrderService.SavePurchaseOrder(model);
                LoadPurchaseOrders();
                MessageBox.Show("Purchase order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error:\n{sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save purchase order:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleRemovePurchaseOrder(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbPuchaseOderID.Text) || !int.TryParse(tbPuchaseOderID.Text, out int purchaseId))
                {
                    MessageBox.Show("Please select a valid purchase order to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this purchase order?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _purchaseOrderService.RemovePurchaseOrder(purchaseId);
                    LoadPurchaseOrders();
                    MessageBox.Show("Purchase order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error:\n{sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete purchase order:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
