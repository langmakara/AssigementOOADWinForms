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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btClear = new Button();
            btSave = new Button();
            panel1 = new Panel();
            lbSupplierID = new Label();
            tbEmail = new TextBox();
            tbSupplierID = new TextBox();
            lbEmail = new Label();
            lbAddress = new Label();
            tbContactName = new TextBox();
            lbContactName = new Label();
            lbSupplierName = new Label();
            lbPhoneNumble = new Label();
            tbAddress = new TextBox();
            tbSupplierName = new TextBox();
            tbPhoneNumble = new TextBox();
            panel2 = new Panel();
            tbSeach = new TextBox();
            lbSeach = new Label();
            dgvSupplier = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // btClear
            // 
            btClear.BackColor = Color.Salmon;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClear.ForeColor = Color.White;
            btClear.Location = new Point(880, 779);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(382, 60);
            btClear.TabIndex = 135;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(882, 707);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(382, 60);
            btSave.TabIndex = 132;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(lbSupplierID);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbSupplierID);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(lbAddress);
            panel1.Controls.Add(tbContactName);
            panel1.Controls.Add(lbContactName);
            panel1.Controls.Add(lbSupplierName);
            panel1.Controls.Add(lbPhoneNumble);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(tbSupplierName);
            panel1.Controls.Add(tbPhoneNumble);
            panel1.Location = new Point(881, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 684);
            panel1.TabIndex = 130;
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.BackColor = Color.DodgerBlue;
            lbSupplierID.Font = new Font("Segoe UI", 15F);
            lbSupplierID.ForeColor = Color.White;
            lbSupplierID.Location = new Point(13, 18);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new Size(138, 35);
            lbSupplierID.TabIndex = 129;
            lbSupplierID.Text = "Supplier ID";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbEmail.Location = new Point(13, 492);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(349, 50);
            tbEmail.TabIndex = 134;
            // 
            // tbSupplierID
            // 
            tbSupplierID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSupplierID.Location = new Point(12, 58);
            tbSupplierID.Margin = new Padding(3, 4, 3, 4);
            tbSupplierID.Multiline = true;
            tbSupplierID.Name = "tbSupplierID";
            tbSupplierID.Size = new Size(350, 48);
            tbSupplierID.TabIndex = 133;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.DodgerBlue;
            lbEmail.Cursor = Cursors.Hand;
            lbEmail.Font = new Font("Segoe UI", 15F);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(10, 452);
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
            lbAddress.Location = new Point(10, 560);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(105, 35);
            lbAddress.TabIndex = 130;
            lbAddress.Text = "Address";
            // 
            // tbContactName
            // 
            tbContactName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbContactName.Location = new Point(13, 277);
            tbContactName.Margin = new Padding(3, 4, 3, 4);
            tbContactName.Multiline = true;
            tbContactName.Name = "tbContactName";
            tbContactName.Size = new Size(349, 48);
            tbContactName.TabIndex = 131;
            // 
            // lbContactName
            // 
            lbContactName.AutoSize = true;
            lbContactName.BackColor = Color.DodgerBlue;
            lbContactName.Cursor = Cursors.Hand;
            lbContactName.Font = new Font("Segoe UI", 15F);
            lbContactName.ForeColor = Color.White;
            lbContactName.Location = new Point(10, 237);
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
            lbSupplierName.Location = new Point(11, 128);
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
            lbPhoneNumble.Location = new Point(10, 344);
            lbPhoneNumble.Name = "lbPhoneNumble";
            lbPhoneNumble.Size = new Size(181, 35);
            lbPhoneNumble.TabIndex = 115;
            lbPhoneNumble.Text = "Phone Numble";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbAddress.Location = new Point(12, 601);
            tbAddress.Margin = new Padding(3, 4, 3, 4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(350, 50);
            tbAddress.TabIndex = 116;
            // 
            // tbSupplierName
            // 
            tbSupplierName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSupplierName.Location = new Point(13, 169);
            tbSupplierName.Margin = new Padding(3, 4, 3, 4);
            tbSupplierName.Multiline = true;
            tbSupplierName.Name = "tbSupplierName";
            tbSupplierName.Size = new Size(349, 48);
            tbSupplierName.TabIndex = 114;
            // 
            // tbPhoneNumble
            // 
            tbPhoneNumble.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPhoneNumble.Location = new Point(13, 385);
            tbPhoneNumble.Margin = new Padding(3, 4, 3, 4);
            tbPhoneNumble.Multiline = true;
            tbPhoneNumble.Name = "tbPhoneNumble";
            tbPhoneNumble.Size = new Size(349, 49);
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
            panel2.Size = new Size(876, 106);
            panel2.TabIndex = 131;
            // 
            // tbSeach
            // 
            tbSeach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSeach.Location = new Point(48, 30);
            tbSeach.Margin = new Padding(3, 4, 3, 4);
            tbSeach.Multiline = true;
            tbSeach.Name = "tbSeach";
            tbSeach.Size = new Size(513, 44);
            tbSeach.TabIndex = 132;
            tbSeach.TextChanged += tbSeach_TextChanged_1;
            // 
            // lbSeach
            // 
            lbSeach.AutoSize = true;
            lbSeach.BackColor = Color.White;
            lbSeach.Cursor = Cursors.Hand;
            lbSeach.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSeach.ForeColor = SystemColors.Highlight;
            lbSeach.Location = new Point(567, 30);
            lbSeach.Name = "lbSeach";
            lbSeach.Padding = new Padding(5, 5, 5, 7);
            lbSeach.Size = new Size(268, 43);
            lbSeach.TabIndex = 126;
            lbSeach.Text = "Search By ContactName";
            // 
            // dgvSupplier
            // 
            dgvSupplier.AllowUserToAddRows = false;
            dgvSupplier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dgvSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.BackgroundColor = SystemColors.ControlLightLight;
            dgvSupplier.BorderStyle = BorderStyle.None;
            dgvSupplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvSupplier.DefaultCellStyle = dataGridViewCellStyle7;
            dgvSupplier.EnableHeadersVisualStyles = false;
            dgvSupplier.GridColor = SystemColors.ControlLight;
            dgvSupplier.Location = new Point(3, 114);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.ReadOnly = true;
            dgvSupplier.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dgvSupplier.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvSupplier.Size = new Size(874, 766);
            dgvSupplier.TabIndex = 136;
            dgvSupplier.CellClick += dgvSupplier_CellClick_1;
            // 
            // UserControlSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(dgvSupplier);
            Controls.Add(btClear);
            Controls.Add(btSave);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlSupplier";
            Size = new Size(1264, 885);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btClear;
        private Button btSave;
        private Panel panel1;
        private TextBox tbEmail;
        private TextBox tbSupplierID;
        private Label lbEmail;
        private Label lbAddress;
        private TextBox tbContactName;
        private Label lbContactName;
        private Label lbSupplierName;
        private Label lbPhoneNumble;
        private TextBox tbAddress;
        private TextBox tbSupplierName;
        private TextBox tbPhoneNumble;
        private Panel panel2;
        private TextBox tbSeach;
        private Label lbSeach;
        private Label lbSupplierID;
        private DataGridView dgvSupplier;
    }
}
