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
            DesignHelper.MakeAllInputsRounded(this, radius: 3);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvemployee);

            // DataGridView config
            dgvemployee.SelectionChanged += SelectionRowChanges;
            dgvemployee.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvemployee.AutoGenerateColumns = true;

            // Events
            tbsearchEmployeeName.TextChanged += (s, e) => FilterEmployees();
            cbPositionFilter.SelectedIndexChanged += CbPositionFilter_SelectedIndexChanged;
            this.Load += (s, e) =>
            {
                LoadEmployees();
                LoadPositions();
            };
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
                // Ensure consistent type for allEmployees
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

                // Extract distinct positions
                var positions = allEmployees
                    .Select(e => e.Position ?? string.Empty)
                    .Where(pos => !string.IsNullOrWhiteSpace(pos))
                    .Distinct()
                    .OrderBy(pos => pos)
                    .ToList();

                // Add "All" option at the top
                positions.Insert(0, "All");

                // Bind to ComboBox
                cbPositionFilter.DataSource = null;
                cbPositionFilter.DataSource = positions;

                // Re-attach event (prevent duplicates)
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

                // Update DataGridView
                dgvemployee.DataSource = null;
                dgvemployee.DataSource = filtered.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while filtering employees:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    tbName.Text = employee.EmployeeName;
                    tbPhone.Text = employee.Phone;
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
            tbName.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
            tbPosition.Clear();
            dtpHireDate.Value = DateTime.Now;
        }
    }
}
