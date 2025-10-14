namespace AssigementOOADWinForms.Controls
{
    partial class UserControlEmployee
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
            label5 = new Label();
            label4 = new Label();
            tbAddress = new TextBox();
            tbPhone = new TextBox();
            label3 = new Label();
            tbName = new TextBox();
            tbsearchEmployeeName = new TextBox();
            dgvemployee = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            tbEmployeeID = new TextBox();
            tbPosition = new TextBox();
            dtpHireDate = new DateTimePicker();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            btClear = new Button();
            btRemove = new Button();
            btSave = new Button();
            cbPositionFilter = new ComboBox();
            label9 = new Label();
            tbEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvemployee).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 178);
            label5.Name = "label5";
            label5.Size = new Size(88, 35);
            label5.TabIndex = 59;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 364);
            label4.Name = "label4";
            label4.Size = new Size(141, 35);
            label4.TabIndex = 58;
            label4.Text = "Address     ";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 15F);
            tbAddress.Location = new Point(8, 403);
            tbAddress.Margin = new Padding(3, 4, 3, 4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(343, 48);
            tbAddress.TabIndex = 57;
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 15F);
            tbPhone.Location = new Point(8, 217);
            tbPhone.Margin = new Padding(3, 4, 3, 4);
            tbPhone.Multiline = true;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(343, 48);
            tbPhone.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 89);
            label3.Name = "label3";
            label3.Size = new Size(82, 35);
            label3.TabIndex = 55;
            label3.Text = "Name";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 15F);
            tbName.Location = new Point(8, 128);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(343, 48);
            tbName.TabIndex = 54;
            // 
            // tbsearchEmployeeName
            // 
            tbsearchEmployeeName.Font = new Font("Segoe UI", 15F);
            tbsearchEmployeeName.Location = new Point(10, 46);
            tbsearchEmployeeName.Margin = new Padding(3, 4, 3, 4);
            tbsearchEmployeeName.Multiline = true;
            tbsearchEmployeeName.Name = "tbsearchEmployeeName";
            tbsearchEmployeeName.Size = new Size(267, 45);
            tbsearchEmployeeName.TabIndex = 49;
            // 
            // dgvemployee
            // 
            dgvemployee.BackgroundColor = Color.White;
            dgvemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvemployee.Location = new Point(3, 120);
            dgvemployee.Margin = new Padding(3, 4, 3, 4);
            dgvemployee.Name = "dgvemployee";
            dgvemployee.RowHeadersWidth = 51;
            dgvemployee.Size = new Size(891, 761);
            dgvemployee.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 455);
            label6.Name = "label6";
            label6.Size = new Size(122, 35);
            label6.TabIndex = 63;
            label6.Text = "Position  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 546);
            label7.Name = "label7";
            label7.Size = new Size(115, 35);
            label7.TabIndex = 65;
            label7.Text = "HireDate";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbEmployeeID);
            panel1.Controls.Add(tbPosition);
            panel1.Controls.Add(dtpHireDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbName);
            panel1.Location = new Point(897, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 637);
            panel1.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 2);
            label8.Name = "label8";
            label8.Size = new Size(151, 35);
            label8.TabIndex = 69;
            label8.Text = "EmployeeID";
            // 
            // tbEmployeeID
            // 
            tbEmployeeID.Font = new Font("Segoe UI", 15F);
            tbEmployeeID.Location = new Point(6, 41);
            tbEmployeeID.Margin = new Padding(3, 4, 3, 4);
            tbEmployeeID.Multiline = true;
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(343, 48);
            tbEmployeeID.TabIndex = 68;
            // 
            // tbPosition
            // 
            tbPosition.Font = new Font("Segoe UI", 15F);
            tbPosition.Location = new Point(8, 494);
            tbPosition.Margin = new Padding(3, 4, 3, 4);
            tbPosition.Multiline = true;
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(343, 48);
            tbPosition.TabIndex = 67;
            // 
            // dtpHireDate
            // 
            dtpHireDate.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Font = new Font("Segoe UI", 12F);
            dtpHireDate.Location = new Point(8, 584);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(341, 34);
            dtpHireDate.TabIndex = 66;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbsearchEmployeeName);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 110);
            panel2.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(290, 9);
            label2.Name = "label2";
            label2.Size = new Size(108, 35);
            label2.TabIndex = 53;
            label2.Text = "Position";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(126, 35);
            label1.TabIndex = 52;
            label1.Text = "Employee";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(897, 639);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 119);
            panel3.TabIndex = 126;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(21, 47);
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
            label13.Location = new Point(16, 5);
            label13.Name = "label13";
            label13.Size = new Size(206, 35);
            label13.TabIndex = 27;
            label13.Text = "Total Employees";
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
            // btClear
            // 
            btClear.BackColor = Color.White;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClear.ForeColor = Color.DodgerBlue;
            btClear.Location = new Point(1085, 762);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(179, 64);
            btClear.TabIndex = 125;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btnRefresh_Click;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.FromArgb(255, 128, 0);
            btRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btRemove.FlatAppearance.BorderSize = 0;
            btRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(897, 826);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(367, 56);
            btRemove.TabIndex = 124;
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
            btSave.Location = new Point(897, 762);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(179, 64);
            btSave.TabIndex = 123;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // cbPositionFilter
            // 
            cbPositionFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPositionFilter.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPositionFilter.Location = new Point(290, 48);
            cbPositionFilter.Name = "cbPositionFilter";
            cbPositionFilter.Size = new Size(285, 43);
            cbPositionFilter.TabIndex = 0;
            cbPositionFilter.SelectedIndexChanged += CbPositionFilter_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(8, 273);
            label9.Name = "label9";
            label9.Size = new Size(77, 35);
            label9.TabIndex = 71;
            label9.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 15F);
            tbEmail.Location = new Point(8, 312);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(343, 48);
            tbEmail.TabIndex = 70;
            // 
            // UserControlEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(cbPositionFilter);
            Controls.Add(panel3);
            Controls.Add(btClear);
            Controls.Add(btRemove);
            Controls.Add(btSave);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvemployee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlEmployee";
            Size = new Size(1264, 885);
            ((System.ComponentModel.ISupportInitialize)dgvemployee).EndInit();
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
        private Label label5;
        private Label label4;
        private TextBox tbAddress;
        private TextBox tbPhone;
        private Label label3;
        private TextBox tbName;
        private TextBox tbsearchEmployeeName;
        private DataGridView dgvemployee;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button btClear;
        private Button btRemove;
        private Button btSave;
        private DateTimePicker dtpHireDate;
        private ComboBox cbPositionFilter;
        private TextBox tbPosition;
        private Label label8;
        private TextBox tbEmployeeID;
        private Label label9;
        private TextBox tbEmail;
    }
}
