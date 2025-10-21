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
            DesignHelper.MakeAllInputsGlass(this);
            dgvinventory.CellPainting += DesignHelper.dataGridView1_CellPainting;

        }
    }
}
