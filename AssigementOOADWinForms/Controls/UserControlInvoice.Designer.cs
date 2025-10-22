namespace AssigementOOADWinForms.Controls
{
    partial class UserControlInvoice
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
            label6 = new Label();
            textinvoiceID = new TextBox();
            searchEmployeeIDs = new Label();
            label1 = new Label();
            btnClear = new Button();
            label2 = new Label();
            btnremoveInvoice = new Button();
            btnSaveAndUpdateInvoice = new Button();
            label5 = new Label();
            textCustomerAddress = new TextBox();
            label3 = new Label();
            textcustomerName = new TextBox();
            dgvInvoice = new DataGridView();
            panel1 = new Panel();
            comboEmployee = new ComboBox();
            textcustomerPhone = new TextBox();
            label8 = new Label();
            datetimeorderDate = new DateTimePicker();
            label7 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            searchStartDate = new DateTimePicker();
            searchEmployee = new ComboBox();
            searchInvoiceDatess = new Label();
            searchEndDate = new DateTimePicker();
            searchCustomerName = new TextBox();
            btnCreateInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DodgerBlue;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, -1);
            label6.Name = "label6";
            label6.Size = new Size(119, 35);
            label6.TabIndex = 129;
            label6.Text = "InvoiceID";
            // 
            // textinvoiceID
            // 
            textinvoiceID.Font = new Font("Segoe UI", 15F);
            textinvoiceID.ForeColor = Color.FromArgb(64, 64, 64);
            textinvoiceID.Location = new Point(950, 43);
            textinvoiceID.Margin = new Padding(3, 4, 3, 4);
            textinvoiceID.Multiline = true;
            textinvoiceID.Name = "textinvoiceID";
            textinvoiceID.Size = new Size(305, 48);
            textinvoiceID.TabIndex = 128;
            // 
            // searchEmployeeIDs
            // 
            searchEmployeeIDs.AutoSize = true;
            searchEmployeeIDs.Cursor = Cursors.Hand;
            searchEmployeeIDs.Font = new Font("Segoe UI", 15F);
            searchEmployeeIDs.ForeColor = Color.White;
            searchEmployeeIDs.Location = new Point(277, 7);
            searchEmployeeIDs.Name = "searchEmployeeIDs";
            searchEmployeeIDs.Size = new Size(149, 35);
            searchEmployeeIDs.TabIndex = 127;
            searchEmployeeIDs.Text = "EmployeeID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(189, 35);
            label1.TabIndex = 126;
            label1.Text = "CustomerName";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.DodgerBlue;
            btnClear.Location = new Point(1112, 764);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 57);
            btnClear.TabIndex = 123;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 123);
            label2.Name = "label2";
            label2.Size = new Size(189, 35);
            label2.TabIndex = 122;
            label2.Text = "CustomerName";
            // 
            // btnremoveInvoice
            // 
            btnremoveInvoice.BackColor = Color.FromArgb(255, 128, 0);
            btnremoveInvoice.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnremoveInvoice.FlatAppearance.BorderSize = 0;
            btnremoveInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnremoveInvoice.ForeColor = Color.White;
            btnremoveInvoice.Location = new Point(934, 823);
            btnremoveInvoice.Margin = new Padding(0);
            btnremoveInvoice.Name = "btnremoveInvoice";
            btnremoveInvoice.Size = new Size(336, 57);
            btnremoveInvoice.TabIndex = 120;
            btnremoveInvoice.Text = "Remove";
            btnremoveInvoice.UseVisualStyleBackColor = false;
            // 
            // btnSaveAndUpdateInvoice
            // 
            btnSaveAndUpdateInvoice.BackColor = Color.DodgerBlue;
            btnSaveAndUpdateInvoice.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSaveAndUpdateInvoice.FlatAppearance.BorderSize = 0;
            btnSaveAndUpdateInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSaveAndUpdateInvoice.ForeColor = Color.White;
            btnSaveAndUpdateInvoice.Location = new Point(934, 764);
            btnSaveAndUpdateInvoice.Margin = new Padding(0);
            btnSaveAndUpdateInvoice.Name = "btnSaveAndUpdateInvoice";
            btnSaveAndUpdateInvoice.Size = new Size(174, 57);
            btnSaveAndUpdateInvoice.TabIndex = 119;
            btnSaveAndUpdateInvoice.Text = "Save";
            btnSaveAndUpdateInvoice.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DodgerBlue;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 244);
            label5.Name = "label5";
            label5.Size = new Size(192, 35);
            label5.TabIndex = 118;
            label5.Text = "CustomerPhone";
            // 
            // textCustomerAddress
            // 
            textCustomerAddress.Font = new Font("Segoe UI", 15F);
            textCustomerAddress.ForeColor = Color.FromArgb(64, 64, 64);
            textCustomerAddress.Location = new Point(15, 415);
            textCustomerAddress.Margin = new Padding(3, 4, 3, 4);
            textCustomerAddress.Multiline = true;
            textCustomerAddress.Name = "textCustomerAddress";
            textCustomerAddress.Size = new Size(303, 48);
            textCustomerAddress.TabIndex = 116;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 496);
            label3.Name = "label3";
            label3.Size = new Size(149, 35);
            label3.TabIndex = 115;
            label3.Text = "EmployeeID";
            // 
            // textcustomerName
            // 
            textcustomerName.Font = new Font("Segoe UI", 15F);
            textcustomerName.ForeColor = Color.FromArgb(64, 64, 64);
            textcustomerName.Location = new Point(15, 164);
            textcustomerName.Margin = new Padding(3, 4, 3, 4);
            textcustomerName.Multiline = true;
            textcustomerName.Name = "textcustomerName";
            textcustomerName.Size = new Size(305, 48);
            textcustomerName.TabIndex = 114;
            // 
            // dgvInvoice
            // 
            dgvInvoice.BackgroundColor = Color.White;
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(3, 143);
            dgvInvoice.Margin = new Padding(3, 4, 3, 4);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.Size = new Size(929, 739);
            dgvInvoice.TabIndex = 113;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(comboEmployee);
            panel1.Controls.Add(textcustomerName);
            panel1.Controls.Add(textcustomerPhone);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(datetimeorderDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textCustomerAddress);
            panel1.Location = new Point(935, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 700);
            panel1.TabIndex = 122;
            // 
            // comboEmployee
            // 
            comboEmployee.Font = new Font("Segoe UI", 15F);
            comboEmployee.ForeColor = Color.FromArgb(64, 64, 64);
            comboEmployee.FormattingEnabled = true;
            comboEmployee.Location = new Point(15, 537);
            comboEmployee.Margin = new Padding(3, 4, 3, 4);
            comboEmployee.Name = "comboEmployee";
            comboEmployee.Size = new Size(305, 43);
            comboEmployee.TabIndex = 135;
            // 
            // textcustomerPhone
            // 
            textcustomerPhone.Font = new Font("Segoe UI", 15F);
            textcustomerPhone.ForeColor = Color.FromArgb(64, 64, 64);
            textcustomerPhone.Location = new Point(15, 285);
            textcustomerPhone.Margin = new Padding(3, 4, 3, 4);
            textcustomerPhone.Multiline = true;
            textcustomerPhone.Name = "textcustomerPhone";
            textcustomerPhone.Size = new Size(305, 48);
            textcustomerPhone.TabIndex = 131;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DodgerBlue;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 589);
            label8.Name = "label8";
            label8.Size = new Size(132, 35);
            label8.TabIndex = 132;
            label8.Text = "OrderDate";
            // 
            // datetimeorderDate
            // 
            datetimeorderDate.CalendarForeColor = Color.FromArgb(64, 64, 64);
            datetimeorderDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            datetimeorderDate.Font = new Font("Segoe UI", 15F);
            datetimeorderDate.Location = new Point(15, 632);
            datetimeorderDate.Margin = new Padding(3, 4, 3, 4);
            datetimeorderDate.Name = "datetimeorderDate";
            datetimeorderDate.Size = new Size(303, 41);
            datetimeorderDate.TabIndex = 129;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DodgerBlue;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(15, 371);
            label7.Name = "label7";
            label7.Size = new Size(212, 35);
            label7.TabIndex = 130;
            label7.Text = "CustomerAddress";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(searchStartDate);
            panel2.Controls.Add(searchEmployee);
            panel2.Controls.Add(searchInvoiceDatess);
            panel2.Controls.Add(searchEndDate);
            panel2.Controls.Add(searchCustomerName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(searchEmployeeIDs);
            panel2.Location = new Point(3, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 133);
            panel2.TabIndex = 122;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DodgerBlue;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(736, 3);
            label4.Name = "label4";
            label4.Size = new Size(111, 35);
            label4.TabIndex = 136;
            label4.Text = "EndTime";
            // 
            // searchStartDate
            // 
            searchStartDate.CalendarForeColor = Color.FromArgb(64, 64, 64);
            searchStartDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            searchStartDate.Checked = false;
            searchStartDate.Font = new Font("Segoe UI", 15F);
            searchStartDate.Location = new Point(541, 51);
            searchStartDate.Margin = new Padding(3, 4, 3, 4);
            searchStartDate.Name = "searchStartDate";
            searchStartDate.ShowCheckBox = true;
            searchStartDate.Size = new Size(188, 41);
            searchStartDate.TabIndex = 135;
            // 
            // searchEmployee
            // 
            searchEmployee.Font = new Font("Segoe UI", 15F);
            searchEmployee.ForeColor = Color.FromArgb(64, 64, 64);
            searchEmployee.FormattingEnabled = true;
            searchEmployee.Location = new Point(270, 48);
            searchEmployee.Margin = new Padding(3, 4, 3, 4);
            searchEmployee.Name = "searchEmployee";
            searchEmployee.Size = new Size(258, 43);
            searchEmployee.TabIndex = 134;
            // 
            // searchInvoiceDatess
            // 
            searchInvoiceDatess.AutoSize = true;
            searchInvoiceDatess.BackColor = Color.DodgerBlue;
            searchInvoiceDatess.Cursor = Cursors.Hand;
            searchInvoiceDatess.Font = new Font("Segoe UI", 15F);
            searchInvoiceDatess.ForeColor = Color.White;
            searchInvoiceDatess.Location = new Point(541, 7);
            searchInvoiceDatess.Name = "searchInvoiceDatess";
            searchInvoiceDatess.Size = new Size(119, 35);
            searchInvoiceDatess.TabIndex = 133;
            searchInvoiceDatess.Text = "StartTime";
            // 
            // searchEndDate
            // 
            searchEndDate.CalendarForeColor = Color.FromArgb(64, 64, 64);
            searchEndDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            searchEndDate.Checked = false;
            searchEndDate.Font = new Font("Segoe UI", 15F);
            searchEndDate.Location = new Point(736, 51);
            searchEndDate.Margin = new Padding(3, 4, 3, 4);
            searchEndDate.Name = "searchEndDate";
            searchEndDate.ShowCheckBox = true;
            searchEndDate.Size = new Size(188, 41);
            searchEndDate.TabIndex = 133;
            // 
            // searchCustomerName
            // 
            searchCustomerName.Font = new Font("Segoe UI", 15F);
            searchCustomerName.ForeColor = Color.FromArgb(64, 64, 64);
            searchCustomerName.Location = new Point(13, 48);
            searchCustomerName.Margin = new Padding(3, 4, 3, 4);
            searchCustomerName.Multiline = true;
            searchCustomerName.Name = "searchCustomerName";
            searchCustomerName.Size = new Size(242, 48);
            searchCustomerName.TabIndex = 132;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.BackColor = Color.FromArgb(255, 128, 0);
            btnCreateInvoice.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnCreateInvoice.FlatAppearance.BorderSize = 0;
            btnCreateInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Location = new Point(933, 704);
            btnCreateInvoice.Margin = new Padding(0);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(336, 57);
            btnCreateInvoice.TabIndex = 129;
            btnCreateInvoice.Text = "View / Create Invoice Detail";
            btnCreateInvoice.UseVisualStyleBackColor = false;
            // 
            // UserControlInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btnCreateInvoice);
            Controls.Add(textinvoiceID);
            Controls.Add(btnClear);
            Controls.Add(btnremoveInvoice);
            Controls.Add(btnSaveAndUpdateInvoice);
            Controls.Add(dgvInvoice);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlInvoice";
            Size = new Size(1270, 885);
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private TextBox textinvoiceID;
        private Label searchEmployeeIDs;
        private Label label1;
        private Button btnClear;
        private Label label2;
        private Button btnremoveInvoice;
        private Button btnSaveAndUpdateInvoice;
        private Label label5;
        private TextBox textCustomerAddress;
        private Label label3;
        private TextBox textcustomerName;
        private DataGridView dgvInvoice;
        private Panel panel1;
        private Panel panel2;
        private TextBox searchCustomerName;
        private Label label7;
        private TextBox textcustomerPhone;
        private Label label8;
        private DateTimePicker datetimeorderDate;
        private DateTimePicker searchEndDate;
        private Label searchInvoiceDatess;
        private ComboBox searchEmployee;
        private Button btnCreateInvoice;
        private ComboBox comboEmployee;
        private Label label4;
        private DateTimePicker searchStartDate;
    }
}
