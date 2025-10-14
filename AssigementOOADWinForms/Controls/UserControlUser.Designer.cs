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
            tbSeachName = new TextBox();
            cbRole = new ComboBox();
            pbProfile = new PictureBox();
            lbUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            lbID = new Label();
            tbID = new TextBox();
            lbRole = new Label();
            panel1 = new Panel();
            btClear = new Button();
            btRemove = new Button();
            btSave = new Button();
            panel2 = new Panel();
            cbRole1 = new ComboBox();
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
            // tbSeachName
            // 
            tbSeachName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSeachName.Location = new Point(10, 45);
            tbSeachName.Margin = new Padding(3, 4, 3, 4);
            tbSeachName.Multiline = true;
            tbSeachName.Name = "tbSeachName";
            tbSeachName.Size = new Size(270, 37);
            tbSeachName.TabIndex = 34;
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(292, 46);
            cbRole.Margin = new Padding(3, 4, 3, 4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(285, 36);
            cbRole.TabIndex = 33;
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
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cbRole1);
            panel1.Controls.Add(btClear);
            panel1.Controls.Add(btRemove);
            panel1.Controls.Add(btSave);
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
            // btClear
            // 
            btClear.BackColor = Color.White;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClear.ForeColor = Color.DodgerBlue;
            btClear.Location = new Point(205, 726);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(189, 60);
            btClear.TabIndex = 131;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.FromArgb(255, 128, 0);
            btRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btRemove.FlatAppearance.BorderSize = 0;
            btRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(-2, 786);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(397, 60);
            btRemove.TabIndex = 130;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(0, 726);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(205, 60);
            btSave.TabIndex = 129;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbSeach);
            panel2.Controls.Add(tbSeachName);
            panel2.Controls.Add(cbRole);
            panel2.Location = new Point(2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 109);
            panel2.TabIndex = 51;
            // 
            // cbRole1
            // 
            cbRole1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbRole1.FormattingEnabled = true;
            cbRole1.Location = new Point(30, 667);
            cbRole1.Margin = new Padding(3, 4, 3, 4);
            cbRole1.Name = "cbRole1";
            cbRole1.Size = new Size(347, 36);
            cbRole1.TabIndex = 132;
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
        private TextBox tbSeachName;
        private ComboBox cbRole;
        private PictureBox pbProfile;
        private Label lbUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
        private Label lbID;
        private TextBox tbID;
        private Label lbRole;
        private Panel panel1;
        private Panel panel2;
        private Button btClear;
        private Button btRemove;
        private Button btSave;
        private ComboBox cbRole1;
    }
}
