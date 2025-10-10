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
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvinventory).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // dgvinventory
            // 
            dgvinventory.BackgroundColor = Color.White;
            dgvinventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventory.Location = new Point(12, 81);
            dgvinventory.Name = "dgvinventory";
            dgvinventory.Size = new Size(649, 572);
            dgvinventory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(667, 7);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 30;
            label1.Text = "Product";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(535, 38);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 37);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Clear";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(667, 114);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 32;
            label2.Text = "TransitionType";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(667, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 36);
            comboBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(667, 227);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 33;
            label3.Text = "QuantityChange";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(667, 258);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 37);
            textBox2.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(667, 334);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 35;
            label4.Text = "ReferenceID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(667, 365);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(304, 37);
            textBox3.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(667, 441);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 115);
            panel3.TabIndex = 102;
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
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Location = new Point(667, 614);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(129, 37);
            button1.TabIndex = 103;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.White;
            button2.Location = new Point(842, 614);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(129, 37);
            button2.TabIndex = 104;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 38);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 37);
            textBox5.TabIndex = 106;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(243, 7);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 107;
            label5.Text = "TransitionData";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 15F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(667, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(304, 36);
            comboBox2.TabIndex = 108;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F);
            dateTimePicker1.Location = new Point(243, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 31);
            dateTimePicker1.TabIndex = 109;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(12, 7);
            label6.Name = "label6";
            label6.Size = new Size(137, 28);
            label6.TabIndex = 110;
            label6.Text = "TransitionData";
            // 
            // UserControlInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(dgvinventory);
            Controls.Add(comboBox1);
            Name = "UserControlInventory";
            Size = new Size(984, 668);
            ((System.ComponentModel.ISupportInitialize)dgvinventory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvinventory;
        private Label label1;
        private Button btnRefresh;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button button1;
        private Button button2;
        private TextBox textBox5;
        private Label label5;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}
