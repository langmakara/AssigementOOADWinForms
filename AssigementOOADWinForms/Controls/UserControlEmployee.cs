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
    public partial class UserControlEmployee : UserControl
    {
        private List<EmployeeDto> employeesList = new();
        private readonly EmployeeService _employeeService = new();

        public UserControlEmployee()
        {
            InitializeComponent();

            // UI design helpers
            DesignHelper.MakeAllInputs(this);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvemployee);

            // DataGridView config
            dgvemployee.SelectionChanged += SelectionRowChanges;
            dgvemployee.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvemployee.AutoGenerateColumns = true;

            // Events
            btClear.Click += HandleClearTextBox;
            btSave.Click += HandleSaveEmployee;
            btRemove.Click += HandleRemoveEmployee;
            tbsearchEmployeeName.TextChanged += (s, e) => FilterEmployees();
            cbPositionFilter.SelectedIndexChanged += CbPositionFilter_SelectedIndexChanged;
            this.Load += (s, e) =>
            {
                LoadEmployees();
                LoadPositions();
            };

            // Initialize Role ComboBox
            cbPositionFilter.Items.Clear();
            cbPositionFilter.Items.Add("All");
            cbPositionFilter.SelectedIndex = 0; // Default to "All"
            cbPositionFilter.SelectedIndexChanged += (s, e) => FilterEmployees();
        }

        // ===============================
        // Load Employees from database
        // ===============================
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

                dgvemployee.DataSource = null;
                dgvemployee.DataSource = employeesList;
                UpdateEmployeeCount(); //Show total count
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load employees:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Load Positions into ComboBox
        // ===============================
        private void LoadPositions(bool fromDatabase = false)
        {
            try
            {
                var allEmployees = fromDatabase
                    ? _employeeService.GetAllEmployees().Select(e => new EmployeeDto
                    {
                        EmployeeID = e.EmployeeID,
                        EmployeeName = e.EmployeeName,
                        Phone = e.Phone,
                        Email = e.Email,
                        Address = e.Address,
                        Position = e.Position,
                        HireDate = e.HireDate
                    }).ToList()
                    : employeesList;

                var positions = allEmployees
                    .Select(e => e.Position ?? string.Empty)
                    .Where(pos => !string.IsNullOrWhiteSpace(pos))
                    .Distinct()
                    .OrderBy(pos => pos)
                    .ToList();

                positions.Insert(0, "All");

                cbPositionFilter.DataSource = null;
                cbPositionFilter.DataSource = positions;

                cbPositionFilter.SelectedIndexChanged -= CbPositionFilter_SelectedIndexChanged;
                cbPositionFilter.SelectedIndexChanged += CbPositionFilter_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load positions:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Filter Employees by Name & Position
        // ===============================
        private void FilterEmployees()
        {
            try
            {
                if (employeesList == null || employeesList.Count == 0)
                    return;

                var filtered = employeesList.AsEnumerable();

                // Filter by name
                var searchName = tbsearchEmployeeName.Text?.Trim();
                if (!string.IsNullOrEmpty(searchName))
                {
                    filtered = filtered.Where(e => e.EmployeeName != null &&
                                                   e.EmployeeName.Contains(searchName, StringComparison.OrdinalIgnoreCase));
                }

                // Filter by position
                if (cbPositionFilter.SelectedItem is string selectedPosition && selectedPosition != "All")
                {
                    filtered = filtered.Where(e => e.Position == selectedPosition);
                }

                dgvemployee.DataSource = null;
                dgvemployee.DataSource = filtered.ToList();

                UpdateEmployeeCount(); //Update count after filtering
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while filtering employees:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Function to Show Total Employees
        // ===============================
        private void UpdateEmployeeCount()
        {
            try
            {
                if (lbTotalEmployee != null)
                {
                    int total = dgvemployee.Rows.Count;
                    lbTotalEmployee.Text = $"{total}";
                }
            }
            catch
            {
                // Ignore errors (e.g., if label not present)
            }
        }

        // ===============================
        // ComboBox Position Change Event
        // ===============================
        private void CbPositionFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterEmployees();
        }

        // ===============================
        // Handle Row Selection
        // ===============================
        private void SelectionRowChanges(object? sender, EventArgs e)
        {
            if (dgvemployee.SelectedRows.Count > 0)
            {
                var selectedRow = dgvemployee.SelectedRows[0];
                var employee = selectedRow.DataBoundItem as EmployeeDto;
                if (employee != null)
                {
                    tbEmployeeID.Text = employee.EmployeeID.ToString();
                    tbName.Text = employee.EmployeeName;
                    tbPhone.Text = employee.Phone;
                    tbEmail.Text = employee.Email;
                    tbAddress.Text = employee.Address;
                    tbPosition.Text = employee.Position;
                    dtpHireDate.Value = employee.HireDate;
                }
            }
        }

        // ===============================
        // Clear all input fields
        // ===============================
        private void HandleClearTextBox(object? sender, EventArgs e)
        {
            tbEmployeeID.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbPosition.Text = "";
            dtpHireDate.Value = DateTime.Now;

            dgvemployee.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees(); //Refresh employee list and count
        }

        // ===============================
        // Save or Update Employee
        // ===============================
        private void HandleSaveEmployee(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbPosition.Text))
                {
                    MessageBox.Show("Please write a valid position.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int employeeId = 0;

                if (dgvemployee.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvemployee.SelectedRows[0];
                    if (selectedRow.DataBoundItem is EmployeeDto dto)
                        employeeId = dto.EmployeeID;
                }

                var model = new Employee
                {
                    EmployeeID = string.IsNullOrWhiteSpace(tbEmployeeID.Text) ? 0 : int.Parse(tbEmployeeID.Text),
                    EmployeeName = tbName.Text,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text,
                    Address = tbAddress.Text,
                    Position = tbPosition.Text,
                    HireDate = dtpHireDate.Value
                };
                _employeeService.SaveEmployee(model);
                LoadEmployees();
                UpdateEmployeeCount(); //Update count
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save employee:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        // Remove Employee
        // ===============================
        private void HandleRemoveEmployee(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbEmployeeID.Text) || !int.TryParse(tbEmployeeID.Text, out int employeeId))
                {
                    MessageBox.Show("Please select an employee to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgvemployee.SelectedRows[0];
                var employee = selectedRow.DataBoundItem as EmployeeDto;
                if (employee == null)
                {
                    MessageBox.Show("Selected employee is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var confirmResult = MessageBox.Show($"Are you sure to delete employee '{employee.EmployeeName}'?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _employeeService.RemoveEmployee(employee.EmployeeID);
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                    LoadPositions(fromDatabase: true);
                    UpdateEmployeeCount(); //Update after deletion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove employee:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
