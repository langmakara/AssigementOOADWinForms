using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.DTOs.AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

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
            //Form DataGrideView 
            DesignHelper.MakeAllInputsRounded(this, radius: 3);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvInvoicedetail);
            dgvInvoicedetail.CellPainting += DesignHelper.dataGridView1_CellPainting;
            //Handle Logic DataGrideView
            dgvInvoicedetail.SelectionChanged += (s, e) => SelectionRowChanges();
            //Handle Btn Logic call event
            LoadComboProduct();
            LaodComboFilter();
            btnBack.Click += (s, e) => HandleGetBackToInvoice();
            btnSave.Click += (s, e) => SaveInvoiceDetail();
            btnClear.Click += (s, e) => HandleClearTextBox();
            btnRemove.Click += (s, e) => HandleRemoveInvoiceDetail();
            comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            textsearchInvoiceID.TextChanged += (s, e) => FilterInvoiceDetailsByInvoiceAndProduct();
            searchProduct.SelectedIndexChanged += (s, e) => FilterInvoiceDetailsByInvoiceAndProduct();
            textQauntity.TextChanged += TextQauntity_TextChanged;
            this.Load += (s, e) => LoadInvoiceDetail();
        }

        // Handle Form Logic
        private void HandleGetBackToInvoice()
        {
            if (this.FindForm() is Mainform main)
            {
                main.HandleUserControlReplacseItselfMainForm(new UserControlInvoice(), "Invoice");
            }
        }
        private void LoadComboProduct()
        {
            var GetProductIDAndName = productService.GetProductIDAndName();
            var GetInvoiceIDAndName = invoiceService.GetInvoiceIDAndName();
            comboProduct.DataSource = GetProductIDAndName;
            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductID";
            comboProduct.SelectedIndex = -1;
            comboInvoiceID.DataSource = GetInvoiceIDAndName;
            comboInvoiceID.DisplayMember = "InvoiceID";
            comboInvoiceID.ValueMember = "InvoiceID";
            comboInvoiceID.SelectedIndex = -1;
        }
        private void LaodComboFilter()
        {
            var GetProductIDAndName = productService.GetProductIDAndName();
            GetProductIDAndName.Insert(0, new ProductDto { ProductID = 0, ProductName = " All Product" });
            searchProduct.DataSource = GetProductIDAndName;
            searchProduct.DisplayMember = "ProductName";
            searchProduct.ValueMember = "ProductID";
            searchProduct.SelectedIndex = 0;
        }
        private bool isLoadingRow = false;
        private void comboProduct_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (isLoadingRow) return;

            if (comboProduct.SelectedItem is ProductDto selectedProduct)
            {


                textPrice.Text = selectedProduct.UnitPrice.ToString("C");
            }
            else
            {
                textPrice.Clear();
            }
        }
        private void TextQauntity_TextChanged(object? sender, EventArgs e)
        {
            if (comboProduct.SelectedItem is ProductDto selectedProduct)
            {
                if (int.TryParse(textQauntity.Text, out int quantity))
                {
                    decimal total = selectedProduct.UnitPrice * quantity;
                    textTotalPrice.Text = total.ToString("C");
                }
                else
                {
                    textTotalPrice.Clear();
                }
            }
            else
            {
                textTotalPrice.Clear();
            }
        }
        private void SelectionRowChanges()
        {
            var map = new Dictionary<string, Control>
            {
                { "InvoiceDetailID", textInvoiceDetailID },
                { "InvoiceID", comboInvoiceID },
                { "Quantity", textQauntity },
                { "UnitPrice", textPrice },
                {"ProductID", comboProduct},
                {"TotalPrice" , textTotalPrice}
            };

            DesignHelper.PopulateRowControls(dgvInvoicedetail, map);
        }

        private void HandleClearTextBox()
        {
            textInvoiceDetailID.Clear();
            comboInvoiceID.SelectedIndex = -1;
            textQauntity.Clear();
            textPrice.Clear();
            comboProduct.SelectedIndex = -1;
        }
        private void FilterInvoiceDetailsByInvoiceAndProduct()
        {
            // Get selected/typed filter values
            int selectedInvoiceID = 0;
            if (!string.IsNullOrWhiteSpace(textsearchInvoiceID.Text) &&
                int.TryParse(textsearchInvoiceID.Text, out int invoiceID))
            {
                selectedInvoiceID = invoiceID;
            }

            int selectedProductID = searchProduct.SelectedValue != null
                ? Convert.ToInt32(searchProduct.SelectedValue)
                : 0;

            // Filter the master list
            var filtered = invoiceDetailDtos
                .Where(d =>
                    (selectedInvoiceID == 0 || d.InvoiceID == selectedInvoiceID) &&
                    (selectedProductID == 0 || d.ProductID == selectedProductID)
                )
                .ToList();

            // Bind to DataGridView
            dgvInvoicedetail.DataSource = null;
            dgvInvoicedetail.DataSource = filtered;

            // Format UnitPrice as currency
            if (dgvInvoicedetail.Columns["UnitPrice"] != null)
                dgvInvoicedetail.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";

            // Hide internal columns
            DesignHelper.HideColumns(dgvInvoicedetail, new List<string> { "InvoiceDetailID" });
        }
        private void LoadInvoiceDetail()
        {
            try
            {
                invoiceDetailDtos = InvoiceDetailservice.GetAllInvoiceDetails();
                dgvInvoicedetail.DataSource = null;
                dgvInvoicedetail.DataSource = invoiceDetailDtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load invoice detail:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SaveInvoiceDetail()
        {
            var model = new InvoiceDetail
            {
                InvoiceDetailID = Convert.ToInt32( textInvoiceDetailID.Text ),
                InvoiceID = Convert.ToInt32(comboInvoiceID.SelectedValue),
                ProductID = Convert.ToInt32(comboProduct.SelectedValue),
                Quantity = int.Parse(textQauntity.Text),
                UnitPrice = decimal.Parse(textPrice.Text.Replace("$", "").Replace(",", ""))
            };
            int savedID = InvoiceDetailservice.SaveInvoiceDetailToDatabase(model);
            MessageBox.Show($"Invoice Detail saved! ID: {savedID}");
        }
        private void HandleRemoveInvoiceDetail()
        {
            int invoiceId;

            // Step 1: Determine Invoice ID
            if (!string.IsNullOrWhiteSpace(textInvoiceDetailID.Text) && int.TryParse(textInvoiceDetailID.Text, out invoiceId))
            {
                // valid from textbox
            }
            else if (dgvInvoicedetail.CurrentRow != null)
            {
                invoiceId = Convert.ToInt32(dgvInvoicedetail.CurrentRow.Cells["InvoiceID"].Value);
            }
            else
            {
                MessageBox.Show("Please select an invoice to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 2: Confirm deletion
            if (MessageBox.Show("Are you sure you want to delete this invoice?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // Step 3: Delete and reload
                InvoiceDetailservice.DeleteInvoiceDetail(invoiceId);
                MessageBox.Show("Invoice deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadInvoiceDetail();

                // Step 4: Re-select first row if available
                if (dgvInvoicedetail.Rows.Count > 0)
                {
                    dgvInvoicedetail.ClearSelection();
                    var firstRow = dgvInvoicedetail.Rows[0];
                    firstRow.Selected = true;

                    DataGridViewCell? firstVisibleCell = null;
                    foreach (DataGridViewCell cell in firstRow.Cells)
                    {
                        if (cell.Visible)
                        {
                            firstVisibleCell = cell;
                            break;
                        }
                    }

                    if (firstVisibleCell != null)
                        dgvInvoicedetail.CurrentCell = firstVisibleCell;

                    SelectionRowChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete invoice:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


