using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using Microsoft.Data.SqlClient;
using System.Data;
namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlSupplier : UserControl
    {
        private readonly SupplierService _service = new();
        public UserControlSupplier()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvSupplier);
            dgvSupplier.CellPainting += DesignHelper.dataGridView1_CellPainting;
            LoadSupplierData();
            LoadSuppliers(); // load all suppliers when form loads
            btSave.Click += btSave_Click;
        }

        private void LoadSupplierData(string filter = "")
        {
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM tbSupplier";
                // search by ContactName
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " WHERE ContactName LIKE @filter";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(filter))
                {
                    cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSupplier.DataSource = dt;
                // Hide SupplierName and Email columns
                if (dgvSupplier.Columns["SupplierName"] != null)
                    dgvSupplier.Columns["SupplierName"].Visible = false;

                if (dgvSupplier.Columns["Email"] != null)
                    dgvSupplier.Columns["Email"].Visible = false;
            }
        }

        private void btSave_Click(object? sender, EventArgs e)
        {
            try
            {
                // Create model from textboxes
                var supplier = new Supplier
                {
                    SupplierID = string.IsNullOrWhiteSpace(tbSupplierID.Text) ? 0 : Convert.ToInt32(tbSupplierID.Text),
                    SupplierName = tbSupplierName.Text.Trim(),
                    ContactName = tbContactName.Text.Trim(),
                    Phone = tbPhoneNumble.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    Address = tbAddress.Text.Trim()
                };
                // Validate supplier name
                if (string.IsNullOrWhiteSpace(supplier.SupplierName))
                {
                    MessageBox.Show("Supplier Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Save or update supplier
                _service.SaveSupplier(supplier);
                MessageBox.Show("Supplier saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tbSupplierID.Clear();
            tbSupplierName.Clear();
            tbContactName.Clear();
            tbPhoneNumble.Clear();
            tbEmail.Clear();
            tbAddress.Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbSupplierID.Clear();
            tbSeach.Clear();
            tbSupplierName.Clear();
            tbContactName.Clear();
            tbPhoneNumble.Clear();
            tbEmail.Clear();
            tbAddress.Clear();
        }
        private void LoadSuppliers()
        {
            dgvSupplier.DataSource = _service.GetAllSuppliers();
            if (dgvSupplier.Columns["SupplierName"] != null)
                dgvSupplier.Columns["SupplierName"].Visible = false;

            if (dgvSupplier.Columns["Email"] != null)
                dgvSupplier.Columns["Email"].Visible = false;
        }

        private void tbSeach_TextChanged_1(object sender, EventArgs e)
        {
            LoadSupplierData(tbSeach.Text.Trim());
        }

        private void dgvSupplier_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

                // Assign values from selected row to TextBoxes
                tbSupplierID.Text = row.Cells["SupplierID"].Value.ToString();
                tbSupplierName.Text = row.Cells["SupplierName"].Value.ToString();
                tbContactName.Text = row.Cells["ContactName"].Value.ToString();
                tbPhoneNumble.Text = row.Cells["Phone"].Value.ToString();
                tbEmail.Text = row.Cells["Email"].Value.ToString();
                tbAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
    }
}
