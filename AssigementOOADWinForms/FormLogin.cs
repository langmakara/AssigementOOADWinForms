using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigementOOADWinForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // Fixing the syntax errors in the if statement
            if (tbUser.Text == "MakaraLang" && tbPassword.Text == "1234567")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUser.Clear();
                tbPassword.Clear();
                tbUser.Focus();
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbClearFields_Click(object sender, EventArgs e)
        {
            tbUser.Clear();
            tbPassword.Clear();
            tbUser.Focus();

        }

        private void NovaCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
