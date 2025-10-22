using AssigementOOADWinForms.DATAs;
using Microsoft.Data.SqlClient;
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
            //event
            btLogin.Click += (s, e) => HeaderLogin();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void HeaderLogin()
        {
            using (SqlConnection conn = HandleConnection.GetSqlConnection()) // Removed the stray semicolon here
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query = "SELECT COUNT(1) FROM tbUser WHERE Username=@Username AND PasswordHash=@PasswordHash";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", tbUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@PasswordHash", tbPassword.Text.Trim());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        // Login successful
                        this.Hide();
                        Mainform mainForm = new Mainform();
                        mainForm.Show();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbPassword.Clear();
                        tbUser.Focus();
                    }
                }
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbClearFields_Click(object sender, EventArgs e)
        {
            tbUser.Clear();
            tbPassword.Clear();
            tbUser.Focus();
        }

        private void btLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            HeaderLogin();
        }
    }
}
