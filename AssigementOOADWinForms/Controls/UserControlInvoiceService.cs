using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Repositories;
using AssigementOOADWinForms.Services;
using Microsoft.Data.SqlClient;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlInvoiceService : UserControl
    {
        private readonly InvoiceService _invoiceService = new();
        public UserControlInvoiceService()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dvgInvoiceService);
            dvgInvoiceService.CellPainting += DesignHelper.dataGridView1_CellPainting;

            DataGridViewCheckBoxColumn deliveredCol = new DataGridViewCheckBoxColumn();
            deliveredCol.Name = "Delivered";
            deliveredCol.HeaderText = "Delivered";
            deliveredCol.Width = 70;
            dvgInvoiceService.Columns.Add(deliveredCol);

            dvgInvoiceService.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dvgInvoiceService.IsCurrentCellDirty)
                    dvgInvoiceService.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            dvgInvoiceService.CellValueChanged += (s, e) =>
            {
                if (e.ColumnIndex == dvgInvoiceService.Columns["Delivered"].Index)
                {
                    btnAccept.Enabled = dvgInvoiceService.Rows.Cast<DataGridViewRow>()
                                        .Any(r => r.Cells["Delivered"].Value != null && (bool)r.Cells["Delivered"].Value);
                }
            };
            btnAccept.Click += (s, e) => HandleAccept();
            lbCancel.Click += (s, e) => HandleCancel();

            this.Load += (s, e) => LoadPendingInvoices();
        }
        private void LoadPendingInvoices()
        {
            var invoices = _invoiceService.GetPendingInvoices();
            dvgInvoiceService.DataSource = invoices;
            if (dvgInvoiceService.Columns.Contains("Delivered"))
            {
                dvgInvoiceService.Columns["Delivered"].DisplayIndex = dvgInvoiceService.Columns.Count - 1;
            }
        }
        public void MarkAsDelivered(int invoiceId)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_MarkInvoiceDelivered", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@InvoiceID", invoiceId);
            cmd.ExecuteNonQuery();
        }
        private void HandleAccept()
        {
            foreach (DataGridViewRow row in dvgInvoiceService.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Delivered"].Value);
                if (!isChecked) continue;

                int invoiceId = Convert.ToInt32(row.Cells["InvoiceID"].Value);
                _invoiceService.MarkAsDelivered(invoiceId);
            }
            MessageBox.Show("Selected invoices marked as Delivered.");
            LoadPendingInvoices();
        }
        private void HandleCancel()
        {
            foreach (DataGridViewRow row in dvgInvoiceService.Rows)
            {
                if (dvgInvoiceService.Columns.Contains("Delivered"))
                {
                    row.Cells["Delivered"].Value = false;
                }
            }
            LoadPendingInvoices();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
