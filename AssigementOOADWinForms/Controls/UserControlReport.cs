using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using AssigementOOADWinForms.DATAs; // for HandleConnection

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlReport : UserControl
    {
        // track which view is currently loaded so filtering applies to it
        private string _currentView = "vw_ImportReport";

        public UserControlReport()
        {
            InitializeComponent();
            // UI design helpers
            DesignHelper.StyleDataGridView(DGVreport);

            //Event Handlers
            SeachCustomer.TextChanged += (s, e) => FilterTransactions();
            SeachSupplier.TextChanged += (s, e) => FilterTransactions();
            btnLoadImport.Click += HandleImport;
            btnLoadExport.Click += HandleExport;

            // ===== Event Bindings (Form Logic) =====
            dateSearchStart.ValueChanged += (s, e) => FilterTransactions();
            dateSearchEnd.ValueChanged += (s, e) => FilterTransactions();

            //=== Date Format ===
            dateSearchStart.Format = DateTimePickerFormat.Custom;
            dateSearchStart.CustomFormat = "dd/MM/yyyy";

            dateSearchEnd.Format = DateTimePickerFormat.Custom;
            dateSearchEnd.CustomFormat = "dd/MM/yyyy";

            // Load default view
            LoadData($"SELECT * FROM {_currentView}");
        }

        // Load Import Report
        private void HandleImport(object sender, EventArgs e)
        {
            _currentView = "vw_ImportReport";
            LoadData($"SELECT * FROM {_currentView}");
        }

        // Load Export Report
        private void HandleExport(object sender, EventArgs e)
        {
            _currentView = "vw_ExportReport";
            LoadData($"SELECT * FROM {_currentView}");
        }

        // =======================================
        // 🔹 FORM LOGIC: Filter Transactions
        // =======================================
        private void FilterTransactions()
        {
            try
            {
                string customerKeyboard = SeachCustomer.Text.Trim();
                string supplierKeyboard = SeachSupplier.Text.Trim();

                DateTime? startDate = dateSearchStart.Checked ? dateSearchStart.Value.Date : (DateTime?)null;
                DateTime? endDate = dateSearchEnd.Checked ? dateSearchEnd.Value.Date.AddDays(1).AddTicks(-1) : (DateTime?)null;

                // Build dynamic WHERE clauses and parameters
                var whereClauses = new List<string>();
                var parameters = new Dictionary<string, object?>();

                // Assumes views expose CustomerName and SupplierName columns — adjust if different
                if (!string.IsNullOrEmpty(customerKeyboard))
                {
                    whereClauses.Add("CustomerName LIKE @Customer");
                    parameters.Add("@Customer", $"%{customerKeyboard}%");
                }

                if (!string.IsNullOrEmpty(supplierKeyboard))
                {
                    whereClauses.Add("SupplierName LIKE @Supplier");
                    parameters.Add("@Supplier", $"%{supplierKeyboard}%");
                }

                if (startDate.HasValue && endDate.HasValue)
                {
                    // Use column ImportDate or ExportDate depending on view; fall back to 'TransactionDate'
                    string dateColumn = _currentView == "vw_ImportReport" ? "ImportDate" :
                                        _currentView == "vw_ExportReport" ? "ExportDate" : "TransactionDate";

                    whereClauses.Add($"{dateColumn} BETWEEN @FromDate AND @ToDate");
                    parameters.Add("@FromDate", startDate.Value);
                    parameters.Add("@ToDate", endDate.Value);
                }

                string baseQuery = $"SELECT * FROM {_currentView}";
                string finalQuery = whereClauses.Count > 0 ? $"{baseQuery} WHERE {string.Join(" AND ", whereClauses)}" : baseQuery;

                LoadData(finalQuery, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to filter transactions:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            // Prefer reusing FilterTransactions which already honors date pickers
            FilterTransactions();
        }

        // Generic data loader with parameter dictionary
        private void LoadData(string query, Dictionary<string, object?>? parameters = null)
        {
            var dt = new DataTable();

            try
            {
                using (SqlConnection con = HandleConnection.GetSqlConnection())
                {
                    if (con == null)
                        throw new Exception("Database connection failed.");

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            foreach (var kvp in parameters)
                            {
                                // use AddWithValue for simplicity; convert null -> DBNull
                                cmd.Parameters.AddWithValue(kvp.Key, kvp.Value ?? DBNull.Value);
                            }
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                DGVreport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load report data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
