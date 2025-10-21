using System;
using System.Drawing;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlProduct : UserControl
    {
        public UserControlProduct()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tbProductID.Clear();
            tbSeach.Clear();
            tbProductName.Clear();
            tbCategory.Clear();
            tbSupplier.Clear();
            tbUnitPrice.Clear();
            tbQauntity.Clear();
        }
        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}
