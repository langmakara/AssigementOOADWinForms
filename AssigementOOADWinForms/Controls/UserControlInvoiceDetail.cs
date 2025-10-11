using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlInvoiceDetail : UserControl
    {
        public UserControlInvoiceDetail()
        {
            InitializeComponent();
            DesignHelper.MakeAllInputsRounded(this, radius: 6);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel3, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvInvoicedetail);
            dgvInvoicedetail.CellPainting += DesignHelper.dataGridView1_CellPainting;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
