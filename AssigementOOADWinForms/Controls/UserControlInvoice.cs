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
    public partial class UserControlInvoice : UserControl
    {
        private readonly int radius;

        public UserControlInvoice()
        {
            InitializeComponent();
            DesignHelper.MakeAllInputsRounded(this, radius: 6);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel3, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvInvoice);
            dgvInvoice.CellPainting += DesignHelper.dataGridView1_CellPainting;
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
