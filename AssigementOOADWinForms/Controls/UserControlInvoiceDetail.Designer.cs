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
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dgvcustomer = new DataGridView();
            btnRefresh = new Button();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(803, 202);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 102;
            label2.Text = "ProductID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(803, 499);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 104);
            panel3.TabIndex = 101;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(32, 58);
            label14.Name = "label14";
            label14.Size = new Size(97, 37);
            label14.TabIndex = 28;
            label14.Text = "12000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DodgerBlue;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(16, 18);
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
            pictureBox13.Location = new Point(255, 18);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(30, 30);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(978, 624);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(129, 37);
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
            button1.Location = new Point(803, 624);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(129, 37);
            button1.TabIndex = 99;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(806, 309);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 98;
            label5.Text = "Qauntity";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(803, 443);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 37);
            textBox4.TabIndex = 96;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(803, 340);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(304, 37);
            textBox3.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(803, 412);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 94;
            label3.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(803, 237);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 37);
            textBox2.TabIndex = 93;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dgvcustomer
            // 
            dgvcustomer.BackgroundColor = Color.White;
            dgvcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomer.Location = new Point(3, 77);
            dgvcustomer.Name = "dgvcustomer";
            dgvcustomer.Size = new Size(790, 584);
            dgvcustomer.TabIndex = 90;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(628, 31);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 40);
            btnRefresh.TabIndex = 103;
            btnRefresh.Text = "Clear";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(338, 34);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 37);
            textBox5.TabIndex = 105;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 36);
            comboBox1.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 107;
            label1.Text = "Supplier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(338, 3);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 108;
            label4.Text = "CategoryName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(806, 103);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 110;
            label6.Text = "InvoiceID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(803, 134);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 37);
            textBox1.TabIndex = 109;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(803, 33);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(303, 37);
            textBox6.TabIndex = 111;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(803, 4);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 112;
            label7.Text = "InvoiceDetailID";
            // 
            // UserControlInvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(dgvcustomer);
            Name = "UserControlInvoiceDetail";
            Size = new Size(1111, 664);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dgvcustomer;
        private Button btnRefresh;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Label label1;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label7;
    }
}
