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
            btClear = new Button();
            lbSeach = new Label();
            tbSeach = new TextBox();
            cbRole1 = new ComboBox();
            pbProfile = new PictureBox();
            lbUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            lbID = new Label();
            btSave = new Button();
            btRemove = new Button();
            tbID = new TextBox();
            lbRole = new Label();
            cbRole2 = new ComboBox();
            btInsert = new Button();
            panel1 = new Panel();
            cbActive = new CheckBox();
            panel2 = new Panel();
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
            dgvuser.Size = new Size(819, 766);
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
            // btClear
            // 
            btClear.BackColor = Color.Orange;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btClear.ForeColor = Color.White;
            btClear.Location = new Point(629, 46);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(147, 49);
            btClear.TabIndex = 36;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
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
            tbSeach.Location = new Point(10, 45);
            tbSeach.Margin = new Padding(3, 4, 3, 4);
            tbSeach.Multiline = true;
            tbSeach.Name = "tbSeach";
            tbSeach.Size = new Size(270, 44);
            tbSeach.TabIndex = 34;
            // 
            // cbRole1
            // 
            cbRole1.Font = new Font("Segoe UI", 15F);
            cbRole1.FormattingEnabled = true;
            cbRole1.Location = new Point(292, 46);
            cbRole1.Margin = new Padding(3, 4, 3, 4);
            cbRole1.Name = "cbRole1";
            cbRole1.Size = new Size(285, 43);
            cbRole1.TabIndex = 33;
            // 
            // pbProfile
            // 
            pbProfile.BackgroundImage = Properties.Resources.user;
            pbProfile.BackgroundImageLayout = ImageLayout.Zoom;
            pbProfile.Location = new Point(86, 22);
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
            lbUsername.Location = new Point(49, 425);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(129, 35);
            lbUsername.TabIndex = 40;
            lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(49, 464);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(355, 48);
            tbUsername.TabIndex = 41;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(49, 565);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(355, 48);
            tbPassword.TabIndex = 42;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Cursor = Cursors.Hand;
            lbPassword.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.White;
            lbPassword.Location = new Point(49, 526);
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
            lbID.Location = new Point(49, 319);
            lbID.Name = "lbID";
            lbID.Size = new Size(40, 35);
            lbID.TabIndex = 44;
            lbID.Text = "ID";
            // 
            // btSave
            // 
            btSave.BackColor = Color.Green;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(63, 726);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(158, 49);
            btSave.TabIndex = 45;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.Maroon;
            btRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btRemove.FlatAppearance.BorderSize = 0;
            btRemove.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(221, 726);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(166, 49);
            btRemove.TabIndex = 46;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            // 
            // tbID
            // 
            tbID.Location = new Point(49, 363);
            tbID.Margin = new Padding(3, 4, 3, 4);
            tbID.Multiline = true;
            tbID.Name = "tbID";
            tbID.Size = new Size(355, 48);
            tbID.TabIndex = 39;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Cursor = Cursors.Hand;
            lbRole.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(49, 627);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(65, 35);
            lbRole.TabIndex = 47;
            lbRole.Text = "Role";
            // 
            // cbRole2
            // 
            cbRole2.Font = new Font("Segoe UI", 15F);
            cbRole2.FormattingEnabled = true;
            cbRole2.Location = new Point(49, 666);
            cbRole2.Margin = new Padding(3, 4, 3, 4);
            cbRole2.Name = "cbRole2";
            cbRole2.Size = new Size(355, 43);
            cbRole2.TabIndex = 48;
            // 
            // btInsert
            // 
            btInsert.BackColor = Color.Orange;
            btInsert.FlatAppearance.BorderColor = Color.DodgerBlue;
            btInsert.FlatAppearance.BorderSize = 0;
            btInsert.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btInsert.ForeColor = Color.White;
            btInsert.Location = new Point(63, 775);
            btInsert.Margin = new Padding(0);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(324, 49);
            btInsert.TabIndex = 49;
            btInsert.Text = "Insert";
            btInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cbActive);
            panel1.Controls.Add(btInsert);
            panel1.Controls.Add(cbRole2);
            panel1.Controls.Add(lbRole);
            panel1.Controls.Add(btRemove);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(lbID);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tbID);
            panel1.Controls.Add(pbProfile);
            panel1.Location = new Point(828, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 894);
            panel1.TabIndex = 50;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbActive.ForeColor = Color.White;
            cbActive.Location = new Point(286, 319);
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
            panel2.Controls.Add(btClear);
            panel2.Controls.Add(lbSeach);
            panel2.Controls.Add(tbSeach);
            panel2.Controls.Add(cbRole1);
            panel2.Location = new Point(-5, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 114);
            panel2.TabIndex = 51;
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
        private Button btClear;
        private Label lbSeach;
        private TextBox tbSeach;
        private ComboBox cbRole1;
        private PictureBox pbProfile;
        private Label lbUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
        private Label lbID;
        private Button btSave;
        private Button btRemove;
        private TextBox tbID;
        private Label lbRole;
        private ComboBox cbRole2;
        private Button btInsert;
        private Panel panel1;
        private CheckBox cbActive;
        private Panel panel2;
    }
}
