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
            lbUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            lbID = new Label();
            tbID = new TextBox();
            lbRole = new Label();
            panel1 = new Panel();
            cbRole1 = new ComboBox();
            panel2 = new Panel();
            btClear = new Button();
            btRemove = new Button();
            btSave = new Button();
            panel3 = new Panel();
            lbUserTotal = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvuser).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
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
            dgvuser.Size = new Size(885, 766);
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
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Cursor = Cursors.Hand;
            lbUsername.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(29, 114);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(129, 35);
            lbUsername.TabIndex = 40;
            lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbUsername.Location = new Point(29, 153);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(320, 48);
            tbUsername.TabIndex = 41;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPassword.Location = new Point(29, 244);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(320, 48);
            tbPassword.TabIndex = 42;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Cursor = Cursors.Hand;
            lbPassword.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.White;
            lbPassword.Location = new Point(29, 205);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(122, 35);
            lbPassword.TabIndex = 43;
            lbPassword.Text = "Password";
            lbPassword.Click += lbPassword_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Cursor = Cursors.Hand;
            lbID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.ForeColor = Color.White;
            lbID.Location = new Point(29, 12);
            lbID.Name = "lbID";
            lbID.Size = new Size(40, 35);
            lbID.TabIndex = 44;
            lbID.Text = "ID";
            // 
            // tbID
            // 
            tbID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbID.Location = new Point(29, 51);
            tbID.Margin = new Padding(3, 4, 3, 4);
            tbID.Multiline = true;
            tbID.Name = "tbID";
            tbID.Size = new Size(320, 48);
            tbID.TabIndex = 39;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Cursor = Cursors.Hand;
            lbRole.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(29, 307);
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
            panel1.Controls.Add(lbRole);
            panel1.Controls.Add(lbID);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tbID);
            panel1.Location = new Point(894, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 514);
            panel1.TabIndex = 50;
            // 
            // cbRole1
            // 
            cbRole1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbRole1.FormattingEnabled = true;
            cbRole1.Location = new Point(29, 346);
            cbRole1.Margin = new Padding(3, 4, 3, 4);
            cbRole1.Name = "cbRole1";
            cbRole1.Size = new Size(320, 36);
            cbRole1.TabIndex = 132;
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
            panel2.Size = new Size(1259, 109);
            panel2.TabIndex = 51;
            // 
            // btClear
            // 
            btClear.BackColor = Color.White;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClear.ForeColor = Color.DodgerBlue;
            btClear.Location = new Point(1075, 759);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(189, 60);
            btClear.TabIndex = 134;
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
            btRemove.Location = new Point(894, 819);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(371, 60);
            btRemove.TabIndex = 133;
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
            btSave.Location = new Point(894, 759);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(181, 60);
            btSave.TabIndex = 132;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(lbUserTotal);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(894, 636);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 119);
            panel3.TabIndex = 135;
            // 
            // lbUserTotal
            // 
            lbUserTotal.AutoSize = true;
            lbUserTotal.Cursor = Cursors.Hand;
            lbUserTotal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbUserTotal.ForeColor = Color.White;
            lbUserTotal.Location = new Point(21, 47);
            lbUserTotal.Name = "lbUserTotal";
            lbUserTotal.Size = new Size(40, 46);
            lbUserTotal.TabIndex = 28;
            lbUserTotal.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 128, 0);
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(16, 5);
            label13.Name = "label13";
            label13.Size = new Size(133, 35);
            label13.TabIndex = 27;
            label13.Text = "Total Usre";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_employees_100__1_;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(317, 5);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(34, 40);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // UserControlUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel3);
            Controls.Add(btClear);
            Controls.Add(btRemove);
            Controls.Add(btSave);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvuser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlUser";
            Size = new Size(1264, 885);
            ((System.ComponentModel.ISupportInitialize)dgvuser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvuser;
        private Label label2;
        private Label lbSeach;
        private TextBox tbSeachName;
        private ComboBox cbRole;
        private Label lbUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
        private Label lbID;
        private TextBox tbID;
        private Label lbRole;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cbRole1;
        private Button btClear;
        private Button btRemove;
        private Button btSave;
        private Panel panel3;
        private Label lbUserTotal;
        private Label label13;
        private PictureBox pictureBox13;
    }
}
