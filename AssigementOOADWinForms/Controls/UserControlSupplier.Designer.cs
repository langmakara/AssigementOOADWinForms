namespace AssigementOOADWinForms.Controls
{
    partial class UserControlSupplier
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
            btClear = new Button();
            btRemove = new Button();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            btSave = new Button();
            panel1 = new Panel();
            tbEmail = new TextBox();
            tbSupplierID = new TextBox();
            lbEmail = new Label();
            lbAddress = new Label();
            tbContactName = new TextBox();
            lbSupplierID = new Label();
            lbContactName = new Label();
            lbSupplierName = new Label();
            lbPhoneNumble = new Label();
            tbAddress = new TextBox();
            tbSupplierName = new TextBox();
            tbPhoneNumble = new TextBox();
            panel2 = new Panel();
            tbSeach = new TextBox();
            lbSeach = new Label();
            dgvcustomer = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).BeginInit();
            SuspendLayout();
            // 
            // btClear
            // 
            btClear.BackColor = Color.White;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClear.ForeColor = Color.DodgerBlue;
            btClear.Location = new Point(1074, 762);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(189, 60);
            btClear.TabIndex = 135;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.FromArgb(255, 128, 0);
            btRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btRemove.FlatAppearance.BorderSize = 0;
            btRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(880, 820);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(383, 60);
            btRemove.TabIndex = 134;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(881, 639);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 120);
            panel3.TabIndex = 133;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(30, 53);
            label14.Name = "label14";
            label14.Size = new Size(120, 46);
            label14.TabIndex = 28;
            label14.Text = "12000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 128, 0);
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(13, 16);
            label13.Name = "label13";
            label13.Size = new Size(268, 35);
            label13.TabIndex = 27;
            label13.Text = "Transation Per Month";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_employees_100__1_;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(322, 13);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(34, 40);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(880, 762);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(207, 60);
            btSave.TabIndex = 132;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbSupplierID);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(lbAddress);
            panel1.Controls.Add(tbContactName);
            panel1.Controls.Add(lbSupplierID);
            panel1.Controls.Add(lbContactName);
            panel1.Controls.Add(lbSupplierName);
            panel1.Controls.Add(lbPhoneNumble);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(tbSupplierName);
            panel1.Controls.Add(tbPhoneNumble);
            panel1.Location = new Point(881, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 643);
            panel1.TabIndex = 130;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbEmail.Location = new Point(19, 400);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(346, 48);
            tbEmail.TabIndex = 134;
            // 
            // tbSupplierID
            // 
            tbSupplierID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSupplierID.Location = new Point(19, 40);
            tbSupplierID.Margin = new Padding(3, 4, 3, 4);
            tbSupplierID.Multiline = true;
            tbSupplierID.Name = "tbSupplierID";
            tbSupplierID.Size = new Size(346, 48);
            tbSupplierID.TabIndex = 133;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.DodgerBlue;
            lbEmail.Cursor = Cursors.Hand;
            lbEmail.Font = new Font("Segoe UI", 15F);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(15, 361);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(75, 35);
            lbEmail.TabIndex = 132;
            lbEmail.Text = "Email";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.BackColor = Color.DodgerBlue;
            lbAddress.Cursor = Cursors.Hand;
            lbAddress.Font = new Font("Segoe UI", 15F);
            lbAddress.ForeColor = Color.White;
            lbAddress.Location = new Point(11, 448);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(105, 35);
            lbAddress.TabIndex = 130;
            lbAddress.Text = "Address";
            // 
            // tbContactName
            // 
            tbContactName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbContactName.Location = new Point(19, 218);
            tbContactName.Margin = new Padding(3, 4, 3, 4);
            tbContactName.Multiline = true;
            tbContactName.Name = "tbContactName";
            tbContactName.Size = new Size(346, 48);
            tbContactName.TabIndex = 131;
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.BackColor = Color.DodgerBlue;
            lbSupplierID.Font = new Font("Segoe UI", 15F);
            lbSupplierID.ForeColor = Color.White;
            lbSupplierID.Location = new Point(19, -1);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new Size(138, 35);
            lbSupplierID.TabIndex = 129;
            lbSupplierID.Text = "Supplier ID";
            // 
            // lbContactName
            // 
            lbContactName.AutoSize = true;
            lbContactName.BackColor = Color.DodgerBlue;
            lbContactName.Cursor = Cursors.Hand;
            lbContactName.Font = new Font("Segoe UI", 15F);
            lbContactName.ForeColor = Color.White;
            lbContactName.Location = new Point(19, 179);
            lbContactName.Name = "lbContactName";
            lbContactName.Size = new Size(174, 35);
            lbContactName.TabIndex = 118;
            lbContactName.Text = "Contact Name";
            // 
            // lbSupplierName
            // 
            lbSupplierName.AutoSize = true;
            lbSupplierName.BackColor = Color.DodgerBlue;
            lbSupplierName.Cursor = Cursors.Hand;
            lbSupplierName.Font = new Font("Segoe UI", 15F);
            lbSupplierName.ForeColor = Color.White;
            lbSupplierName.Location = new Point(19, 92);
            lbSupplierName.Name = "lbSupplierName";
            lbSupplierName.Size = new Size(180, 35);
            lbSupplierName.TabIndex = 122;
            lbSupplierName.Text = "Supplier Name";
            // 
            // lbPhoneNumble
            // 
            lbPhoneNumble.AutoSize = true;
            lbPhoneNumble.BackColor = Color.DodgerBlue;
            lbPhoneNumble.Cursor = Cursors.Hand;
            lbPhoneNumble.Font = new Font("Segoe UI", 15F);
            lbPhoneNumble.ForeColor = Color.White;
            lbPhoneNumble.Location = new Point(18, 270);
            lbPhoneNumble.Name = "lbPhoneNumble";
            lbPhoneNumble.Size = new Size(181, 35);
            lbPhoneNumble.TabIndex = 115;
            lbPhoneNumble.Text = "Phone Numble";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbAddress.Location = new Point(13, 490);
            tbAddress.Margin = new Padding(3, 4, 3, 4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(347, 48);
            tbAddress.TabIndex = 116;
            // 
            // tbSupplierName
            // 
            tbSupplierName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSupplierName.Location = new Point(19, 131);
            tbSupplierName.Margin = new Padding(3, 4, 3, 4);
            tbSupplierName.Multiline = true;
            tbSupplierName.Name = "tbSupplierName";
            tbSupplierName.Size = new Size(346, 48);
            tbSupplierName.TabIndex = 114;
            // 
            // tbPhoneNumble
            // 
            tbPhoneNumble.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPhoneNumble.Location = new Point(19, 312);
            tbPhoneNumble.Margin = new Padding(3, 4, 3, 4);
            tbPhoneNumble.Multiline = true;
            tbPhoneNumble.Name = "tbPhoneNumble";
            tbPhoneNumble.Size = new Size(346, 48);
            tbPhoneNumble.TabIndex = 117;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(tbSeach);
            panel2.Controls.Add(lbSeach);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 133);
            panel2.TabIndex = 131;
            // 
            // tbSeach
            // 
            tbSeach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSeach.Location = new Point(9, 44);
            tbSeach.Margin = new Padding(3, 4, 3, 4);
            tbSeach.Multiline = true;
            tbSeach.Name = "tbSeach";
            tbSeach.Size = new Size(313, 48);
            tbSeach.TabIndex = 132;
            // 
            // lbSeach
            // 
            lbSeach.AutoSize = true;
            lbSeach.Cursor = Cursors.Hand;
            lbSeach.Font = new Font("Segoe UI", 15F);
            lbSeach.ForeColor = Color.White;
            lbSeach.Location = new Point(9, 3);
            lbSeach.Name = "lbSeach";
            lbSeach.Size = new Size(80, 35);
            lbSeach.TabIndex = 126;
            lbSeach.Text = "Seach";
            // 
            // dgvcustomer
            // 
            dgvcustomer.BackgroundColor = Color.White;
            dgvcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomer.Location = new Point(3, 136);
            dgvcustomer.Margin = new Padding(3, 4, 3, 4);
            dgvcustomer.Name = "dgvcustomer";
            dgvcustomer.RowHeadersWidth = 51;
            dgvcustomer.Size = new Size(876, 748);
            dgvcustomer.TabIndex = 129;
            // 
            // UserControlSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btClear);
            Controls.Add(btRemove);
            Controls.Add(panel3);
            Controls.Add(btSave);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvcustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlSupplier";
            Size = new Size(1264, 885);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btClear;
        private Button btRemove;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button btSave;
        private Panel panel1;
        private TextBox tbEmail;
        private TextBox tbSupplierID;
        private Label lbEmail;
        private Label lbAddress;
        private TextBox tbContactName;
        private Label lbSupplierID;
        private Label lbContactName;
        private Label lbSupplierName;
        private Label lbPhoneNumble;
        private TextBox tbAddress;
        private TextBox tbSupplierName;
        private TextBox tbPhoneNumble;
        private Panel panel2;
        private TextBox tbSeach;
        private Label lbSeach;
        private DataGridView dgvcustomer;
    }
}
