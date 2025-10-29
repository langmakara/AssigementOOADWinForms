using System.Data;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
namespace AssigementOOADWinForms.Controls;
public partial class UserControlInvoice : UserControl
{
    private List<InvoiceDto> invoicesList = new();
    private readonly InvoiceService _invoiceService = new();
    private readonly EmployeeService _employeeService = new();
    private readonly UserControlInvoiceDetail _userControlInvoiceDetail;
    public UserControlInvoice()
    {
        InitializeComponent();

        DesignHelper.MakeAllInputs(this);
        DesignHelper.StyleDataGridView(dgvInvoice);
        dgvInvoice.CellPainting += DesignHelper.dataGridView1_CellPainting;
        btnClear.Click += HandleClearTextBox;
        dgvInvoice.SelectionChanged += (s, e) => SelectionRowChanges();
        dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        searchStartDate.Format = DateTimePickerFormat.Custom;
        searchStartDate.CustomFormat = "dd/MM/yyyy";
        searchStartDate.ValueChanged += (s, e) => FilterInvoices();
        searchStartDate.MouseUp += (s, e) => FilterInvoices();
        searchStartDate.KeyUp += (s, e) => { if (e.KeyCode == Keys.Space) FilterInvoices(); };
        searchEndDate.Format = DateTimePickerFormat.Custom;
        searchEndDate.CustomFormat = "dd/MM/yyyy";
        datetimeorderDate.Format = DateTimePickerFormat.Custom;
        datetimeorderDate.CustomFormat = "dd/MM/yyyy";
        searchEndDate.ValueChanged += (s, e) => FilterInvoices();
        searchEndDate.MouseUp += (s, e) => FilterInvoices();
        searchEndDate.KeyUp += (s, e) => { if (e.KeyCode == Keys.Space) FilterInvoices(); };
        searchCustomerName.TextChanged += (s, e) => FilterInvoices();
        btnSaveAndUpdateInvoice.Click += (s, e) => HandleSaveInvoice();
        btnremoveInvoice.Click += (s, e) => HandleRemoveInvoice();
        btnCreateInvoice.Click += (s, e) => HandleChangeUserControlInvoiceToCreateInvoiceDetail();
        this.Load += (s, e) =>
        {
            LoadEmployeesToCombo();
            LoadInvoices();
            if (dgvInvoice.Columns["OrderDate"] != null)
            {
                dgvInvoice.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yy";
            }
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

        DateTime? startDate = searchStartDate.Checked ? searchStartDate.Value.Date : (DateTime?)null;
        DateTime? endDate = searchEndDate.Checked ? searchEndDate.Value.Date.AddDays(1).AddTicks(-1) : (DateTime?)null;

        var filtered = invoicesList
            .Where(i =>
                (selectedEmployeeID == 0 || i.EmployeeID == selectedEmployeeID) &&
                (string.IsNullOrEmpty(customerKeyword) || i.CustomerName!.ToLower().Contains(customerKeyword)) &&
                (!startDate.HasValue || i.OrderDate >= startDate.Value) &&
                (!endDate.HasValue || i.OrderDate <= endDate.Value)
            )
            .ToList();

        dgvInvoice.DataSource = null;
        dgvInvoice.DataSource = filtered;
        if (dgvInvoice.Columns["OrderDate"] != null)
            dgvInvoice.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yy";
        if (dgvInvoice.Columns["TotalAmount"] != null)
            dgvInvoice.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";

        var hiddenColumns = new List<string> { "InvoiceID", "EmployeeID", "DisplayText" };
        DesignHelper.HideColumns(dgvInvoice, hiddenColumns);
    }
    private void HandleChangeUserControlInvoiceToCreateInvoiceDetail()
    {
        if (this.FindForm() is Mainform main)
        {
            main.HandleUserControlReplacseItselfMainForm(new UserControlInvoiceDetail(), "InvoiceDetail");
        }
    }
    // -------------------------
    // Selection & Form Controls
    // -------------------------
    private void SelectionRowChanges()
    {
        var map = new Dictionary<string, Control>
    {
        { "InvoiceID", textinvoiceID },
        { "CustomerName", textcustomerName },
        { "CustomerPhone", textcustomerPhone },
        { "CustomerAddress", textCustomerAddress },
        { "EmployeeID", comboEmployee },
        { "OrderDate", datetimeorderDate }
    };

        DesignHelper.PopulateRowControls(dgvInvoice, map);
    }
    private void HandleClearTextBox(object? sender, EventArgs? e)
    {
        textinvoiceID.Clear();
        textcustomerName.Clear();
        textcustomerPhone.Clear();
        textCustomerAddress.Clear();
        datetimeorderDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        comboEmployee.SelectedIndex = -1;
        textCustomerAddress.Clear();
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
            DateTime orderDate = datetimeorderDate.Value;
            var model = new Invoice
            {
                InvoiceID = string.IsNullOrWhiteSpace(textinvoiceID.Text) ? 0 : int.Parse(textinvoiceID.Text),
                CustomerName = textcustomerName.Text,
                CustomerPhone = textcustomerPhone.Text,
                CustomerAddress = textCustomerAddress.Text,
                EmployeeID = Convert.ToInt32(comboEmployee.SelectedValue),
                OrderDate = orderDate,
            };

            // Call service that executes sp_InsertOrUpdateInvoice
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
        int invoiceId;
        if (!string.IsNullOrWhiteSpace(textinvoiceID.Text) && int.TryParse(textinvoiceID.Text, out invoiceId))
        {
            // ok
        }
        else if (dgvInvoice.CurrentRow != null)
        {
            invoiceId = Convert.ToInt32(dgvInvoice.CurrentRow.Cells["InvoiceID"].Value);
        }
        else
        {
            MessageBox.Show("Please select an invoice to delete.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Confirm deletion
        if (MessageBox.Show("Are you sure you want to delete this invoice?", "Confirm Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;

        try
        {
            _invoiceService.RemoveInvoice(invoiceId);
            MessageBox.Show("Invoice deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reload invoices
            LoadInvoices();

            // Clear textboxes
            HandleClearTextBox(null, null);

            // Select a row automatically if any rows remain
            if (dgvInvoice.Rows.Count > 0)
            {
                dgvInvoice.ClearSelection();
                var firstRow = dgvInvoice.Rows[0];
                firstRow.Selected = true;

                // First visible cell
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
                {
                    dgvInvoice.CurrentCell = firstVisibleCell;
                }

                SelectionRowChanges();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to delete invoice:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }
}
