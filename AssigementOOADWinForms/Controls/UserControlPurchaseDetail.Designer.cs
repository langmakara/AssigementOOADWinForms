namespace AssigementOOADWinForms.Controls
{
    partial class UserControlPurchaseDetail
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
            panel2 = new Panel();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            panel3 = new Panel();
            lbTotalPurchaseDetail = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            tbPurchaseDetailID = new TextBox();
            tbPurchaseID = new TextBox();
            btClear = new Button();
            btRemove = new Button();
            btSave = new Button();
            tbQuantity = new TextBox();
            dgvPurchaseDetail = new DataGridView();
            panel1 = new Panel();
            tbProductID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            tbUnitPrice = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseDetail).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel2.Location = new Point(1, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 133);
            panel2.TabIndex = 133;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(594, 3);
            label1.Name = "label1";
            label1.Size = new Size(156, 35);
            label1.TabIndex = 133;
            label1.Text = "ProductPrice";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(7, 44);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(276, 48);
            textBox7.TabIndex = 132;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(291, 44);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(292, 48);
            textBox8.TabIndex = 124;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 3);
            label8.Name = "label8";
            label8.Size = new Size(140, 35);
            label8.TabIndex = 126;
            label8.Text = "PurchaseID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI", 15F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(295, 3);
            label10.Name = "label10";
            label10.Size = new Size(127, 35);
            label10.TabIndex = 127;
            label10.Text = "ProductID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(591, 44);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 48);
            textBox2.TabIndex = 93;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(lbTotalPurchaseDetail);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(897, 640);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 119);
            panel3.TabIndex = 132;
            // 
            // lbTotalPurchaseDetail
            // 
            lbTotalPurchaseDetail.AutoSize = true;
            lbTotalPurchaseDetail.Cursor = Cursors.Hand;
            lbTotalPurchaseDetail.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbTotalPurchaseDetail.ForeColor = Color.White;
            lbTotalPurchaseDetail.Location = new Point(21, 47);
            lbTotalPurchaseDetail.Name = "lbTotalPurchaseDetail";
            lbTotalPurchaseDetail.Size = new Size(40, 46);
            lbTotalPurchaseDetail.TabIndex = 28;
            lbTotalPurchaseDetail.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 128, 0);
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(16, 5);
            label13.Name = "label13";
            label13.Size = new Size(261, 35);
            label13.TabIndex = 27;
            label13.Text = "Total Purchase Detail";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_employees_100__1_;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(325, 5);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(34, 40);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // tbPurchaseDetailID
            // 
            tbPurchaseDetailID.Location = new Point(909, 47);
            tbPurchaseDetailID.Margin = new Padding(3, 4, 3, 4);
            tbPurchaseDetailID.Multiline = true;
            tbPurchaseDetailID.Name = "tbPurchaseDetailID";
            tbPurchaseDetailID.Size = new Size(346, 48);
            tbPurchaseDetailID.TabIndex = 131;
            // 
            // tbPurchaseID
            // 
            tbPurchaseID.Location = new Point(909, 175);
            tbPurchaseID.Margin = new Padding(3, 4, 3, 4);
            tbPurchaseID.Multiline = true;
            tbPurchaseID.Name = "tbPurchaseID";
            tbPurchaseID.Size = new Size(346, 48);
            tbPurchaseID.TabIndex = 130;
            // 
            // btClear
            // 
            btClear.BackColor = Color.White;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClear.ForeColor = Color.DodgerBlue;
            btClear.Location = new Point(1085, 763);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(182, 64);
            btClear.TabIndex = 129;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.FromArgb(255, 128, 0);
            btRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btRemove.FlatAppearance.BorderSize = 0;
            btRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(897, 827);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(370, 56);
            btRemove.TabIndex = 127;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(897, 763);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(187, 64);
            btSave.TabIndex = 126;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(909, 431);
            tbQuantity.Margin = new Padding(3, 4, 3, 4);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(347, 48);
            tbQuantity.TabIndex = 125;
            // 
            // dgvPurchaseDetail
            // 
            dgvPurchaseDetail.BackgroundColor = Color.White;
            dgvPurchaseDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseDetail.Location = new Point(1, 139);
            dgvPurchaseDetail.Margin = new Padding(3, 4, 3, 4);
            dgvPurchaseDetail.Name = "dgvPurchaseDetail";
            dgvPurchaseDetail.RowHeadersWidth = 51;
            dgvPurchaseDetail.Size = new Size(893, 743);
            dgvPurchaseDetail.TabIndex = 124;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(tbProductID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbUnitPrice);
            panel1.Location = new Point(896, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 633);
            panel1.TabIndex = 128;
            // 
            // tbProductID
            // 
            tbProductID.Location = new Point(11, 301);
            tbProductID.Margin = new Padding(3, 4, 3, 4);
            tbProductID.Multiline = true;
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(346, 48);
            tbProductID.TabIndex = 113;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(15, 1);
            label7.Name = "label7";
            label7.Size = new Size(197, 35);
            label7.TabIndex = 112;
            label7.Text = "PurchaseDetailD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 129);
            label6.Name = "label6";
            label6.Size = new Size(140, 35);
            label6.TabIndex = 110;
            label6.Text = "PurchaseID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 260);
            label2.Name = "label2";
            label2.Size = new Size(127, 35);
            label2.TabIndex = 102;
            label2.Text = "ProductID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 383);
            label5.Name = "label5";
            label5.Size = new Size(109, 35);
            label5.TabIndex = 98;
            label5.Text = "Qauntity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 516);
            label3.Name = "label3";
            label3.Size = new Size(114, 35);
            label3.TabIndex = 94;
            label3.Text = "UnitPrice";
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Location = new Point(13, 557);
            tbUnitPrice.Margin = new Padding(3, 4, 3, 4);
            tbUnitPrice.Multiline = true;
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(346, 48);
            tbUnitPrice.TabIndex = 96;
            // 
            // UserControlPurchaseDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(tbPurchaseDetailID);
            Controls.Add(tbPurchaseID);
            Controls.Add(btClear);
            Controls.Add(btRemove);
            Controls.Add(btSave);
            Controls.Add(tbQuantity);
            Controls.Add(dgvPurchaseDetail);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlPurchaseDetail";
            Size = new Size(1270, 885);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label10;
        private TextBox textBox2;
        private Panel panel3;
        private Label lbTotalPurchaseDetail;
        private Label label13;
        private PictureBox pictureBox13;
        private TextBox tbPurchaseDetailID;
        private TextBox tbPurchaseID;
        private Button btClear;
        private Button btRemove;
        private Button btSave;
        private TextBox tbQuantity;
        private DataGridView dgvPurchaseDetail;
        private Panel panel1;
        private TextBox tbProductID;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label3;
        private TextBox tbUnitPrice;
    }
}
