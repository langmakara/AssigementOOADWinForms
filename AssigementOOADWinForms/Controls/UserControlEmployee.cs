using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlEmployee : UserControl
    {
        public UserControlEmployee()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvemployee);
            DesignHelper.ApplyRoundedStyle(panel3, 5);
        }
    }
}
