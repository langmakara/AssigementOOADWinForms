namespace AssigementOOADWinForms.Controls
{
    partial class UserControlUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvuser = new DataGridView();
            label2 = new Label();
            lbSeach = new Label();
            tbSeach = new TextBox();
            cbRole1 = new ComboBox();
            pbProfile = new PictureBox();
            lbUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            lbID = new Label();
            tbID = new TextBox();
            lbRole = new Label();
            cbRole2 = new ComboBox();
            panel1 = new Panel();
            cbActive = new CheckBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvuser
            // 
            dgvuser.BackgroundColor = Color.White;
            dgvuser.BorderStyle = BorderStyle.Fixed3D;
            dgvuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvuser.Location = new Point(3, 115);
            dgvuser.Margin = new Padding(3, 4, 3, 4);
            dgvuser.Name = "dgvuser";
            dgvuser.RowHeadersWidth = 51;
            dgvuser.Size = new Size(865, 766);
            dgvuser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(297, 5);
            label2.Name = "label2";
            label2.Size = new Size(65, 35);
            label2.TabIndex = 37;
            label2.Text = "Role";
            // 
            // lbSeach
            // 
            lbSeach.AutoSize = true;
            lbSeach.Cursor = Cursors.Hand;
            lbSeach.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSeach.ForeColor = Color.White;
            lbSeach.Location = new Point(10, 4);
            lbSeach.Name = "lbSeach";
            lbSeach.Size = new Size(82, 35);
            lbSeach.TabIndex = 35;
            lbSeach.Text = "Seach";
            // 
            // tbSeach
            // 
            tbSeach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSeach.Location = new Point(10, 45);
            tbSeach.Margin = new Padding(3, 4, 3, 4);
            tbSeach.Multiline = true;
            tbSeach.Name = "tbSeach";
            tbSeach.Size = new Size(270, 37);
            tbSeach.TabIndex = 34;
            // 
            // cbRole1
            // 
            cbRole1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbRole1.FormattingEnabled = true;
            cbRole1.Location = new Point(292, 46);
            cbRole1.Margin = new Padding(3, 4, 3, 4);
            cbRole1.Name = "cbRole1";
            cbRole1.Size = new Size(285, 36);
            cbRole1.TabIndex = 33;
            // 
            // pbProfile
            // 
            pbProfile.BackgroundImage = Properties.Resources.user;
            pbProfile.BackgroundImageLayout = ImageLayout.Zoom;
            pbProfile.Location = new Point(59, 23);
            pbProfile.Margin = new Padding(3, 4, 3, 4);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(288, 288);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 38;
            pbProfile.TabStop = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Cursor = Cursors.Hand;
            lbUsername.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(22, 426);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(129, 35);
            lbUsername.TabIndex = 40;
            lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbUsername.Location = new Point(30, 465);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(347, 48);
            tbUsername.TabIndex = 41;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPassword.Location = new Point(30, 566);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(347, 48);
            tbPassword.TabIndex = 42;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Cursor = Cursors.Hand;
            lbPassword.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.White;
            lbPassword.Location = new Point(22, 527);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(122, 35);
            lbPassword.TabIndex = 43;
            lbPassword.Text = "Password";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Cursor = Cursors.Hand;
            lbID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.ForeColor = Color.White;
            lbID.Location = new Point(22, 320);
            lbID.Name = "lbID";
            lbID.Size = new Size(40, 35);
            lbID.TabIndex = 44;
            lbID.Text = "ID";
            // 
            // tbID
            // 
            tbID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbID.Location = new Point(30, 359);
            tbID.Margin = new Padding(3, 4, 3, 4);
            tbID.Multiline = true;
            tbID.Name = "tbID";
            tbID.Size = new Size(347, 48);
            tbID.TabIndex = 39;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Cursor = Cursors.Hand;
            lbRole.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(22, 628);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(65, 35);
            lbRole.TabIndex = 47;
            lbRole.Text = "Role";
            // 
            // cbRole2
            // 
            cbRole2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbRole2.FormattingEnabled = true;
            cbRole2.Location = new Point(30, 667);
            cbRole2.Margin = new Padding(3, 4, 3, 4);
            cbRole2.Name = "cbRole2";
            cbRole2.Size = new Size(347, 36);
            cbRole2.TabIndex = 48;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(cbActive);
            panel1.Controls.Add(cbRole2);
            panel1.Controls.Add(lbRole);
            panel1.Controls.Add(lbID);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tbID);
            panel1.Controls.Add(pbProfile);
            panel1.Location = new Point(867, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 894);
            panel1.TabIndex = 50;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbActive.ForeColor = Color.White;
            cbActive.Location = new Point(259, 320);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(88, 29);
            cbActive.TabIndex = 50;
            cbActive.Text = "Active";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbSeach);
            panel2.Controls.Add(tbSeach);
            panel2.Controls.Add(cbRole1);
            panel2.Location = new Point(-2, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 114);
            panel2.TabIndex = 51;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(201, 726);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(189, 60);
            button3.TabIndex = 131;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(7, 784);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(383, 60);
            button2.TabIndex = 130;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(7, 726);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(207, 60);
            btSave.TabIndex = 129;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // UserControlUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvuser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlUser";
            Size = new Size(1264, 885);
            ((System.ComponentModel.ISupportInitialize)dgvuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvuser;
        private Label label2;
        private Label lbSeach;
        private TextBox tbSeach;
        private ComboBox cbRole1;
        private PictureBox pbProfile;
        private Label lbUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
        private Label lbID;
        private TextBox tbID;
        private Label lbRole;
        private ComboBox cbRole2;
        private Panel panel1;
        private CheckBox cbActive;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button btSave;
    }
}
