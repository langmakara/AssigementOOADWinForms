using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;
using Microsoft.Data.SqlClient;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlInvoice : UserControl
    {
        private readonly int radius;
        private List<InvoiceDto> invoicesList = new();

        public UserControlInvoice()
        {
            InitializeComponent();

            DesignHelper.MakeAllInputsRounded(this, radius: 3);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvInvoice);

            btnClear.Click += HandleClearTextBox;
            dgvInvoice.SelectionChanged += SelectionRowChanges;
            dgvInvoice.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            searchCustomerName.TextChanged += (s, e) => FilterInvoices();
            this.Load += (s, e) => LoadInvoices();
        }

        private void LoadInvoices()
        {
            try
            {
                invoicesList = GetAllInvoicesFromDb();
                LoadEmployeeComboFromInvoices();
                FilterInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load invoices:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeeComboFromInvoices()
        {
            var employees = invoicesList
                .Select(i => new { i.EmployeeID, i.EmployeeName })
                .Distinct()
                .ToList();
            employees.Insert(0, new { EmployeeID = 0, EmployeeName = "All Employees" });

            searchEmployee.DataSource = employees;
            searchEmployee.DisplayMember = "EmployeeName";
            searchEmployee.ValueMember = "EmployeeID";
            searchEmployee.SelectedValue = 0;
            searchEmployee.SelectedIndexChanged += (s, e) => FilterInvoices();
        }

        private void FilterInvoices()
        {
            string customerKeyword = searchCustomerName.Text.Trim().ToLower();
            int selectedEmployeeID = Convert.ToInt32(searchEmployee.SelectedValue);

            var filtered = invoicesList
                .Where(i =>
                    (selectedEmployeeID == 0 || i.EmployeeID == selectedEmployeeID) &&
                    (string.IsNullOrEmpty(customerKeyword) || i.CustomerName!.ToLower().Contains(customerKeyword))
                )
                .ToList();

            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = filtered;

            var hiddenColumns = new List<string> { "InvoiceID", "EmployeeID" };
            DesignHelper.HideColumns(dgvInvoice, hiddenColumns);
        }

        private void SelectionRowChanges(object? sender, EventArgs? e)
        {
            if (dgvInvoice.CurrentRow == null || dgvInvoice.RowCount == 0)
                return;

            var row = dgvInvoice.CurrentRow;
            textinvoiceID.Text = row.Cells["InvoiceID"].Value?.ToString();
            textcustomerName.Text = row.Cells["CustomerName"].Value?.ToString();
            textcustomerPhone.Text = row.Cells["CustomerPhone"].Value?.ToString();
            textEmployeeID.Text = row.Cells["EmployeeID"].Value?.ToString();
            textTotalAmount.Text = Convert.ToDecimal(row.Cells["TotalAmount"].Value).ToString("C");

            if (DateTime.TryParse(row.Cells["OrderDate"].Value?.ToString(), out DateTime invoiceDate))
                datetimeorderDate.Text = DesignHelper.FormatDate(invoiceDate);
            else
                datetimeorderDate.Text = string.Empty;
        }

        private void HandleClearTextBox(object? sender, EventArgs? e)
        {
            textinvoiceID.Clear();
            textcustomerName.Clear();
            textcustomerPhone.Clear();
            datetimeorderDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            textEmployeeID.Clear();
            textTotalAmount.Clear();
        }

        private List<InvoiceDto> GetAllInvoicesFromDb()
        {
            var list = new List<InvoiceDto>();

            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Cannot open database connection.");

                string query = @"
            SELECT i.InvoiceID,
                   i.CustomerName,
                   i.CustomerPhone,
                   e.EmployeeID,
                   e.EmployeeName,
                   i.TotalAmount,
                   i.OrderDate
            FROM tbInvoices i
            JOIN tbEmployee e ON i.EmployeeID = e.EmployeeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new InvoiceDto
                            {
                                InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                                CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                                CustomerPhone = reader.GetString(reader.GetOrdinal("CustomerPhone")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount")),
                                OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"))
                            });
                        }
                    }
                }
            }

            return list;
        }


    }
}
