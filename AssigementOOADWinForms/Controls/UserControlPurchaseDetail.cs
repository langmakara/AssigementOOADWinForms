using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlPurchaseDetail : UserControl
    {
        private List<PurchaseOrderDeailDots> purchaseOrderDetailDtos = new();
        private readonly PurchaseOrderDeailService _purchaseOrderDetailService = new();

        private bool _suppressSelectionUpdates = false;

        public UserControlPurchaseDetail()
        {
            InitializeComponent();

            DesignHelper.MakeAllInputs(this);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvPurchaseDetail);

            dgvPurchaseDetail.SelectionChanged += SelectionRowChanges;
            dgvPurchaseDetail.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvPurchaseDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseDetail.AutoGenerateColumns = true;

            btClear.Click += HandleClearTextBox;
            btSave.Click += HandleSavePurchaseOrderDetail;
            btRemove.Click += HandleRemovePurchaseOrderDetail;

            // ✅ Use tbSeashPurchaseDetailD for filtering
            tbSeashPurchaseDetailD.TextChanged += (s, e) => FilterPurchaseOrderDetails();

            this.Load += (s, e) => LoadPurchaseOrderDetails();
        }

        // ===============================
        // Load all Purchase Order Details
        // ===============================
        private void LoadPurchaseOrderDetails()
        {
            try
            {
                var purchaseOrderDetails = _purchaseOrderDetailService.GetAllPurchaseOrderDetails();
                purchaseOrderDetailDtos = purchaseOrderDetails.Select(static p => new PurchaseOrderDeailDots
                {
                    PurchaseDetailID = p.PurchaseDetailID,
                    PurchaseID = p.PurchaseID,
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    Quantity = p.Quantity,
                    UnitPrice = p.UnitPrice
                }).ToList();

                dgvPurchaseDetail.DataSource = null;
                dgvPurchaseDetail.DataSource = purchaseOrderDetailDtos;
                dgvPurchaseDetail.ClearSelection();
                UpdatePurchaseDetailCount();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Filter using tbSeashPurchaseDetailD
        // ===============================
        private void FilterPurchaseOrderDetails()
        {
            try
            {
                if (_suppressSelectionUpdates)
                    return;

                var filtered = purchaseOrderDetailDtos.AsEnumerable();
                string searchText = tbSeashPurchaseDetailD?.Text?.Trim() ?? string.Empty;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Try parse number for numeric fields
                    bool isNumber = int.TryParse(searchText, out int numericValue);

                    filtered = filtered.Where(p =>
                        (isNumber && (p.PurchaseID == numericValue || p.ProductID == numericValue || p.PurchaseDetailID == numericValue)) ||
                        (!isNumber && (
                            (!string.IsNullOrEmpty(p.ProductName) && p.ProductName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                        )));
                }

                dgvPurchaseDetail.DataSource = filtered.ToList();
                dgvPurchaseDetail.ClearSelection();
                UpdatePurchaseDetailCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to filter purchase details:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Clear all input fields
        // ===============================
        private void HandleClearTextBox(object? sender, EventArgs e)
        {
            try
            {
                _suppressSelectionUpdates = true;

                tbPurchaseDetailID?.Clear();
                tbPurchaseID?.Clear();
                tbProductID?.Clear();
                tbQuantity?.Clear();
                tbUnitPrice?.Clear();
                tbSeashPurchaseDetailD.Clear();

                dgvPurchaseDetail?.ClearSelection();
                UpdatePurchaseDetailCount();

                tbPurchaseID?.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to clear fields: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                _suppressSelectionUpdates = false;
            }
        }

        // ===============================
        // Update fields when row changes
        // ===============================
        private void SelectionRowChanges(object? sender, EventArgs e)
        {
            if (_suppressSelectionUpdates)
                return;

            var map = new Dictionary<string, Control>
            {
                { "PurchaseDetailID", tbPurchaseDetailID },
                { "PurchaseID", tbPurchaseID },
                { "ProductID", tbProductID },
                { "Quantity", tbQuantity },
                { "UnitPrice", tbUnitPrice }
            };

            _suppressSelectionUpdates = true;
            try
            {
                DesignHelper.PopulateRowControls(dgvPurchaseDetail, map);
            }
            finally
            {
                _suppressSelectionUpdates = false;
            }
        }

        // ===============================
        // Show total Purchase Details count
        // ===============================
        private void UpdatePurchaseDetailCount()
        {
            try
            {
                if (lbTotalPurchaseDetail != null && dgvPurchaseDetail != null)
                {
                    int total = dgvPurchaseDetail.Rows.Count;
                    lbTotalPurchaseDetail.Text = $"{total}";
                }
            }
            catch
            {
                // Ignore
            }
        }

        // ===============================
        // Save Purchase Detail
        // ===============================
        private void HandleSavePurchaseOrderDetail(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbPurchaseID.Text) ||
                    !int.TryParse(tbPurchaseID.Text, out int purchaseId))
                {
                    MessageBox.Show("Please enter a valid Purchase ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbProductID.Text) ||
                    !int.TryParse(tbProductID.Text, out int productId))
                {
                    MessageBox.Show("Please enter a valid Product ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbQuantity.Text) ||
                    !int.TryParse(tbQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Please enter a valid Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbUnitPrice.Text) ||
                    !decimal.TryParse(tbUnitPrice.Text, out decimal unitPrice))
                {
                    MessageBox.Show("Please enter a valid Unit Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int purchaseDetailIdValue = 0;
                if (!string.IsNullOrWhiteSpace(tbPurchaseDetailID.Text))
                {
                    int.TryParse(tbPurchaseDetailID.Text, out purchaseDetailIdValue);
                }

                var model = new PurchaseOrderDetail
                {
                    PurchaseDetailID = purchaseDetailIdValue,
                    PurchaseID = purchaseId,
                    ProductID = productId,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                };

                _purchaseOrderDetailService.SavePurchaseOrderDeail(model);
                LoadPurchaseOrderDetails();

                MessageBox.Show("Purchase order detail saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdatePurchaseDetailCount();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error:\n{sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save purchase order detail:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Remove Purchase Detail
        // ===============================
        private void HandleRemovePurchaseOrderDetail(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbPurchaseDetailID.Text) ||
                    !int.TryParse(tbPurchaseDetailID.Text, out int purchaseDetailID))
                {
                    MessageBox.Show("Please select a valid Purchase Detail ID to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this purchase order detail?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _purchaseOrderDetailService.RemovePurchaseOrderDeail(purchaseDetailID);
                    LoadPurchaseOrderDetails();
                    MessageBox.Show("Purchase order detail removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatePurchaseDetailCount();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error:\n{sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove purchase order detail:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
