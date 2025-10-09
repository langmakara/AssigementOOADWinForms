namespace AssigementOOADWinForms.Controls
{
    partial class UserControlCategory
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
            label2.Location = new Point(657, 52);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 102;
            label2.Text = "Sale";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(657, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 115);
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
            button2.Location = new Point(832, 622);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(129, 37);
            button2.TabIndex = 100;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(657, 621);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(129, 37);
            button1.TabIndex = 99;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(657, 124);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 98;
            label5.Text = "Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(657, 229);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(304, 37);
            textBox4.TabIndex = 96;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(657, 156);
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
            label3.Location = new Point(657, 198);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 94;
            label3.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(657, 83);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 37);
            textBox2.TabIndex = 93;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dgvcustomer
            // 
            dgvcustomer.BackgroundColor = Color.White;
            dgvcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomer.Location = new Point(13, 83);
            dgvcustomer.Name = "dgvcustomer";
            dgvcustomer.Size = new Size(612, 576);
            dgvcustomer.TabIndex = 90;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Location = new Point(461, 42);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 37);
            btnRefresh.TabIndex = 103;
            btnRefresh.Text = "Add User";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // UserControlCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
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
            Name = "UserControlCategory";
            Size = new Size(984, 668);
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
    }
}
