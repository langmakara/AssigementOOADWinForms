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
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            btnRefresh = new Button();
            label2 = new Label();
            panel3 = new Panel();
            label13 = new Label();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dgvInvoice = new DataGridView();
            panel1 = new Panel();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox6 = new TextBox();
            panel2 = new Panel();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox7 = new TextBox();
            panel3.SuspendLayout();
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
            // textBox1
            // 
            textBox1.Location = new Point(788, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 37);
            textBox1.TabIndex = 128;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(210, 3);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 127;
            label4.Text = "EmployeeID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 126;
            label1.Text = "CustomerName";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(210, 34);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 37);
            textBox5.TabIndex = 124;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.DodgerBlue;
            btnRefresh.Location = new Point(945, 573);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(163, 43);
            btnRefresh.TabIndex = 123;
            btnRefresh.Text = "Clear";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 79);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 122;
            label2.Text = "CustomerName";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(773, 478);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 89);
            panel3.TabIndex = 121;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 128, 0);
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(27, 23);
            label13.Name = "label13";
            label13.Size = new Size(285, 37);
            label13.TabIndex = 27;
            label13.Text = "Create Invoice Detail";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(773, 616);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(335, 43);
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
            button1.Location = new Point(773, 573);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(163, 43);
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
            label5.Location = new Point(14, 157);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 118;
            label5.Text = "CustomerPhone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 266);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 37);
            textBox4.TabIndex = 117;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 428);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(304, 37);
            textBox3.TabIndex = 116;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 235);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 115;
            label3.Text = "EmployeeID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 110);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 37);
            textBox2.TabIndex = 114;
            // 
            // dgvInvoice
            // 
            dgvInvoice.BackgroundColor = Color.White;
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(3, 102);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.Size = new Size(768, 557);
            dgvInvoice.TabIndex = 113;
            dgvInvoice.CellContentClick += dgvcustomer_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(773, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 473);
            panel1.TabIndex = 122;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DodgerBlue;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 317);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 132;
            label8.Text = "InvoiceDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker1.Font = new Font("Segoe UI", 16F);
            dateTimePicker1.Location = new Point(15, 348);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 36);
            dateTimePicker1.TabIndex = 129;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DodgerBlue;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 397);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 130;
            label7.Text = "TotalAmount";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 188);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(303, 37);
            textBox6.TabIndex = 131;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 100);
            panel2.TabIndex = 122;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DodgerBlue;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(413, 3);
            label9.Name = "label9";
            label9.Size = new Size(115, 28);
            label9.TabIndex = 133;
            label9.Text = "InvoiceDate";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker2.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker2.Font = new Font("Segoe UI", 16F);
            dateTimePicker2.Location = new Point(413, 34);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(351, 36);
            dateTimePicker2.TabIndex = 133;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 33);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(201, 37);
            textBox7.TabIndex = 132;
            // 
            // UserControlInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvInvoice);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserControlInvoice";
            Size = new Size(1111, 664);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private TextBox textBox5;
        private Button btnRefresh;
        private Label label2;
        private Panel panel3;
        private Label label13;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dgvInvoice;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label9;
    }
}
