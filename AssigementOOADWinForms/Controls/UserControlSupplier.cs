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
    public partial class UserControlSupplier : UserControl
    {
        public UserControlSupplier()
        {
            InitializeComponent();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbSupplierID.Clear();
            tbSeach.Clear();
            tbSupplierName.Clear();
            tbContactName.Clear();
            tbPhoneNumble.Clear();
            tbEmail.Clear();
            tbAddress.Clear();
        }

        private void UserControlSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
