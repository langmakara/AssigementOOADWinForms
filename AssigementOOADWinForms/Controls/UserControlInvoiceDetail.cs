using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.DTOs.AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlInvoiceDetail : UserControl
    {
        private readonly InvoiceDetailService InvoiceDetailservice = new();
        private List<InvoiceDetailDto> invoiceDetailDtos = new();
        private readonly ProductService productService = new();
        private readonly InvoiceService invoiceService = new();

        public UserControlInvoiceDetail()
        {
            InitializeComponent();

            DesignHelper.MakeAllInputs(this);
            DesignHelper.StyleDataGridView(dgvInvoicedetail);
            dgvInvoicedetail.SelectionChanged += (s, e) => SelectionRowChanges();

            LoadComboProduct();
            LoadComboFilter();

            btnBack.Click += (s, e) => HandleGetBackToInvoice();
            btnSave.Click += (s, e) => SaveInvoiceDetail();
            btnClear.Click += (s, e) => HandleClearTextBox();
            btnRemove.Click += (s, e) => HandleRemoveInvoiceDetail();

            comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            textsearchInvoiceID.TextChanged += (s, e) => FilterInvoiceDetailsByInvoiceAndProduct();
            searchProduct.SelectedIndexChanged += (s, e) => FilterInvoiceDetailsByInvoiceAndProduct();
            textQauntity.TextChanged += TextQauntity_TextChanged;

            this.Load += (s, e) =>
            {
                // Load invoices only after form is ready
                LoadInvoiceDetail();
            };
        }

        private void HandleGetBackToInvoice()
        {
            if (this.FindForm() is Mainform main)
                main.HandleUserControlReplacseItselfMainForm(new UserControlInvoice(), "Invoice");
        }

        private void LoadComboProduct()
        {
            var products = productService.GetProductIDAndName();
            comboProduct.DataSource = products;
            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductID";
            comboProduct.SelectedIndex = -1;

            var invoices = invoiceService.GetInvoiceIDAndName();
            comboInvoiceID.DataSource = invoices;
            comboInvoiceID.DisplayMember = "InvoiceID";
            comboInvoiceID.ValueMember = "InvoiceID";
            comboInvoiceID.SelectedIndex = -1;
        }

        private void LoadComboFilter()
        {
            var products = productService.GetProductIDAndName();
            products.Insert(0, new ProductDto { ProductID = 0, ProductName = "All Product" });
            searchProduct.DataSource = products;
            searchProduct.DisplayMember = "ProductName";
            searchProduct.ValueMember = "ProductID";
            searchProduct.SelectedIndex = 0;
        }

        private void comboProduct_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboProduct.SelectedItem is ProductDto selected)
                textPrice.Text = selected.UnitPrice.ToString("C");
            else
                textPrice.Clear();
        }

        private void TextQauntity_TextChanged(object? sender, EventArgs e)
        {
            if (comboProduct.SelectedItem is ProductDto selected && int.TryParse(textQauntity.Text, out int qty))
                textTotalPrice.Text = (selected.UnitPrice * qty).ToString("C");
            else
                textTotalPrice.Clear();
        }

        private void SelectionRowChanges()
        {
            var map = new Dictionary<string, Control>
            {
                { "InvoiceDetailID", textInvoiceDetailID },
                { "InvoiceID", comboInvoiceID },
                { "Quantity", textQauntity },
                { "UnitPrice", textPrice },
                { "ProductID", comboProduct },
                { "TotalPrice", textTotalPrice }
            };

            DesignHelper.PopulateRowControls(dgvInvoicedetail, map);
        }

        private void HandleClearTextBox()
        {
            textInvoiceDetailID.Clear();
            comboInvoiceID.SelectedIndex = -1;
            comboProduct.SelectedIndex = -1;
            textQauntity.Clear();
            textPrice.Clear();
            textTotalPrice.Clear();
        }

        private void FilterInvoiceDetailsByInvoiceAndProduct()
        {
            int invoiceID = 0;
            if (!string.IsNullOrWhiteSpace(textsearchInvoiceID.Text))
                int.TryParse(textsearchInvoiceID.Text, out invoiceID);

            int productID = searchProduct.SelectedValue != null ? Convert.ToInt32(searchProduct.SelectedValue) : 0;

            var filtered = invoiceDetailDtos
                .Where(d => (invoiceID == 0 || d.InvoiceID == invoiceID) &&
                            (productID == 0 || d.ProductID == productID))
                .ToList();

            dgvInvoicedetail.DataSource = null;
            dgvInvoicedetail.DataSource = filtered;

            if (dgvInvoicedetail.Columns["UnitPrice"] != null)
                dgvInvoicedetail.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";

            DesignHelper.HideColumns(dgvInvoicedetail, new List<string> { "InvoiceDetailID", "ProductID", "" });
        }

        private void LoadInvoiceDetail(int invoiceID = 0)
        {
            try
            {
                invoiceDetailDtos = invoiceID == 0
                    ? InvoiceDetailservice.GetAllInvoiceDetails()
                    : InvoiceDetailservice.GetInvoiceDetailsByInvoiceID(invoiceID);

                dgvInvoicedetail.DataSource = null;
                dgvInvoicedetail.DataSource = invoiceDetailDtos;

                DesignHelper.HideColumns(dgvInvoicedetail, new List<string> { "InvoiceDetailID", "ProductID", "" });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load invoice detail:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveInvoiceDetail()
        {
            if (comboInvoiceID.SelectedValue == null || comboProduct.SelectedValue == null)
            {
                MessageBox.Show("Please select an Invoice and Product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textQauntity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textPrice.Text.Replace("$", "").Replace(",", ""), out decimal unitPrice))
            {
                MessageBox.Show("Unit price is invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var model = new InvoiceDetail
            {
                InvoiceDetailID = int.TryParse(textInvoiceDetailID.Text, out int detailID) ? detailID : 0,
                InvoiceID = Convert.ToInt32(comboInvoiceID.SelectedValue),
                ProductID = Convert.ToInt32(comboProduct.SelectedValue),
                Quantity = quantity,
                UnitPrice = unitPrice
            };

            int savedID = InvoiceDetailservice.SaveInvoiceDetailToDatabase(model);

            string action = model.InvoiceDetailID == 0 ? "added" : "updated";
            MessageBox.Show($"Invoice Detail {action}! ID: {savedID}");

            LoadInvoiceDetail();
            foreach (DataGridViewRow row in dgvInvoicedetail.Rows)
            {
                if ((int)row.Cells["InvoiceDetailID"].Value == savedID)
                {
                    row.Selected = true;
                    dgvInvoicedetail.CurrentCell = row.Cells[0];
                    break;
                }
            }

            SelectionRowChanges();
        }




        private void HandleRemoveInvoiceDetail()
        {
            if (!int.TryParse(textInvoiceDetailID.Text, out int detailID) || detailID == 0)
            {
                MessageBox.Show("Please select a valid invoice detail to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this invoice detail?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                var invoiceID = Convert.ToInt32(comboInvoiceID.SelectedValue);
                InvoiceDetailservice.DeleteInvoiceDetail(detailID);
                MessageBox.Show("Invoice detail deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload details only for this invoice
                LoadInvoiceDetail(invoiceID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete invoice detail:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
