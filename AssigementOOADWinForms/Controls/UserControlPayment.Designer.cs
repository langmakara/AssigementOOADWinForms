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
            btnRefresh = new Button();
            panel1 = new Panel();
            tbPaymentID = new TextBox();
            tbPaymentMethod = new TextBox();
            lbSaleID = new Label();
            lbPaymentMethod = new Label();
            lbCustomerName = new Label();
            lbAmountPaid = new Label();
            tbCustomerName = new TextBox();
            tbAmountPaid = new TextBox();
            lbInvoiceDate = new Label();
            dgvPayment = new DataGridView();
            tbPaymentDate = new TextBox();
            tbInvoiceID = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(882, 824);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(382, 60);
            button3.TabIndex = 135;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(880, 750);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(384, 60);
            btnRefresh.TabIndex = 132;
            btnRefresh.Text = "Save";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(tbInvoiceID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbPaymentDate);
            panel1.Controls.Add(lbInvoiceDate);
            panel1.Controls.Add(tbPaymentID);
            panel1.Controls.Add(tbPaymentMethod);
            panel1.Controls.Add(lbSaleID);
            panel1.Controls.Add(lbPaymentMethod);
            panel1.Controls.Add(lbCustomerName);
            panel1.Controls.Add(lbAmountPaid);
            panel1.Controls.Add(tbCustomerName);
            panel1.Controls.Add(tbAmountPaid);
            panel1.Location = new Point(881, 5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 722);
            panel1.TabIndex = 130;
            // 
            // tbPaymentID
            // 
            tbPaymentID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPaymentID.Location = new Point(18, 71);
            tbPaymentID.Margin = new Padding(3, 4, 3, 4);
            tbPaymentID.Multiline = true;
            tbPaymentID.Name = "tbPaymentID";
            tbPaymentID.Size = new Size(346, 48);
            tbPaymentID.TabIndex = 133;
            // 
            // tbPaymentMethod
            // 
            tbPaymentMethod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPaymentMethod.Location = new Point(19, 392);
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
            lbSaleID.Location = new Point(18, 30);
            lbSaleID.Name = "lbSaleID";
            lbSaleID.Size = new Size(135, 35);
            lbSaleID.TabIndex = 129;
            lbSaleID.Text = "PaymentID";
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.BackColor = Color.DodgerBlue;
            lbPaymentMethod.Cursor = Cursors.Hand;
            lbPaymentMethod.Font = new Font("Segoe UI", 15F);
            lbPaymentMethod.ForeColor = Color.White;
            lbPaymentMethod.Location = new Point(16, 351);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(204, 35);
            lbPaymentMethod.TabIndex = 118;
            lbPaymentMethod.Text = "Payment Method";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.BackColor = Color.DodgerBlue;
            lbCustomerName.Cursor = Cursors.Hand;
            lbCustomerName.Font = new Font("Segoe UI", 15F);
            lbCustomerName.ForeColor = Color.White;
            lbCustomerName.Location = new Point(18, 245);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(189, 35);
            lbCustomerName.TabIndex = 122;
            lbCustomerName.Text = "CustomerName";
            // 
            // lbAmountPaid
            // 
            lbAmountPaid.AutoSize = true;
            lbAmountPaid.BackColor = Color.DodgerBlue;
            lbAmountPaid.Cursor = Cursors.Hand;
            lbAmountPaid.Font = new Font("Segoe UI", 15F);
            lbAmountPaid.ForeColor = Color.White;
            lbAmountPaid.Location = new Point(19, 459);
            lbAmountPaid.Name = "lbAmountPaid";
            lbAmountPaid.Size = new Size(158, 35);
            lbAmountPaid.TabIndex = 115;
            lbAmountPaid.Text = "Amount Paid";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbCustomerName.Location = new Point(19, 285);
            tbCustomerName.Margin = new Padding(3, 4, 3, 4);
            tbCustomerName.Multiline = true;
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(345, 48);
            tbCustomerName.TabIndex = 114;
            // 
            // tbAmountPaid
            // 
            tbAmountPaid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbAmountPaid.Location = new Point(19, 500);
            tbAmountPaid.Margin = new Padding(3, 4, 3, 4);
            tbAmountPaid.Multiline = true;
            tbAmountPaid.Name = "tbAmountPaid";
            tbAmountPaid.Size = new Size(346, 48);
            tbAmountPaid.TabIndex = 117;
            // 
            // lbInvoiceDate
            // 
            lbInvoiceDate.AutoSize = true;
            lbInvoiceDate.BackColor = Color.DodgerBlue;
            lbInvoiceDate.Cursor = Cursors.Hand;
            lbInvoiceDate.Font = new Font("Segoe UI", 15F);
            lbInvoiceDate.ForeColor = Color.White;
            lbInvoiceDate.Location = new Point(18, 570);
            lbInvoiceDate.Name = "lbInvoiceDate";
            lbInvoiceDate.Size = new Size(169, 35);
            lbInvoiceDate.TabIndex = 133;
            lbInvoiceDate.Text = "Payment Date";
            // 
            // dgvPayment
            // 
            dgvPayment.BackgroundColor = Color.White;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(3, 5);
            dgvPayment.Margin = new Padding(3, 4, 3, 4);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.Size = new Size(876, 879);
            dgvPayment.TabIndex = 129;
            // 
            // tbPaymentDate
            // 
            tbPaymentDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPaymentDate.Location = new Point(19, 611);
            tbPaymentDate.Margin = new Padding(3, 4, 3, 4);
            tbPaymentDate.Multiline = true;
            tbPaymentDate.Name = "tbPaymentDate";
            tbPaymentDate.Size = new Size(346, 48);
            tbPaymentDate.TabIndex = 134;
            // 
            // tbInvoiceID
            // 
            tbInvoiceID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbInvoiceID.Location = new Point(16, 176);
            tbInvoiceID.Margin = new Padding(3, 4, 3, 4);
            tbInvoiceID.Multiline = true;
            tbInvoiceID.Name = "tbInvoiceID";
            tbInvoiceID.Size = new Size(346, 48);
            tbInvoiceID.TabIndex = 136;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 135);
            label1.Name = "label1";
            label1.Size = new Size(119, 35);
            label1.TabIndex = 135;
            label1.Text = "InvoiceID";
            // 
            // UserControlPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(dgvPayment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlPayment";
            Size = new Size(1264, 885);
            Load += UserControlPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button btnRefresh;
        private Panel panel1;
        private TextBox tbPaymentID;
        private TextBox tbPaymentMethod;
        private Label lbSaleID;
        private Label lbPaymentMethod;
        private Label lbCustomerName;
        private Label lbAmountPaid;
        private TextBox tbCustomerName;
        private TextBox tbAmountPaid;
        private Label lbInvoiceDate;
        private DataGridView dgvPayment;
        private TextBox tbPaymentDate;
        private TextBox tbInvoiceID;
        private Label label1;
    }
}
