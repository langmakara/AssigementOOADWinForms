using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlProduct : UserControl
    {
        private readonly ProductService _service = new();
        public UserControlProduct()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvProduct);
            dgvProduct.CellPainting += DesignHelper.dataGridView1_CellPainting;
            LoadProductData();
            LoadProduct();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tbProductID.Clear();
            tbSeach.Clear();
            tbProductName.Clear();
            tbSupplierID.Clear();
            tbSupplierName.Clear();
            tbUnitPrice.Clear();
            tbQuantity.Clear();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbProductName.Text) ||
                    string.IsNullOrWhiteSpace(tbSupplierName.Text) ||
                    string.IsNullOrWhiteSpace(tbUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(tbQuantity.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var model = new Product
                {
                    ProductID = string.IsNullOrWhiteSpace(tbProductID.Text) ? 0 : int.Parse(tbProductID.Text),
                    ProductName = tbProductName.Text.Trim(),
                    SupplierID = string.IsNullOrWhiteSpace(tbSupplierID.Text) ? 0 : int.Parse(tbSupplierID.Text),
                    SupplierName = tbSupplierName.Text.Trim(),
                    UnitPrice = decimal.TryParse(tbUnitPrice.Text, out decimal price) ? price : 0,
                    QuantityInStock = int.TryParse(tbQuantity.Text, out int qty) ? qty : 0
                };
                _service.SaveProduct(model);
                MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadProduct()
        {
            var dt = _service.GetAllProducts();
            dgvProduct.DataSource = dt;
        }

        private void tbSeach_TextChanged(object sender, EventArgs e)
        {
            LoadProductData(tbSeach.Text.Trim());
        }

        private void LoadProductData(string filter = "")
        {
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM tbProduct";

                if (!string.IsNullOrEmpty(filter))
                {
                    query += " WHERE ProductName LIKE @filter";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(filter))
                {
                    cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProduct.DataSource = dt;
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

                // Assign values from selected row to TextBoxes
                tbSupplierID.Text = row.Cells["SupplierID"].Value.ToString();
                tbSupplierName.Text = row.Cells["SupplierName"].Value.ToString();
                tbProductName.Text = row.Cells["ProductName"].Value.ToString();
                tbProductID.Text = row.Cells["ProductID"].Value.ToString();
                tbUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                tbQuantity.Text = row.Cells["QuantityInStock"].Value.ToString();
            }
        }
    }
}
