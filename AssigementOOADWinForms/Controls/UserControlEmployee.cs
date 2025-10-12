using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlEmployee : UserControl
    {
        private readonly EmployeeService _employeeService = new EmployeeService();
        private Label lblTotalEmployees; // Changed from object to Label

        public UserControlEmployee()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvemployee);
            DesignHelper.ApplyRoundedStyle(panel3, 5);
            lblTotalEmployees = new Label(); // Initialize lblTotalEmployees
            LoadEmployees(); // Load data on startup
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = _employeeService.GetAllEmployees();

                dgvemployee.DataSource = employees;

                // Optional: Auto resize columns
                dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Update total employees count
                lblTotalEmployees.Text = employees.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }

        private void dgvemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method is intentionally left empty or can be implemented as needed.
        }

        private void dgvemployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvemployee.Rows[e.RowIndex];
                tbName.Text = row.Cells["EmployeeName"].Value.ToString();
                tbPhone.Text = row.Cells["Phone"].Value?.ToString();
                tbAddress.Text = row.Cells["Address"].Value?.ToString();
                tbPosition.Text = row.Cells["Position"].Value?.ToString();
                tbHireDate.Text = row.Cells["HireDate"].Value?.ToString();
            }
        }
    }
}
