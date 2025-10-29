using AssigementOOADWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlStockAdjustment : UserControl
    {
        private readonly StockAdjustmentService _service = new();
        public UserControlStockAdjustment()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvStockAdjustments);
            dgvStockAdjustments.CellPainting += DesignHelper.dataGridView1_CellPainting!;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Get values from input controls (replace with your actual control names)
                int productId = int.Parse(tbProductID.Text.Trim());
                int employeeId = int.Parse(tbEmployeeID.Text.Trim());
                string adjustmentType = cbAdjustmentType.Text.Trim();
                int quantity = int.Parse(tbQuantity.Text.Trim());
                string reason = tbReason.Text.Trim();
                DateTime adjustmentDate = tbAdjustmentDate.Value;

                //Call service to record adjustment
                _service.RecordAdjustment(productId, employeeId, quantity, adjustmentType, reason);

                MessageBox.Show("Stock adjustment saved successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGrid();
                ClearForm();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for ProductID, EmployeeID, and Quantity.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving stock adjustment: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbAdjustmentID.Text))
                {
                    MessageBox.Show("Please enter or select an AdjustmentID to delete.",
                        "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int adjustmentId = int.Parse(tbAdjustmentID.Text);

                var confirm = MessageBox.Show("Are you sure you want to delete this adjustment?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    _service.DeleteAdjustment(adjustmentId);
                    MessageBox.Show("Stock adjustment deleted successfully.", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting stock adjustment: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Helper to load DataGridView
        private void LoadDataGrid()
        {
            try
            {
                dgvStockAdjustments.DataSource = _service.GetAllAdjustments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock adjustments: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Helper to clear form fields
        private void ClearForm()
        {
            tbAdjustmentID.Clear();
            tbProductID.Clear();
            tbEmployeeID.Clear();
            tbQuantity.Clear();
            tbReason.Clear();
            cbAdjustmentType.SelectedIndex = 0;
            tbAdjustmentDate.Value = DateTime.Now;
        }

        private void UserControlStockAdjustment_Load(object sender, EventArgs e)
        {
            //Load data into DataGridView when the form loads
            LoadDataGrid();
            //Add predefined Adjustment Types
            cbAdjustmentType.Items.Clear();
            cbAdjustmentType.Items.Add("Increase");
            cbAdjustmentType.Items.Add("Decrease");
            cbAdjustmentType.SelectedIndex = 0; // default selection
        }

        private void lbReason_Click(object sender, EventArgs e)
        {

        }
    }
}
