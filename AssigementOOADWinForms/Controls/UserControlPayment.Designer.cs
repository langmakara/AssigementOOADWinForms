namespace AssigementOOADWinForms.Controls
{
    partial class UserControlPayment
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
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            btnRefresh = new Button();
            panel1 = new Panel();
            tbSaleID = new TextBox();
            tbPaymentMethod = new TextBox();
            lbSaleID = new Label();
            lbPaymentMethod = new Label();
            lbPaymentDate = new Label();
            lbAmountPaid = new Label();
            tbPaymentDate = new TextBox();
            tbAmountPaid = new TextBox();
            panel2 = new Panel();
            lbInvoiceDate = new Label();
            InvoiceDate = new DateTimePicker();
            dgvcustomer = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(1074, 762);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(189, 60);
            button3.TabIndex = 135;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(880, 820);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(383, 60);
            button2.TabIndex = 134;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
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
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(880, 762);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(194, 60);
            btnRefresh.TabIndex = 132;
            btnRefresh.Text = "Save";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(tbSaleID);
            panel1.Controls.Add(tbPaymentMethod);
            panel1.Controls.Add(lbSaleID);
            panel1.Controls.Add(lbPaymentMethod);
            panel1.Controls.Add(lbPaymentDate);
            panel1.Controls.Add(lbAmountPaid);
            panel1.Controls.Add(tbPaymentDate);
            panel1.Controls.Add(tbAmountPaid);
            panel1.Location = new Point(881, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 643);
            panel1.TabIndex = 130;
            // 
            // tbSaleID
            // 
            tbSaleID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSaleID.Location = new Point(19, 44);
            tbSaleID.Margin = new Padding(3, 4, 3, 4);
            tbSaleID.Multiline = true;
            tbSaleID.Name = "tbSaleID";
            tbSaleID.Size = new Size(346, 48);
            tbSaleID.TabIndex = 133;
            // 
            // tbPaymentMethod
            // 
            tbPaymentMethod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPaymentMethod.Location = new Point(19, 218);
            tbPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            tbPaymentMethod.Multiline = true;
            tbPaymentMethod.Name = "tbPaymentMethod";
            tbPaymentMethod.Size = new Size(346, 48);
            tbPaymentMethod.TabIndex = 131;
            // 
            // lbSaleID
            // 
            lbSaleID.AutoSize = true;
            lbSaleID.BackColor = Color.DodgerBlue;
            lbSaleID.Cursor = Cursors.Hand;
            lbSaleID.Font = new Font("Segoe UI", 15F);
            lbSaleID.ForeColor = Color.White;
            lbSaleID.Location = new Point(19, 3);
            lbSaleID.Name = "lbSaleID";
            lbSaleID.Size = new Size(92, 35);
            lbSaleID.TabIndex = 129;
            lbSaleID.Text = "Sale ID";
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.BackColor = Color.DodgerBlue;
            lbPaymentMethod.Cursor = Cursors.Hand;
            lbPaymentMethod.Font = new Font("Segoe UI", 15F);
            lbPaymentMethod.ForeColor = Color.White;
            lbPaymentMethod.Location = new Point(19, 179);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(204, 35);
            lbPaymentMethod.TabIndex = 118;
            lbPaymentMethod.Text = "Payment Method";
            // 
            // lbPaymentDate
            // 
            lbPaymentDate.AutoSize = true;
            lbPaymentDate.BackColor = Color.DodgerBlue;
            lbPaymentDate.Cursor = Cursors.Hand;
            lbPaymentDate.Font = new Font("Segoe UI", 15F);
            lbPaymentDate.ForeColor = Color.White;
            lbPaymentDate.Location = new Point(19, 92);
            lbPaymentDate.Name = "lbPaymentDate";
            lbPaymentDate.Size = new Size(169, 35);
            lbPaymentDate.TabIndex = 122;
            lbPaymentDate.Text = "Payment Date";
            // 
            // lbAmountPaid
            // 
            lbAmountPaid.AutoSize = true;
            lbAmountPaid.BackColor = Color.DodgerBlue;
            lbAmountPaid.Cursor = Cursors.Hand;
            lbAmountPaid.Font = new Font("Segoe UI", 15F);
            lbAmountPaid.ForeColor = Color.White;
            lbAmountPaid.Location = new Point(18, 270);
            lbAmountPaid.Name = "lbAmountPaid";
            lbAmountPaid.Size = new Size(158, 35);
            lbAmountPaid.TabIndex = 115;
            lbAmountPaid.Text = "Amount Paid";
            // 
            // tbPaymentDate
            // 
            tbPaymentDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPaymentDate.Location = new Point(19, 131);
            tbPaymentDate.Margin = new Padding(3, 4, 3, 4);
            tbPaymentDate.Multiline = true;
            tbPaymentDate.Name = "tbPaymentDate";
            tbPaymentDate.Size = new Size(346, 48);
            tbPaymentDate.TabIndex = 114;
            // 
            // tbAmountPaid
            // 
            tbAmountPaid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbAmountPaid.Location = new Point(19, 312);
            tbAmountPaid.Margin = new Padding(3, 4, 3, 4);
            tbAmountPaid.Multiline = true;
            tbAmountPaid.Name = "tbAmountPaid";
            tbAmountPaid.Size = new Size(346, 48);
            tbAmountPaid.TabIndex = 117;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(lbInvoiceDate);
            panel2.Controls.Add(InvoiceDate);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 133);
            panel2.TabIndex = 131;
            // 
            // lbInvoiceDate
            // 
            lbInvoiceDate.AutoSize = true;
            lbInvoiceDate.BackColor = Color.DodgerBlue;
            lbInvoiceDate.Cursor = Cursors.Hand;
            lbInvoiceDate.Font = new Font("Segoe UI", 15F);
            lbInvoiceDate.ForeColor = Color.White;
            lbInvoiceDate.Location = new Point(2, 4);
            lbInvoiceDate.Name = "lbInvoiceDate";
            lbInvoiceDate.Size = new Size(169, 35);
            lbInvoiceDate.TabIndex = 133;
            lbInvoiceDate.Text = "Payment Date";
            // 
            // InvoiceDate
            // 
            InvoiceDate.CalendarForeColor = Color.White;
            InvoiceDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            InvoiceDate.Font = new Font("Segoe UI", 16F);
            InvoiceDate.Location = new Point(2, 45);
            InvoiceDate.Margin = new Padding(3, 4, 3, 4);
            InvoiceDate.Name = "InvoiceDate";
            InvoiceDate.Size = new Size(411, 43);
            InvoiceDate.TabIndex = 133;
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
            // UserControlPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvcustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlPayment";
            Size = new Size(1264, 885);
            Load += UserControlPayment_Load;
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

        private Button button3;
        private Button button2;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button btnRefresh;
        private Panel panel1;
        private TextBox tbSaleID;
        private TextBox tbPaymentMethod;
        private Label lbSaleID;
        private Label lbPaymentMethod;
        private Label lbPaymentDate;
        private Label lbAmountPaid;
        private TextBox tbPaymentDate;
        private TextBox tbAmountPaid;
        private Panel panel2;
        private Label lbInvoiceDate;
        private DateTimePicker InvoiceDate;
        private DataGridView dgvcustomer;
    }
}
