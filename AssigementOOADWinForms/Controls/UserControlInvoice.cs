using System.Data;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlInvoice : UserControl
    {
        private List<InvoiceDto> invoicesList = new();
        private readonly InvoiceService _invoiceService = new();
        private readonly EmployeeService _employeeService = new();

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
            btnSaveAndUpdateInvoice.Click += (s, e) => HandleSaveInvoice();
            btnremoveInvoice.Click += (s, e) => HandleRemoveInvoice();

            this.Load += (s, e) =>
            {
                LoadEmployeesToCombo();
                LoadInvoices();
            };
        }

        // -------------------------
        // Load & Filter
        // -------------------------
        private void LoadInvoices()
        {
            try
            {
                invoicesList = _invoiceService.GetAllInvoices();
                LoadEmployeeComboFromInvoices();
                FilterInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load invoices:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeesToCombo()
        {
            try
            {
                var employees = _employeeService.GetAllEmployees();
                comboEmployee.DataSource = employees;
                comboEmployee.DisplayMember = "EmployeeName";
                comboEmployee.ValueMember = "EmployeeID";
                comboEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load employees: {ex.Message}", "Error",
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

        // -------------------------
        // Selection & Form Controls
        // -------------------------
        private void SelectionRowChanges(object? sender, EventArgs? e)
        {
            if (dgvInvoice.CurrentRow == null || dgvInvoice.RowCount == 0)
                return;

            var row = dgvInvoice.CurrentRow;
            textinvoiceID.Text = row.Cells["InvoiceID"].Value?.ToString();
            textcustomerName.Text = row.Cells["CustomerName"].Value?.ToString();
            textcustomerPhone.Text = row.Cells["CustomerPhone"].Value?.ToString();

            int empId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
            comboEmployee.SelectedValue = empId;

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
            comboEmployee.SelectedIndex = -1;
            textTotalAmount.Clear();
        }

        // -------------------------
        // CRUD Logic
        // -------------------------
        private void HandleSaveInvoice()
        {
            try
            {
                if (comboEmployee.SelectedValue == null)
                {
                    MessageBox.Show("Please select an employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var model = new Invoice
                {
                    InvoiceID = string.IsNullOrWhiteSpace(textinvoiceID.Text) ? 0 : int.Parse(textinvoiceID.Text),
                    CustomerName = textcustomerName.Text,
                    CustomerPhone = textcustomerPhone.Text,
                    EmployeeID = Convert.ToInt32(comboEmployee.SelectedValue),
                    OrderDate = DateTime.Parse(datetimeorderDate.Text),
                    TotalAmount = decimal.Parse(textTotalAmount.Text)
                };

                _invoiceService.SaveInvoice(model);
                MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save invoice:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleRemoveInvoice()
        {
            if (string.IsNullOrWhiteSpace(textinvoiceID.Text))
            {
                MessageBox.Show("Please select an invoice to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int invoiceId = Convert.ToInt32(textinvoiceID.Text);

            if (MessageBox.Show("Are you sure you want to delete this invoice?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                _invoiceService.RemoveInvoice(invoiceId);
                MessageBox.Show("Invoice deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInvoices();
                HandleClearTextBox(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete invoice:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
