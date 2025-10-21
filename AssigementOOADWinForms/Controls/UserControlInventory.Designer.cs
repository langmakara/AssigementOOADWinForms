namespace AssigementOOADWinForms.Controls
{
    partial class UserControlInventory
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
            dgvinventory = new DataGridView();
            label1 = new Label();
            btnRefresh = new Button();
            label2 = new Label();
            comboTransaction = new ComboBox();
            label3 = new Label();
            textQuantityChange = new TextBox();
            textUnitPrice = new TextBox();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            button2 = new Button();
            comboProduct = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            datetimeTransactionDate = new DateTimePicker();
            panel2 = new Panel();
            label5 = new Label();
            dateTimeSearchStart = new DateTimePicker();
            comboSearchByProduct = new ComboBox();
            label9 = new Label();
            dateTimeSearchEnd = new DateTimePicker();
            textsearchBycustomerName = new TextBox();
            label8 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvinventory).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvinventory
            // 
            dgvinventory.BackgroundColor = Color.White;
            dgvinventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventory.Location = new Point(3, 105);
            dgvinventory.Name = "dgvinventory";
            dgvinventory.Size = new Size(783, 556);
            dgvinventory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 1);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 30;
            label1.Text = "ProductID";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(788, 575);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(165, 45);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Save";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 96);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 32;
            label2.Text = "TransitionType";
            // 
            // comboTransaction
            // 
            comboTransaction.Font = new Font("Segoe UI", 15F);
            comboTransaction.FormattingEnabled = true;
            comboTransaction.Location = new Point(800, 129);
            comboTransaction.Name = "comboTransaction";
            comboTransaction.Size = new Size(304, 36);
            comboTransaction.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 193);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 33;
            label3.Text = "QuantityChange";
            // 
            // textQuantityChange
            // 
            textQuantityChange.Location = new Point(800, 226);
            textQuantityChange.Multiline = true;
            textQuantityChange.Name = "textQuantityChange";
            textQuantityChange.Size = new Size(304, 37);
            textQuantityChange.TabIndex = 34;
            // 
            // textUnitPrice
            // 
            textUnitPrice.Location = new Point(800, 324);
            textUnitPrice.Multiline = true;
            textUnitPrice.Name = "textUnitPrice";
            textUnitPrice.Size = new Size(304, 37);
            textUnitPrice.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(789, 483);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 90);
            panel3.TabIndex = 102;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(26, 40);
            label14.Name = "label14";
            label14.Size = new Size(97, 37);
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
            label13.Location = new Point(11, 12);
            label13.Name = "label13";
            label13.Size = new Size(216, 28);
            label13.TabIndex = 27;
            label13.Text = "Transation Per Month";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_employees_100__1_;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(282, 10);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(30, 30);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(788, 619);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(319, 45);
            button2.TabIndex = 104;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboProduct
            // 
            comboProduct.Font = new Font("Segoe UI", 15F);
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new Point(797, 32);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(304, 36);
            comboProduct.TabIndex = 108;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 291);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 111;
            label7.Text = "UnitPrice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 389);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 113;
            label4.Text = "TransactionDate";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(958, 575);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 114;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(datetimeTransactionDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(789, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 478);
            panel1.TabIndex = 103;
            // 
            // datetimeTransactionDate
            // 
            datetimeTransactionDate.CalendarForeColor = Color.FromArgb(64, 64, 64);
            datetimeTransactionDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            datetimeTransactionDate.Font = new Font("Segoe UI", 15F);
            datetimeTransactionDate.Location = new Point(11, 420);
            datetimeTransactionDate.Name = "datetimeTransactionDate";
            datetimeTransactionDate.Size = new Size(304, 34);
            datetimeTransactionDate.TabIndex = 130;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimeSearchStart);
            panel2.Controls.Add(comboSearchByProduct);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dateTimeSearchEnd);
            panel2.Controls.Add(textsearchBycustomerName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 100);
            panel2.TabIndex = 123;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DodgerBlue;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(398, 3);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 135;
            label5.Text = "StartInvoiceDate";
            // 
            // dateTimeSearchStart
            // 
            dateTimeSearchStart.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateTimeSearchStart.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dateTimeSearchStart.Checked = false;
            dateTimeSearchStart.Font = new Font("Segoe UI", 16F);
            dateTimeSearchStart.Location = new Point(398, 34);
            dateTimeSearchStart.Name = "dateTimeSearchStart";
            dateTimeSearchStart.ShowCheckBox = true;
            dateTimeSearchStart.Size = new Size(198, 36);
            dateTimeSearchStart.TabIndex = 134;
            // 
            // comboSearchByProduct
            // 
            comboSearchByProduct.Font = new Font("Segoe UI", 15F);
            comboSearchByProduct.FormattingEnabled = true;
            comboSearchByProduct.Location = new Point(192, 34);
            comboSearchByProduct.Name = "comboSearchByProduct";
            comboSearchByProduct.Size = new Size(201, 36);
            comboSearchByProduct.TabIndex = 124;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DodgerBlue;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(602, 3);
            label9.Name = "label9";
            label9.Size = new Size(148, 28);
            label9.TabIndex = 133;
            label9.Text = "EndInvoiceDate";
            // 
            // dateTimeSearchEnd
            // 
            dateTimeSearchEnd.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateTimeSearchEnd.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dateTimeSearchEnd.Checked = false;
            dateTimeSearchEnd.Font = new Font("Segoe UI", 16F);
            dateTimeSearchEnd.Location = new Point(602, 34);
            dateTimeSearchEnd.Name = "dateTimeSearchEnd";
            dateTimeSearchEnd.ShowCheckBox = true;
            dateTimeSearchEnd.Size = new Size(178, 36);
            dateTimeSearchEnd.TabIndex = 133;
            // 
            // textsearchBycustomerName
            // 
            textsearchBycustomerName.Location = new Point(6, 34);
            textsearchBycustomerName.Multiline = true;
            textsearchBycustomerName.Name = "textsearchBycustomerName";
            textsearchBycustomerName.Size = new Size(180, 37);
            textsearchBycustomerName.TabIndex = 132;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 3);
            label8.Name = "label8";
            label8.Size = new Size(148, 28);
            label8.TabIndex = 126;
            label8.Text = "CustomerName";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI", 15F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(192, 3);
            label10.Name = "label10";
            label10.Size = new Size(89, 28);
            label10.TabIndex = 127;
            label10.Text = "Products";
            // 
            // UserControlInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(comboProduct);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(textUnitPrice);
            Controls.Add(textQuantityChange);
            Controls.Add(btnRefresh);
            Controls.Add(dgvinventory);
            Controls.Add(comboTransaction);
            Controls.Add(panel1);
            Name = "UserControlInventory";
            Size = new Size(1111, 664);
            ((System.ComponentModel.ISupportInitialize)dgvinventory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvinventory;
        private Label label1;
        private Button btnRefresh;
        private Label label2;
        private ComboBox comboTransaction;
        private Label label3;
        private TextBox textQuantityChange;
        private TextBox textUnitPrice;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button button2;
        private ComboBox comboProduct;
        private Label label7;
        private Label label4;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private DateTimePicker dateTimeSearchEnd;
        private TextBox textsearchBycustomerName;
        private Label label8;
        private Label label10;
        private DateTimePicker datetimeTransactionDate;
        private ComboBox comboSearchByProduct;
        private DateTimePicker dateTimeSearchStart;
        private Label label5;
    }
}
