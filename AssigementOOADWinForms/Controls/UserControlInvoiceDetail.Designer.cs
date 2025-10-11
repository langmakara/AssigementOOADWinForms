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
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dgvInvoicedetail = new DataGridView();
            btnRefresh = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoicedetail).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 195);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 102;
            label2.Text = "ProductID";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(787, 620);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(321, 42);
            button2.TabIndex = 100;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(787, 572);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(157, 48);
            button1.TabIndex = 99;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 287);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 98;
            label5.Text = "Qauntity";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(11, 418);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 37);
            textBox4.TabIndex = 96;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(797, 323);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 37);
            textBox3.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 387);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 94;
            label3.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(517, 33);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 37);
            textBox2.TabIndex = 93;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dgvInvoicedetail
            // 
            dgvInvoicedetail.BackgroundColor = Color.White;
            dgvInvoicedetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoicedetail.Location = new Point(3, 104);
            dgvInvoicedetail.Name = "dgvInvoicedetail";
            dgvInvoicedetail.Size = new Size(780, 558);
            dgvInvoicedetail.TabIndex = 90;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.DodgerBlue;
            btnRefresh.Location = new Point(951, 572);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(157, 48);
            btnRefresh.TabIndex = 103;
            btnRefresh.Text = "Clear";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(11, 97);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 110;
            label6.Text = "InvoiceID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(797, 131);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 37);
            textBox1.TabIndex = 109;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(797, 35);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(296, 37);
            textBox6.TabIndex = 111;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 1);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 112;
            label7.Text = "InvoiceDetailID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(786, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 475);
            panel1.TabIndex = 102;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(10, 226);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(303, 37);
            textBox5.TabIndex = 113;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(787, 480);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 89);
            panel3.TabIndex = 122;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(18, 35);
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
            label13.Location = new Point(14, 4);
            label13.Name = "label13";
            label13.Size = new Size(166, 28);
            label13.TabIndex = 27;
            label13.Text = "Total Employees";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_employees_100__1_;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(277, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(30, 30);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 100);
            panel2.TabIndex = 123;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(520, 2);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 133;
            label1.Text = "ProductPrice";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 33);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(242, 37);
            textBox7.TabIndex = 132;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(255, 33);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(256, 37);
            textBox8.TabIndex = 124;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 2);
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
            // UserControlInvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(dgvInvoicedetail);
            Controls.Add(panel1);
            Name = "UserControlInvoiceDetail";
            Size = new Size(1111, 664);
            ((System.ComponentModel.ISupportInitialize)dgvInvoicedetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dgvInvoicedetail;
        private Button btnRefresh;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label7;
        private Panel panel1;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Panel panel2;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label10;
        private TextBox textBox5;
        private Label label1;
    }
}
