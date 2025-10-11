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
    public partial class UserControlInventory : UserControl
    {
        public UserControlInventory()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvinventory);
            DesignHelper.ApplyRoundedStyle(panel1, 5);
            DesignHelper.ApplyRoundedStyle(panel2, 5);
            DesignHelper.ApplyRoundedStyle(panel3, 5);
            DesignHelper.StyleDataGridView(dgvinventory);
            dgvinventory.CellPainting += DesignHelper.dataGridView1_CellPainting;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlInventory_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
