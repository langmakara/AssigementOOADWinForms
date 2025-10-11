namespace AssigementOOADWinForms.Controls
{
    partial class UserControlEmployee
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
            btRemove = new Button();
            btSave = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            btClear = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dgvemployee = new DataGridView();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            btInsert = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvemployee).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.Maroon;
            btRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btRemove.FlatAppearance.BorderSize = 0;
            btRemove.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(204, 717);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(180, 49);
            btRemove.TabIndex = 61;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Green;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(29, 717);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(175, 49);
            btSave.TabIndex = 60;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(29, 116);
            label5.Name = "label5";
            label5.Size = new Size(88, 35);
            label5.TabIndex = 59;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(29, 217);
            label4.Name = "label4";
            label4.Size = new Size(141, 35);
            label4.TabIndex = 58;
            label4.Text = "Address     ";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 261);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(355, 48);
            textBox4.TabIndex = 57;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 160);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(355, 48);
            textBox3.TabIndex = 56;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(29, 15);
            label3.Name = "label3";
            label3.Size = new Size(82, 35);
            label3.TabIndex = 55;
            label3.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 59);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 48);
            textBox2.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(295, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 35);
            label2.TabIndex = 52;
            label2.Text = "Possition";
            // 
            // btClear
            // 
            btClear.BackColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btClear.ForeColor = Color.White;
            btClear.Location = new Point(680, 37);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(147, 52);
            btClear.TabIndex = 51;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(15, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 35);
            label1.TabIndex = 50;
            label1.Text = "Employee";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 45);
            textBox1.TabIndex = 49;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(295, 39);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 43);
            comboBox1.TabIndex = 48;
            // 
            // dgvemployee
            // 
            dgvemployee.BackgroundColor = Color.White;
            dgvemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvemployee.Location = new Point(15, 113);
            dgvemployee.Margin = new Padding(3, 4, 3, 4);
            dgvemployee.Name = "dgvemployee";
            dgvemployee.RowHeadersWidth = 51;
            dgvemployee.Size = new Size(812, 755);
            dgvemployee.TabIndex = 47;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(29, 362);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(355, 48);
            textBox5.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(29, 318);
            label6.Name = "label6";
            label6.Size = new Size(133, 35);
            label6.TabIndex = 63;
            label6.Text = "Possition  ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(29, 463);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(355, 48);
            textBox6.TabIndex = 64;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(29, 419);
            label7.Name = "label7";
            label7.Size = new Size(115, 35);
            label7.TabIndex = 65;
            label7.Text = "HireDate";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(29, 520);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 153);
            panel3.TabIndex = 67;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(37, 77);
            label14.Name = "label14";
            label14.Size = new Size(120, 46);
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
            label13.Location = new Point(25, 24);
            label13.Name = "label13";
            label13.Size = new Size(206, 35);
            label13.TabIndex = 27;
            label13.Text = "Total Employees";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_employees_100__1_;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(291, 24);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(34, 40);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // btInsert
            // 
            btInsert.BackColor = Color.DodgerBlue;
            btInsert.FlatAppearance.BorderColor = Color.DodgerBlue;
            btInsert.FlatAppearance.BorderSize = 0;
            btInsert.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btInsert.ForeColor = Color.White;
            btInsert.Location = new Point(29, 766);
            btInsert.Margin = new Padding(0);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(355, 49);
            btInsert.TabIndex = 68;
            btInsert.Text = "Insert";
            btInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btInsert);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(btRemove);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(833, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 852);
            panel1.TabIndex = 69;
            // 
            // UserControlEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btClear);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dgvemployee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlEmployee";
            Size = new Size(1264, 885);
            ((System.ComponentModel.ISupportInitialize)dgvemployee).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRemove;
        private Button btSave;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button btClear;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dgvemployee;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button btInsert;
        private Panel panel1;
    }
}
