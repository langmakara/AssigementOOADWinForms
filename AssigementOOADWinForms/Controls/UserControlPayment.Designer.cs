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
            btnSave = new Button();
            panel1 = new Panel();
            dtpPaymentDate = new DateTimePicker();
            tbInvoiceID = new TextBox();
            label1 = new Label();
            lbInvoiceDate = new Label();
            tbPaymentID = new TextBox();
            tbPaymentMethod = new TextBox();
            lbSaleID = new Label();
            lbPaymentMethod = new Label();
            lbAmountPaid = new Label();
            tbAmountPaid = new TextBox();
            dgvPayment = new DataGridView();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            cbPaymentMethod = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(883, 739);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(381, 60);
            button3.TabIndex = 135;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(882, 676);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(382, 60);
            btnSave.TabIndex = 132;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(dtpPaymentDate);
            panel1.Controls.Add(tbInvoiceID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbInvoiceDate);
            panel1.Controls.Add(tbPaymentID);
            panel1.Controls.Add(tbPaymentMethod);
            panel1.Controls.Add(lbSaleID);
            panel1.Controls.Add(lbPaymentMethod);
            panel1.Controls.Add(lbAmountPaid);
            panel1.Controls.Add(tbAmountPaid);
            panel1.Location = new Point(881, 5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 619);
            panel1.TabIndex = 130;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(19, 503);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(343, 47);
            dtpPaymentDate.TabIndex = 137;
            // 
            // tbInvoiceID
            // 
            tbInvoiceID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbInvoiceID.Location = new Point(18, 176);
            tbInvoiceID.Margin = new Padding(3, 4, 3, 4);
            tbInvoiceID.Multiline = true;
            tbInvoiceID.Name = "tbInvoiceID";
            tbInvoiceID.Size = new Size(344, 48);
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
            // lbInvoiceDate
            // 
            lbInvoiceDate.AutoSize = true;
            lbInvoiceDate.BackColor = Color.DodgerBlue;
            lbInvoiceDate.Cursor = Cursors.Hand;
            lbInvoiceDate.Font = new Font("Segoe UI", 15F);
            lbInvoiceDate.ForeColor = Color.White;
            lbInvoiceDate.Location = new Point(18, 463);
            lbInvoiceDate.Name = "lbInvoiceDate";
            lbInvoiceDate.Size = new Size(169, 35);
            lbInvoiceDate.TabIndex = 133;
            lbInvoiceDate.Text = "Payment Date";
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
            tbPaymentMethod.Location = new Point(19, 285);
            tbPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            tbPaymentMethod.Multiline = true;
            tbPaymentMethod.Name = "tbPaymentMethod";
            tbPaymentMethod.Size = new Size(343, 48);
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
            lbSaleID.Size = new Size(325, 35);
            lbSaleID.TabIndex = 129;
            lbSaleID.Text = "PaymentID(Auto Incements)";
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.BackColor = Color.DodgerBlue;
            lbPaymentMethod.Cursor = Cursors.Hand;
            lbPaymentMethod.Font = new Font("Segoe UI", 15F);
            lbPaymentMethod.ForeColor = Color.White;
            lbPaymentMethod.Location = new Point(16, 244);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(204, 35);
            lbPaymentMethod.TabIndex = 118;
            lbPaymentMethod.Text = "Payment Method";
            // 
            // lbAmountPaid
            // 
            lbAmountPaid.AutoSize = true;
            lbAmountPaid.BackColor = Color.DodgerBlue;
            lbAmountPaid.Cursor = Cursors.Hand;
            lbAmountPaid.Font = new Font("Segoe UI", 15F);
            lbAmountPaid.ForeColor = Color.White;
            lbAmountPaid.Location = new Point(19, 352);
            lbAmountPaid.Name = "lbAmountPaid";
            lbAmountPaid.Size = new Size(158, 35);
            lbAmountPaid.TabIndex = 115;
            lbAmountPaid.Text = "Amount Paid";
            // 
            // tbAmountPaid
            // 
            tbAmountPaid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbAmountPaid.Location = new Point(19, 393);
            tbAmountPaid.Margin = new Padding(3, 4, 3, 4);
            tbAmountPaid.Multiline = true;
            tbAmountPaid.Name = "tbAmountPaid";
            tbAmountPaid.Size = new Size(343, 48);
            tbAmountPaid.TabIndex = 117;
            // 
            // dgvPayment
            // 
            dgvPayment.BackgroundColor = Color.White;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(3, 95);
            dgvPayment.Margin = new Padding(3, 4, 3, 4);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.Size = new Size(876, 789);
            dgvPayment.TabIndex = 129;
            dgvPayment.CellClick += dgvPayment_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(978, 839);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 138;
            label2.Text = "Policy of @2025-2026";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cbPaymentMethod);
            panel2.Location = new Point(3, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 83);
            panel2.TabIndex = 139;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(212, 38);
            label3.TabIndex = 1;
            label3.Text = "PaymentMehod";
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(235, 22);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(210, 39);
            cbPaymentMethod.TabIndex = 0;
            // 
            // UserControlPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(dgvPayment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlPayment";
            Size = new Size(1264, 885);
            Load += UserControlPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button btnSave;
        private Panel panel1;
        private TextBox tbPaymentID;
        private TextBox tbPaymentMethod;
        private Label lbSaleID;
        private Label lbPaymentMethod;
        private Label lbAmountPaid;
        private TextBox tbAmountPaid;
        private Label lbInvoiceDate;
        private DataGridView dgvPayment;
        private TextBox tbInvoiceID;
        private Label label1;
        private DateTimePicker dtpPaymentDate;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private ComboBox cbPaymentMethod;
    }
}
