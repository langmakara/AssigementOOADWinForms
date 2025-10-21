namespace AssigementOOADWinForms.Controls
{
    partial class UserControlProduct
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
            dgvcustomer = new DataGridView();
            panel1 = new Panel();
            tbUnitPrice = new TextBox();
            tbProductID = new TextBox();
            lbUnitPrice = new Label();
            lbQauntity = new Label();
            tbCategory = new TextBox();
            label6 = new Label();
            label5 = new Label();
            lbProductName = new Label();
            lbSupplier = new Label();
            tbQauntity = new TextBox();
            tbProductName = new TextBox();
            tbSupplier = new TextBox();
            panel2 = new Panel();
            tbSeach = new TextBox();
            lbSeach = new Label();
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            btSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // dgvcustomer
            // 
            dgvcustomer.BackgroundColor = Color.White;
            dgvcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomer.Location = new Point(4, 123);
            dgvcustomer.Margin = new Padding(3, 4, 3, 4);
            dgvcustomer.Name = "dgvcustomer";
            dgvcustomer.RowHeadersWidth = 51;
            dgvcustomer.Size = new Size(873, 763);
            dgvcustomer.TabIndex = 116;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(tbUnitPrice);
            panel1.Controls.Add(tbProductID);
            panel1.Controls.Add(lbUnitPrice);
            panel1.Controls.Add(lbQauntity);
            panel1.Controls.Add(tbCategory);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbProductName);
            panel1.Controls.Add(lbSupplier);
            panel1.Controls.Add(tbQauntity);
            panel1.Controls.Add(tbProductName);
            panel1.Controls.Add(tbSupplier);
            panel1.Location = new Point(881, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 632);
            panel1.TabIndex = 123;
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbUnitPrice.Location = new Point(19, 426);
            tbUnitPrice.Margin = new Padding(3, 4, 3, 4);
            tbUnitPrice.Multiline = true;
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(346, 48);
            tbUnitPrice.TabIndex = 134;
            // 
            // tbProductID
            // 
            tbProductID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbProductID.Location = new Point(19, 45);
            tbProductID.Margin = new Padding(3, 4, 3, 4);
            tbProductID.Multiline = true;
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(346, 48);
            tbProductID.TabIndex = 133;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.BackColor = Color.DodgerBlue;
            lbUnitPrice.Cursor = Cursors.Hand;
            lbUnitPrice.Font = new Font("Segoe UI", 15F);
            lbUnitPrice.ForeColor = Color.White;
            lbUnitPrice.Location = new Point(15, 388);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(114, 35);
            lbUnitPrice.TabIndex = 132;
            lbUnitPrice.Text = "UnitPrice";
            // 
            // lbQauntity
            // 
            lbQauntity.AutoSize = true;
            lbQauntity.BackColor = Color.DodgerBlue;
            lbQauntity.Cursor = Cursors.Hand;
            lbQauntity.Font = new Font("Segoe UI", 15F);
            lbQauntity.ForeColor = Color.White;
            lbQauntity.Location = new Point(15, 487);
            lbQauntity.Name = "lbQauntity";
            lbQauntity.Size = new Size(109, 35);
            lbQauntity.TabIndex = 130;
            lbQauntity.Text = "Qauntity";
            // 
            // tbCategory
            // 
            tbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbCategory.Location = new Point(19, 237);
            tbCategory.Margin = new Padding(3, 4, 3, 4);
            tbCategory.Multiline = true;
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(346, 48);
            tbCategory.TabIndex = 131;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DodgerBlue;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 5);
            label6.Name = "label6";
            label6.Size = new Size(134, 35);
            label6.TabIndex = 129;
            label6.Text = "Product ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DodgerBlue;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 199);
            label5.Name = "label5";
            label5.Size = new Size(115, 35);
            label5.TabIndex = 118;
            label5.Text = "Category";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.BackColor = Color.DodgerBlue;
            lbProductName.Cursor = Cursors.Hand;
            lbProductName.Font = new Font("Segoe UI", 15F);
            lbProductName.ForeColor = Color.White;
            lbProductName.Location = new Point(19, 103);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(176, 35);
            lbProductName.TabIndex = 122;
            lbProductName.Text = "Product Name";
            // 
            // lbSupplier
            // 
            lbSupplier.AutoSize = true;
            lbSupplier.BackColor = Color.DodgerBlue;
            lbSupplier.Cursor = Cursors.Hand;
            lbSupplier.Font = new Font("Segoe UI", 15F);
            lbSupplier.ForeColor = Color.White;
            lbSupplier.Location = new Point(18, 291);
            lbSupplier.Name = "lbSupplier";
            lbSupplier.Size = new Size(106, 35);
            lbSupplier.TabIndex = 115;
            lbSupplier.Text = "Supplier";
            // 
            // tbQauntity
            // 
            tbQauntity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbQauntity.Location = new Point(18, 526);
            tbQauntity.Margin = new Padding(3, 4, 3, 4);
            tbQauntity.Multiline = true;
            tbQauntity.Name = "tbQauntity";
            tbQauntity.Size = new Size(347, 48);
            tbQauntity.TabIndex = 116;
            // 
            // tbProductName
            // 
            tbProductName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbProductName.Location = new Point(19, 141);
            tbProductName.Margin = new Padding(3, 4, 3, 4);
            tbProductName.Multiline = true;
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(346, 48);
            tbProductName.TabIndex = 114;
            // 
            // tbSupplier
            // 
            tbSupplier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSupplier.Location = new Point(19, 332);
            tbSupplier.Margin = new Padding(3, 4, 3, 4);
            tbSupplier.Multiline = true;
            tbSupplier.Name = "tbSupplier";
            tbSupplier.Size = new Size(346, 48);
            tbSupplier.TabIndex = 117;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(tbSeach);
            panel2.Controls.Add(lbSeach);
            panel2.Location = new Point(3, 3);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 112);
            panel2.TabIndex = 124;
            // 
            // tbSeach
            // 
            tbSeach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSeach.Location = new Point(24, 32);
            tbSeach.Margin = new Padding(3, 4, 3, 4);
            tbSeach.Multiline = true;
            tbSeach.Name = "tbSeach";
            tbSeach.Size = new Size(486, 43);
            tbSeach.TabIndex = 132;
            // 
            // lbSeach
            // 
            lbSeach.AutoSize = true;
            lbSeach.BackColor = Color.White;
            lbSeach.Cursor = Cursors.Hand;
            lbSeach.Font = new Font("Segoe UI", 15F);
            lbSeach.ForeColor = Color.Gray;
            lbSeach.Location = new Point(531, 32);
            lbSeach.Name = "lbSeach";
            lbSeach.Padding = new Padding(0, 4, 0, 3);
            lbSeach.Size = new Size(274, 42);
            lbSeach.TabIndex = 126;
            lbSeach.Text = "Seach By NameProduct";
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1074, 766);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(189, 60);
            button3.TabIndex = 128;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.Gray;
            button2.Location = new Point(880, 824);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(383, 60);
            button2.TabIndex = 127;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(881, 643);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 120);
            panel3.TabIndex = 126;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(30, 53);
            label14.Name = "label14";
            label14.Size = new Size(120, 46);
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
            label13.Location = new Point(13, 16);
            label13.Name = "label13";
            label13.Size = new Size(268, 35);
            label13.TabIndex = 27;
            label13.Text = "Transation Per Month";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_employees_100__1_;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(322, 13);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(34, 40);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(880, 766);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(207, 60);
            btSave.TabIndex = 125;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // UserControlProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(btSave);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvcustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlProduct";
            Size = new Size(1264, 885);
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvcustomer;
        private Panel panel1;
        private Label lbUnitPrice;
        private Label lbQauntity;
        private TextBox tbCategory;
        private Label label6;
        private Label label5;
        private Label lbProductName;
        private Label lbSupplier;
        private TextBox tbQauntity;
        private TextBox tbProductName;
        private TextBox tbSupplier;
        private Panel panel2;
        private TextBox tbSeach;
        private Label lbSeach;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox13;
        private Button btSave;
        private TextBox tbProductID;
        private TextBox tbUnitPrice;
    }
}
