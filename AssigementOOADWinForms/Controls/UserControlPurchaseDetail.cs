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
    public partial class UserControlPurchaseDetail : UserControl
    {
        private List<PurchaseOrderDeailDots> purchaseOrderDetailDtos = new();
        private readonly PurchaseOrderDeailService _purchaseOrderDetailService = new();

        public UserControlPurchaseDetail()
        {
            InitializeComponent();
            // UI design helpers
            DesignHelper.MakeAllInputs(this);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvPurchaseDetail);

            // DataGridView config
            dgvPurchaseDetail.SelectionChanged += SelectionRowChanges;
            dgvPurchaseDetail.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvPurchaseDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseDetail.AutoGenerateColumns = true;

            // Events
            btClear.Click += HandleClearTextBox;
            btSave.Click += HandleSavePurchaseOrderDetail;
            btRemove.Click += HandleRemovePurchaseOrderDetail;
            tbPurchaseDetailID.TextChanged += (s, e) => FilterPurchaseOrderDetails();
            this.Load += (s, e) => LoadPurchaseOrderDetails();
        }

        // ===============================
        // Load PurchaseOrderDetails from database
        // ===============================
        private void LoadPurchaseOrderDetails()
        {
            try
            {
                var purchaseOrderDetails = _purchaseOrderDetailService.GetAllPurchaseOrderDetails();
                purchaseOrderDetailDtos = purchaseOrderDetails.Select(p => new PurchaseOrderDeailDots
                {
                    PurchaseDetailID = p.PurchaseDetailID,
                    PurchaseID = p.PurchaseID,
                    ProductID = p.ProductID,
                    Quantity = p.Quantity,
                    UnitPrice = p.UnitPrice
                }).ToList();

                dgvPurchaseDetail.DataSource = null;
                dgvPurchaseDetail.DataSource = purchaseOrderDetailDtos;

                UpdatePurchaseDetailCount(); //Update total count
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Filter PurchaseOrderDetails Based on search criteria
        // ===============================
        private void FilterPurchaseOrderDetails()
        {
            try
            {
                var filteredList = purchaseOrderDetailDtos.AsEnumerable();

                if (int.TryParse(tbPurchaseDetailID.Text, out int purchaseDetailID))
                {
                    filteredList = filteredList.Where(p => p.PurchaseDetailID == purchaseDetailID);
                }

                dgvPurchaseDetail.DataSource = filteredList.ToList();

                UpdatePurchaseDetailCount(); //Update after filtering
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering purchase details:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Show Total Purchase Details
        // ===============================
        private void UpdatePurchaseDetailCount()
        {
            try
            {
                if (lbTotalPurchaseDetail != null)
                {
                    int total = dgvPurchaseDetail.Rows.Count;
                    lbTotalPurchaseDetail.Text = $"{total}";
                }
            }
            catch
            {
                // Ignore if label doesn't exist or grid not ready
            }
        }

        // ===============================
        // Clear all input fields
        // ===============================
        private void HandleClearTextBox(object? sender, EventArgs e)
        {
            tbPurchaseDetailID.Clear();
            tbPurchaseID.Clear();
            tbProductID.Clear();
            tbQuantity.Clear();
            tbUnitPrice.Clear();
        }

        // ===============================
        // Selection & From Controls
        // ===============================
        private void SelectionRowChanges(object? sender, EventArgs e)
        {
            var map = new Dictionary<string, Control>
            {
                { "PurchaseDetailID", tbPurchaseDetailID },
                { "PurchaseID", tbPurchaseID },
                { "ProductID", tbProductID },
                { "Quantity", tbQuantity },
                { "UnitPrice", tbUnitPrice }
            };
            DesignHelper.PopulateRowControls(dgvPurchaseDetail, map);
        }

        // ===============================
        // CRUD Operations
        // ===============================
        private void HandleSavePurchaseOrderDetail(object? sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(tbPurchaseID.Text) || !int.TryParse(tbPurchaseID.Text, out int purchaseId))
                {
                    MessageBox.Show("Please enter a valid Purchase ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbProductID.Text) || !int.TryParse(tbProductID.Text, out int productId))
                {
                    MessageBox.Show("Please enter a valid Product ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbQuantity.Text) || !int.TryParse(tbQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Please enter a valid Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbUnitPrice.Text) || !decimal.TryParse(tbUnitPrice.Text, out decimal unitPrice))
                {
                    MessageBox.Show("Please enter a valid Unit Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var model = new PurchaseOrderDetail
                {
                    PurchaseDetailID = string.IsNullOrWhiteSpace(tbPurchaseDetailID.Text) ? 0 : int.Parse(tbPurchaseDetailID.Text),
                    PurchaseID = purchaseId,
                    ProductID = productId,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                };

                _purchaseOrderDetailService.SavePurchaseOrderDeail(model);
                LoadPurchaseOrderDetails();

                MessageBox.Show("Purchase order detail saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdatePurchaseDetailCount(); // Update count
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

        private void HandleRemovePurchaseOrderDetail(object? sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tbPurchaseDetailID.Text, out int purchaseDetailID))
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
                    UpdatePurchaseDetailCount(); //Update after deletion
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
