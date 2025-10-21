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
            dgvPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchase.AutoGenerateColumns = true;
            // Events
            btClear.Click += HandleClearTextBox;
            btSave.Click += HandleSavePurchaseOrder;
            btRemove.Click += HandleRemovePurchaseOrder;
            tbPurchaseID.TextChanged += (s, e) => FilterPurchaseOrders();
            this.Load += (s, e) => LoadPurchaseOrders();
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
                dgvPurchase.DataSource = null;
                dgvPurchase.DataSource = purchaseOrderDtos;
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
        // Filter PurchaseOrders based on search criteria
        // ===============================
        private void FilterPurchaseOrders()
        {
            var filteredList = purchaseOrderDtos.AsEnumerable();
            if (int.TryParse(tbPurchaseID.Text, out int purchaseId))
            {
                filteredList = filteredList.Where(p => p.PurchaseID == purchaseId);
            }
            dgvPurchase.DataSource = filteredList.ToList();
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
            var map = new Dictionary<string, Control>
            {
                { "PurchaseID", tbPuchaseOderID },
                { "SupplierID", tbSupplierID },
                {"SupplierName", tbSupplierName },
                { "EmployeeID", tbEmployeeID },
                { "EmployeeName", tbEmployeeName },
                { "OrderDate", DTPOrderDate },
                { "TotalAmount", tbTotal }
            };

            DesignHelper.PopulateRowControls(dgvPurchase, map);
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
                    PurchaseID = string.IsNullOrWhiteSpace(tbPurchaseID.Text) ? 0 : int.Parse(tbPurchaseID.Text),
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
                if (string.IsNullOrWhiteSpace(tbPurchaseID.Text) || !int.TryParse(tbPurchaseID.Text, out int purchaseId))
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
