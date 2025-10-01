using System;
using System.Windows.Forms;
using AssigementOOADWinForms.Data; // for ApplicationDbContext

namespace AssigementOOADWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Make sure Load event is hooked
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    if (db.Database.CanConnect())
                    {
                        MessageBox.Show("✅ Database connection OK!", "Connection Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("❌ Cannot connect to the database.", "Connection Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Connection Test",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
