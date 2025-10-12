using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Services;
using AssigementOOADWinForms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlEmployee : UserControl
    {
        private List<EmployeeDto> employeesList = new();
        private readonly EmployeeService _employeeService = new();

        public UserControlEmployee()
        {
            InitializeComponent();
            DesignHelper.MakeAllInputsRounded(this, radius: 3);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvemployee);
            dgvemployee.SelectionChanged += SelectionRowChanges;
            dgvemployee.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchEmployeeName.TextChanged += (s, e) => FilterEmployees();
            this.Load += (s, e) => LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = _employeeService.GetAllEmployees();
                employeesList = employees.Select(e => new EmployeeDto
                {
                    EmployeeID = e.EmployeeID,
                    EmployeeName = e.EmployeeName,
                    Phone = e.Phone,
                    Email = e.Email,
                    Address = e.Address,
                    Position = e.Position,
                    HireDate = e.HireDate
                }).ToList();

                dgvemployee.DataSource = employeesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load employees:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FilterEmployees()
        {
            var filtered = employeesList.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(searchEmployeeName.Text))
            {
                filtered = filtered.Where(e => e.EmployeeName.Contains(searchEmployeeName.Text, StringComparison.OrdinalIgnoreCase));
            }
            dgvemployee.DataSource = null;
            dgvemployee.DataSource = filtered.ToList();
        }
        private void SelectionRowChanges(object? sender, EventArgs e)
        {
            if (dgvemployee.SelectedRows.Count > 0)
            {
                var selectedRow = dgvemployee.SelectedRows[0];
                var employee = selectedRow.DataBoundItem as EmployeeDto;
                if (employee != null)
                {
                    tbName.Text = employee.EmployeeName;
                    tbPhone.Text = employee.Phone;
                    tbAddress.Text = employee.Address;
                    tbPosition.Text = employee.Position;
                    dtpHireDate.Value = employee.HireDate;
                }
            }
        }
    }
}
