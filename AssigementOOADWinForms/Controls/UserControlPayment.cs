using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlPayment : UserControl
    {
        private readonly PaymentService _service = new();
        public UserControlPayment()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvPayment);
            dgvPayment.CellPainting += DesignHelper.dataGridView1_CellPainting!;
            LoadPayment();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tbPaymentID.Clear();
            tbInvoiceID.Clear();
            tbPaymentMethod.Clear();
            tbAmountPaid.Clear();
            // If you have a DateTimePicker for PaymentDate:
            dtpPaymentDate.Value = DateTime.Now;
            // Optional: reset focus to the first input
            tbInvoiceID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var payment = new Payment
                {
                    PaymentID = string.IsNullOrWhiteSpace(tbPaymentID.Text) ? 0 : Convert.ToInt32(tbPaymentID.Text),
                    InvoiceID = string.IsNullOrWhiteSpace(tbInvoiceID.Text) ? 0 : Convert.ToInt32(tbInvoiceID.Text),
                    PaymentDate = dtpPaymentDate.Value,
                    PaymentMethod = tbPaymentMethod.Text.Trim(),
                    AmountPaid = string.IsNullOrWhiteSpace(tbAmountPaid.Text) ? 0 : Convert.ToDecimal(tbAmountPaid.Text)
                };
                // ✅ Validate input
                if (payment.InvoiceID == 0)
                {
                    MessageBox.Show("Invoice ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(payment.PaymentMethod))
                {
                    MessageBox.Show("Payment Method is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ✅ Save data using service
                _service.SavePayment(payment);
                MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPayment();
                // ✅ Clear form after saving
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPayment()
        {
            dgvPayment.DataSource = _service.GetAllPayments();
        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPayment.Rows[e.RowIndex];
                tbPaymentID.Text = row.Cells["PaymentID"].Value?.ToString() ?? "";
                tbInvoiceID.Text = row.Cells["InvoiceID"].Value?.ToString() ?? "";
                tbPaymentMethod.Text = row.Cells["PaymentMethod"].Value?.ToString() ?? "";
                tbAmountPaid.Text = row.Cells["AmountPaid"].Value?.ToString() ?? "";
                if (row.Cells["PaymentDate"].Value != DBNull.Value)
                {
                    dtpPaymentDate.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value);
                }
                else
                {
                    dtpPaymentDate.Value = DateTime.Now;
                }
            }
        }

        private void UserControlPayment_Load(object sender, EventArgs e)
        {
            cbPaymentMethod.Items.Clear();
            cbPaymentMethod.Items.AddRange(new string[]
            {
                "All",
                "Cash",
                "Credit Card",
                "Bank Transfer"
            });

            cbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentMethod.SelectedIndex = 0; // default = All

            cbPaymentMethod.SelectedIndexChanged += cbPaymentMethod_SelectedIndexChanged;
        }

        private void cbPaymentMethod_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string selected = cbPaymentMethod.SelectedItem?.ToString()!;

            // Get full data again
            DataTable allPayments = _service.GetAllPayments();

            if (selected != "All" && !string.IsNullOrEmpty(selected))
            {
                // Create a filtered view
                DataView dv = new DataView(allPayments);
                dv.RowFilter = $"PaymentMethod = '{selected}'";
                dgvPayment.DataSource = dv;
            }
            else
            {
                // Show all
                dgvPayment.DataSource = allPayments;
            }
        }
    }
}
