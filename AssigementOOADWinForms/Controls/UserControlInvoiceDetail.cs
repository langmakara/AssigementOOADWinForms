using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssigementOOADWinForms.DTOs.AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlInvoiceDetail : UserControl
    {
        private readonly InvoiceDetailService service = new();
        private List<InvoiceDetailDto> invoiceDetailDtos;
        public UserControlInvoiceDetail()
        {
            InitializeComponent();
            DesignHelper.MakeAllInputsRounded(this, radius: 3);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvInvoicedetail);
            dgvInvoicedetail.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvInvoicedetail.SelectionChanged += (s, e) => SelectionRowChanges();
            btnBack.Click += (s, e) => HandleGetBackToInvoice();
            btnSave.Click += (s, e) => SaveInvoiceDetail();
            this.Load += (s, e) => LaodInvoiceDetail();
        }
        //HandleForm Logic
        private void HandleGetBackToInvoice()
        {
            if (this.FindForm() is Mainform main)
            {
                main.HandleUserControlReplacseItselfMainForm(new UserControlInvoice(), "Invoice");
            }
        }
        private void SelectionRowChanges()
        {
            var map = new Dictionary<string, Control>
    {
        { "InvoiceDetailID", textInvoiceDetailID },
        { "InvoiceID", textInvoiceID },
         { "Qauntity", textQauntity },
        { "UnitPrice", textPrice },
       
    };

            DesignHelper.PopulateRowControls(dgvInvoicedetail, map);
        }
        //Handle Database Server side
        private void LaodInvoiceDetail()
        {
            try
            {
                invoiceDetailDtos = service.GetAllInvoiceDetails();
                dgvInvoicedetail.DataSource = null;
                dgvInvoicedetail.DataSource = invoiceDetailDtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load invoice detail:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveInvoiceDetail()
        {
            try
            {
                if (!int.TryParse(textQauntity.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity value");
                    return;
                }
                var model = new InvoiceDetail
                {
                    InvoiceDetailID = string.IsNullOrWhiteSpace(textInvoiceDetailID.Text) ? 0 : int.Parse(textInvoiceDetailID.Text),
                    InvoiceID = int.Parse(textInvoiceDetailID.Text),
                    ProductID = int.Parse(textInvoiceDetailID.Text),
                    Quantity = quantity,
                    UnitPrice = decimal.Parse(textPrice.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save invoice detail:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
