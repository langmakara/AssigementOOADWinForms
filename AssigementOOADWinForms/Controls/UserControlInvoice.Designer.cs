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
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            textEmployeeID = new TextBox();
            textTotalAmount = new TextBox();
            label3 = new Label();
            textcustomerName = new TextBox();
            dgvInvoice = new DataGridView();
            panel1 = new Panel();
            textcustomerPhone = new TextBox();
            label8 = new Label();
            datetimeorderDate = new DateTimePicker();
            label7 = new Label();
            panel2 = new Panel();
            searchEmployee = new ComboBox();
            searchInvoiceDatess = new Label();
            searchinvoiceDate = new DateTimePicker();
            searchCustomerName = new TextBox();
            button3 = new Button();
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
            label6.Location = new Point(17, -1);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 129;
            label6.Text = "InvoiceID";
            // 
            // textinvoiceID
            // 
            textinvoiceID.Font = new Font("Segoe UI", 15F);
            textinvoiceID.ForeColor = Color.FromArgb(64, 64, 64);
            textinvoiceID.Location = new Point(831, 32);
            textinvoiceID.Multiline = true;
            textinvoiceID.Name = "textinvoiceID";
            textinvoiceID.Size = new Size(267, 37);
            textinvoiceID.TabIndex = 128;
            // 
            // searchEmployeeIDs
            // 
            searchEmployeeIDs.AutoSize = true;
            searchEmployeeIDs.Cursor = Cursors.Hand;
            searchEmployeeIDs.Font = new Font("Segoe UI", 15F);
            searchEmployeeIDs.ForeColor = Color.White;
            searchEmployeeIDs.Location = new Point(269, 4);
            searchEmployeeIDs.Name = "searchEmployeeIDs";
            searchEmployeeIDs.Size = new Size(117, 28);
            searchEmployeeIDs.TabIndex = 127;
            searchEmployeeIDs.Text = "EmployeeID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 2);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
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
            btnClear.Location = new Point(972, 573);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 43);
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
            label2.Location = new Point(13, 92);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 122;
            label2.Text = "CustomerName";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(818, 617);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(290, 43);
            button2.TabIndex = 120;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(818, 573);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(152, 43);
            button1.TabIndex = 119;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DodgerBlue;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 183);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 118;
            label5.Text = "CustomerPhone";
            // 
            // textEmployeeID
            // 
            textEmployeeID.Font = new Font("Segoe UI", 15F);
            textEmployeeID.ForeColor = Color.FromArgb(64, 64, 64);
            textEmployeeID.Location = new Point(13, 305);
            textEmployeeID.Multiline = true;
            textEmployeeID.Name = "textEmployeeID";
            textEmployeeID.Size = new Size(266, 37);
            textEmployeeID.TabIndex = 117;
            // 
            // textTotalAmount
            // 
            textTotalAmount.Font = new Font("Segoe UI", 15F);
            textTotalAmount.ForeColor = Color.FromArgb(64, 64, 64);
            textTotalAmount.Location = new Point(13, 477);
            textTotalAmount.Multiline = true;
            textTotalAmount.Name = "textTotalAmount";
            textTotalAmount.Size = new Size(266, 37);
            textTotalAmount.TabIndex = 116;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 274);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 115;
            label3.Text = "EmployeeID";
            // 
            // textcustomerName
            // 
            textcustomerName.Font = new Font("Segoe UI", 15F);
            textcustomerName.ForeColor = Color.FromArgb(64, 64, 64);
            textcustomerName.Location = new Point(13, 123);
            textcustomerName.Multiline = true;
            textcustomerName.Name = "textcustomerName";
            textcustomerName.Size = new Size(267, 37);
            textcustomerName.TabIndex = 114;
            // 
            // dgvInvoice
            // 
            dgvInvoice.BackgroundColor = Color.White;
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(3, 107);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.Size = new Size(813, 554);
            dgvInvoice.TabIndex = 113;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(textcustomerName);
            panel1.Controls.Add(textcustomerPhone);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(datetimeorderDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textTotalAmount);
            panel1.Controls.Add(textEmployeeID);
            panel1.Location = new Point(818, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 525);
            panel1.TabIndex = 122;
            // 
            // textcustomerPhone
            // 
            textcustomerPhone.Font = new Font("Segoe UI", 15F);
            textcustomerPhone.ForeColor = Color.FromArgb(64, 64, 64);
            textcustomerPhone.Location = new Point(13, 214);
            textcustomerPhone.Multiline = true;
            textcustomerPhone.Name = "textcustomerPhone";
            textcustomerPhone.Size = new Size(267, 37);
            textcustomerPhone.TabIndex = 131;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DodgerBlue;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 368);
            label8.Name = "label8";
            label8.Size = new Size(104, 28);
            label8.TabIndex = 132;
            label8.Text = "OrderDate";
            // 
            // datetimeorderDate
            // 
            datetimeorderDate.CalendarForeColor = Color.FromArgb(64, 64, 64);
            datetimeorderDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            datetimeorderDate.Font = new Font("Segoe UI", 11F);
            datetimeorderDate.Location = new Point(13, 399);
            datetimeorderDate.Name = "datetimeorderDate";
            datetimeorderDate.Size = new Size(266, 27);
            datetimeorderDate.TabIndex = 129;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DodgerBlue;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 446);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 130;
            label7.Text = "TotalAmount";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(searchEmployee);
            panel2.Controls.Add(searchInvoiceDatess);
            panel2.Controls.Add(searchinvoiceDate);
            panel2.Controls.Add(searchCustomerName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(searchEmployeeIDs);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(813, 100);
            panel2.TabIndex = 122;
            // 
            // searchEmployee
            // 
            searchEmployee.Font = new Font("Segoe UI", 15F);
            searchEmployee.ForeColor = Color.FromArgb(64, 64, 64);
            searchEmployee.FormattingEnabled = true;
            searchEmployee.Location = new Point(269, 35);
            searchEmployee.Name = "searchEmployee";
            searchEmployee.Size = new Size(270, 36);
            searchEmployee.TabIndex = 134;
            // 
            // searchInvoiceDatess
            // 
            searchInvoiceDatess.AutoSize = true;
            searchInvoiceDatess.BackColor = Color.DodgerBlue;
            searchInvoiceDatess.Cursor = Cursors.Hand;
            searchInvoiceDatess.Font = new Font("Segoe UI", 15F);
            searchInvoiceDatess.ForeColor = Color.White;
            searchInvoiceDatess.Location = new Point(545, 3);
            searchInvoiceDatess.Name = "searchInvoiceDatess";
            searchInvoiceDatess.Size = new Size(115, 28);
            searchInvoiceDatess.TabIndex = 133;
            searchInvoiceDatess.Text = "InvoiceDate";
            // 
            // searchinvoiceDate
            // 
            searchinvoiceDate.CalendarForeColor = Color.FromArgb(64, 64, 64);
            searchinvoiceDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            searchinvoiceDate.Font = new Font("Segoe UI", 11F);
            searchinvoiceDate.Location = new Point(545, 44);
            searchinvoiceDate.Name = "searchinvoiceDate";
            searchinvoiceDate.Size = new Size(259, 27);
            searchinvoiceDate.TabIndex = 133;
            // 
            // searchCustomerName
            // 
            searchCustomerName.Font = new Font("Segoe UI", 15F);
            searchCustomerName.ForeColor = Color.FromArgb(64, 64, 64);
            searchCustomerName.Location = new Point(16, 35);
            searchCustomerName.Multiline = true;
            searchCustomerName.Name = "searchCustomerName";
            searchCustomerName.Size = new Size(247, 37);
            searchCustomerName.TabIndex = 132;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(819, 528);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(290, 43);
            button3.TabIndex = 129;
            button3.Text = "Create Invoice Detail";
            button3.UseVisualStyleBackColor = false;
            // 
            // UserControlInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(button3);
            Controls.Add(textinvoiceID);
            Controls.Add(btnClear);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvInvoice);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserControlInvoice";
            Size = new Size(1111, 664);
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
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textEmployeeID;
        private TextBox textTotalAmount;
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
        private DateTimePicker searchinvoiceDate;
        private Label searchInvoiceDatess;
        private ComboBox searchEmployee;
        private Button button3;
    }
}
