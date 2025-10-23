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
            dgvProduct = new DataGridView();
            panel1 = new Panel();
            tbProductID = new TextBox();
            tbUnitPrice = new TextBox();
            lbUnitPrice = new Label();
            lbQauntity = new Label();
            tbSupplierID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            lbProductName = new Label();
            lbSupplier = new Label();
            tbQuantity = new TextBox();
            tbProductName = new TextBox();
            tbSupplierName = new TextBox();
            panel2 = new Panel();
            tbSeach = new TextBox();
            lbSeach = new Label();
            button3 = new Button();
            btSave = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(4, 123);
            dgvProduct.Margin = new Padding(3, 4, 3, 4);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(875, 758);
            dgvProduct.TabIndex = 116;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(tbProductID);
            panel1.Controls.Add(tbUnitPrice);
            panel1.Controls.Add(lbUnitPrice);
            panel1.Controls.Add(lbQauntity);
            panel1.Controls.Add(tbSupplierID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbProductName);
            panel1.Controls.Add(lbSupplier);
            panel1.Controls.Add(tbQuantity);
            panel1.Controls.Add(tbProductName);
            panel1.Controls.Add(tbSupplierName);
            panel1.Location = new Point(881, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 655);
            panel1.TabIndex = 123;
            // 
            // tbProductID
            // 
            tbProductID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbProductID.Location = new Point(16, 73);
            tbProductID.Margin = new Padding(3, 4, 3, 4);
            tbProductID.Multiline = true;
            tbProductID.Name = "tbProductID";
            tbProductID.ReadOnly = true;
            tbProductID.Size = new Size(346, 48);
            tbProductID.TabIndex = 135;
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbUnitPrice.Location = new Point(20, 459);
            tbUnitPrice.Margin = new Padding(3, 4, 3, 4);
            tbUnitPrice.Multiline = true;
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(346, 48);
            tbUnitPrice.TabIndex = 134;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.BackColor = Color.DodgerBlue;
            lbUnitPrice.Cursor = Cursors.Hand;
            lbUnitPrice.Font = new Font("Segoe UI", 15F);
            lbUnitPrice.ForeColor = Color.White;
            lbUnitPrice.Location = new Point(16, 421);
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
            lbQauntity.Location = new Point(16, 512);
            lbQauntity.Name = "lbQauntity";
            lbQauntity.Size = new Size(109, 35);
            lbQauntity.TabIndex = 130;
            lbQauntity.Text = "Qauntity";
            // 
            // tbSupplierID
            // 
            tbSupplierID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSupplierID.Location = new Point(20, 269);
            tbSupplierID.Margin = new Padding(3, 4, 3, 4);
            tbSupplierID.Multiline = true;
            tbSupplierID.Name = "tbSupplierID";
            tbSupplierID.Size = new Size(346, 48);
            tbSupplierID.TabIndex = 131;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DodgerBlue;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 34);
            label6.Name = "label6";
            label6.Size = new Size(322, 35);
            label6.TabIndex = 129;
            label6.Text = "Product ID(Auto Increment)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DodgerBlue;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 231);
            label5.Name = "label5";
            label5.Size = new Size(131, 35);
            label5.TabIndex = 118;
            label5.Text = "SupplierID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.BackColor = Color.DodgerBlue;
            lbProductName.Cursor = Cursors.Hand;
            lbProductName.Font = new Font("Segoe UI", 15F);
            lbProductName.ForeColor = Color.White;
            lbProductName.Location = new Point(16, 135);
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
            lbSupplier.Location = new Point(19, 324);
            lbSupplier.Name = "lbSupplier";
            lbSupplier.Size = new Size(173, 35);
            lbSupplier.TabIndex = 115;
            lbSupplier.Text = "SupplierName";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbQuantity.Location = new Point(19, 551);
            tbQuantity.Margin = new Padding(3, 4, 3, 4);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(347, 48);
            tbQuantity.TabIndex = 116;
            // 
            // tbProductName
            // 
            tbProductName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbProductName.Location = new Point(16, 173);
            tbProductName.Margin = new Padding(3, 4, 3, 4);
            tbProductName.Multiline = true;
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(346, 48);
            tbProductName.TabIndex = 114;
            // 
            // tbSupplierName
            // 
            tbSupplierName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSupplierName.Location = new Point(20, 365);
            tbSupplierName.Margin = new Padding(3, 4, 3, 4);
            tbSupplierName.Multiline = true;
            tbSupplierName.Name = "tbSupplierName";
            tbSupplierName.Size = new Size(346, 48);
            tbSupplierName.TabIndex = 117;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(tbSeach);
            panel2.Controls.Add(lbSeach);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 111);
            panel2.TabIndex = 124;
            // 
            // tbSeach
            // 
            tbSeach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSeach.Location = new Point(31, 32);
            tbSeach.Margin = new Padding(3, 4, 3, 4);
            tbSeach.Multiline = true;
            tbSeach.Name = "tbSeach";
            tbSeach.Size = new Size(518, 43);
            tbSeach.TabIndex = 132;
            tbSeach.TextChanged += tbSeach_TextChanged;
            // 
            // lbSeach
            // 
            lbSeach.AutoSize = true;
            lbSeach.BackColor = Color.White;
            lbSeach.Cursor = Cursors.Hand;
            lbSeach.Font = new Font("Segoe UI", 15F);
            lbSeach.ForeColor = SystemColors.Highlight;
            lbSeach.Location = new Point(562, 32);
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
            button3.Location = new Point(884, 750);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(380, 60);
            button3.TabIndex = 128;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(880, 681);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(383, 60);
            btSave.TabIndex = 125;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.NavajoWhite;
            btnRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRemove.ForeColor = Color.DimGray;
            btnRemove.Location = new Point(884, 821);
            btnRemove.Margin = new Padding(0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(380, 60);
            btnRemove.TabIndex = 129;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // UserControlProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btnRemove);
            Controls.Add(button3);
            Controls.Add(btSave);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlProduct";
            Size = new Size(1264, 885);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProduct;
        private Panel panel1;
        private Label lbUnitPrice;
        private Label lbQauntity;
        private TextBox tbSupplierID;
        private Label label6;
        private Label label5;
        private Label lbProductName;
        private Label lbSupplier;
        private TextBox tbQuantity;
        private TextBox tbProductName;
        private TextBox tbSupplierName;
        private Panel panel2;
        private TextBox tbSeach;
        private Label lbSeach;
        private Button button3;
        private Button btSave;
        private TextBox tbUnitPrice;
        private TextBox tbProductID;
        private Button btnRemove;
    }
}
