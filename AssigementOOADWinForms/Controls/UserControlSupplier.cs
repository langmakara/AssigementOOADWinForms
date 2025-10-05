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
            DesignHelper.StyleDataGridView(dgvsuppiler);
        }
    }
}
