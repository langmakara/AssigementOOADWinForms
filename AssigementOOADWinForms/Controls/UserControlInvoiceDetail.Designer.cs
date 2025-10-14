namespace AssigementOOADWinForms.Controls
{
    partial class UserControlInvoiceDetail
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
            label2 = new Label();
            btnRemove = new Button();
            btnSave = new Button();
            label5 = new Label();
            textPrice = new TextBox();
            textQauntity = new TextBox();
            label3 = new Label();
            dgvInvoicedetail = new DataGridView();
            btnClear = new Button();
            label6 = new Label();
            textInvoiceID = new TextBox();
            textInvoiceDetailID = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            comboProduct = new ComboBox();
            label1 = new Label();
            textTotalPrice = new TextBox();
            panel2 = new Panel();
            searchProduct = new ComboBox();
            btnReport = new Button();
            searchInvoiceID = new TextBox();
            label8 = new Label();
            label10 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoicedetail).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 178);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 102;
            label2.Text = "ProductID";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 0);
            btnRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(823, 620);
            btnRemove.Margin = new Padding(0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(285, 42);
            btnRemove.TabIndex = 100;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(823, 572);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 48);
            btnSave.TabIndex = 99;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 266);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 98;
            label5.Text = "Qauntity";
            // 
            // textPrice
            // 
            textPrice.Font = new Font("Segoe UI", 15F);
            textPrice.ForeColor = Color.FromArgb(64, 64, 64);
            textPrice.Location = new Point(16, 385);
            textPrice.Multiline = true;
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(257, 37);
            textPrice.TabIndex = 96;
            // 
            // textQauntity
            // 
            textQauntity.Font = new Font("Segoe UI", 15F);
            textQauntity.ForeColor = Color.FromArgb(64, 64, 64);
            textQauntity.Location = new Point(15, 297);
            textQauntity.Multiline = true;
            textQauntity.Name = "textQauntity";
            textQauntity.Size = new Size(258, 37);
            textQauntity.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 354);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 94;
            label3.Text = "Price";
            // 
            // dgvInvoicedetail
            // 
            dgvInvoicedetail.BackgroundColor = Color.White;
            dgvInvoicedetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoicedetail.Location = new Point(3, 104);
            dgvInvoicedetail.Name = "dgvInvoicedetail";
            dgvInvoicedetail.Size = new Size(817, 558);
            dgvInvoicedetail.TabIndex = 90;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.DodgerBlue;
            btnClear.Location = new Point(972, 572);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 48);
            btnClear.TabIndex = 103;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 90);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 110;
            label6.Text = "InvoiceID";
            // 
            // textInvoiceID
            // 
            textInvoiceID.Font = new Font("Segoe UI", 15F);
            textInvoiceID.ForeColor = Color.FromArgb(64, 64, 64);
            textInvoiceID.Location = new Point(16, 121);
            textInvoiceID.Multiline = true;
            textInvoiceID.Name = "textInvoiceID";
            textInvoiceID.Size = new Size(257, 37);
            textInvoiceID.TabIndex = 109;
            // 
            // textInvoiceDetailID
            // 
            textInvoiceDetailID.Font = new Font("Segoe UI", 15F);
            textInvoiceDetailID.ForeColor = Color.FromArgb(64, 64, 64);
            textInvoiceDetailID.Location = new Point(16, 33);
            textInvoiceDetailID.Multiline = true;
            textInvoiceDetailID.Name = "textInvoiceDetailID";
            textInvoiceDetailID.Size = new Size(257, 37);
            textInvoiceDetailID.TabIndex = 111;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 1);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 112;
            label7.Text = "InvoiceDetailID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(comboProduct);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textTotalPrice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textInvoiceDetailID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textInvoiceID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textPrice);
            panel1.Controls.Add(textQauntity);
            panel1.Location = new Point(822, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 525);
            panel1.TabIndex = 102;
            // 
            // comboProduct
            // 
            comboProduct.Font = new Font("Segoe UI", 15F);
            comboProduct.ForeColor = Color.FromArgb(64, 64, 64);
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new Point(17, 209);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(256, 36);
            comboProduct.TabIndex = 135;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 442);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 115;
            label1.Text = "TotalPrice";
            // 
            // textTotalPrice
            // 
            textTotalPrice.Font = new Font("Segoe UI", 15F);
            textTotalPrice.ForeColor = Color.FromArgb(64, 64, 64);
            textTotalPrice.Location = new Point(15, 473);
            textTotalPrice.Multiline = true;
            textTotalPrice.Name = "textTotalPrice";
            textTotalPrice.Size = new Size(257, 37);
            textTotalPrice.TabIndex = 114;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(searchProduct);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(searchInvoiceID);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 95);
            panel2.TabIndex = 123;
            // 
            // searchProduct
            // 
            searchProduct.Font = new Font("Segoe UI", 15F);
            searchProduct.ForeColor = Color.FromArgb(64, 64, 64);
            searchProduct.FormattingEnabled = true;
            searchProduct.Location = new Point(259, 34);
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(256, 36);
            searchProduct.TabIndex = 136;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(255, 128, 0);
            btnReport.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(524, 33);
            btnReport.Margin = new Padding(0);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(285, 37);
            btnReport.TabIndex = 125;
            btnReport.Text = "Look For The Report Invoice";
            btnReport.UseVisualStyleBackColor = false;
            // 
            // searchInvoiceID
            // 
            searchInvoiceID.Font = new Font("Segoe UI", 15F);
            searchInvoiceID.ForeColor = Color.FromArgb(64, 64, 64);
            searchInvoiceID.Location = new Point(13, 33);
            searchInvoiceID.Multiline = true;
            searchInvoiceID.Name = "searchInvoiceID";
            searchInvoiceID.Size = new Size(242, 37);
            searchInvoiceID.TabIndex = 132;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(16, 2);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 126;
            label8.Text = "InvoiceID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI", 15F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(258, 2);
            label10.Name = "label10";
            label10.Size = new Size(100, 28);
            label10.TabIndex = 127;
            label10.Text = "ProductID";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 0);
            btnBack.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(822, 531);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(285, 42);
            btnBack.TabIndex = 124;
            btnBack.Text = "Get Back To Invoice";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // UserControlInvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnSave);
            Controls.Add(dgvInvoicedetail);
            Controls.Add(panel1);
            Name = "UserControlInvoiceDetail";
            Size = new Size(1111, 664);
            ((System.ComponentModel.ISupportInitialize)dgvInvoicedetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button btnRemove;
        private Button btnSave;
        private Label label5;
        private TextBox textPrice;
        private TextBox textQauntity;
        private Label label3;
        private DataGridView dgvInvoicedetail;
        private Button btnClear;
        private Label label6;
        private TextBox textInvoiceID;
        private TextBox textInvoiceDetailID;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private TextBox searchInvoiceID;
        private Label label8;
        private Button btnBack;
        private Button btnReport;
        private Label label10;
        private Label label1;
        private TextBox textTotalPrice;
        private ComboBox comboProduct;
        private ComboBox searchProduct;
    }
}
