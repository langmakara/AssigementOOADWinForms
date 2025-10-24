namespace AssigementOOADWinForms.Controls
{
    partial class UserControlDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel5 = new Panel();
            pictureBox15 = new PictureBox();
            labelTotalProduct = new Label();
            TotalProduct = new Label();
            panel3 = new Panel();
            labelTotalStock = new Label();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            panel4 = new Panel();
            labelTotalValue = new Label();
            pictureBox14 = new PictureBox();
            label15 = new Label();
            label1 = new Label();
            label2 = new Label();
            DataViewOutOfStock = new DataGridView();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            pbStockVsSales = new PictureBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataViewOutOfStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStockVsSales).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Controls.Add(pictureBox15);
            panel5.Controls.Add(labelTotalProduct);
            panel5.Controls.Add(TotalProduct);
            panel5.Location = new Point(730, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(379, 130);
            panel5.TabIndex = 3;
            // 
            // pictureBox15
            // 
            pictureBox15.BackgroundImage = Properties.Resources.icons8_sales_100;
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Cursor = Cursors.AppStarting;
            pictureBox15.Location = new Point(326, 17);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(30, 30);
            pictureBox15.TabIndex = 30;
            pictureBox15.TabStop = false;
            // 
            // labelTotalProduct
            // 
            labelTotalProduct.AutoSize = true;
            labelTotalProduct.Cursor = Cursors.Hand;
            labelTotalProduct.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTotalProduct.ForeColor = Color.White;
            labelTotalProduct.Location = new Point(21, 59);
            labelTotalProduct.Name = "labelTotalProduct";
            labelTotalProduct.Size = new Size(143, 37);
            labelTotalProduct.TabIndex = 30;
            labelTotalProduct.Text = "$ 120000 ";
            // 
            // TotalProduct
            // 
            TotalProduct.AutoSize = true;
            TotalProduct.Cursor = Cursors.Hand;
            TotalProduct.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            TotalProduct.ForeColor = Color.White;
            TotalProduct.Location = new Point(21, 17);
            TotalProduct.Name = "TotalProduct";
            TotalProduct.Size = new Size(139, 28);
            TotalProduct.TabIndex = 30;
            TotalProduct.Text = "Total Product";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(labelTotalStock);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox13);
            panel3.Location = new Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 130);
            panel3.TabIndex = 2;
            // 
            // labelTotalStock
            // 
            labelTotalStock.AutoSize = true;
            labelTotalStock.Cursor = Cursors.Hand;
            labelTotalStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTotalStock.ForeColor = Color.White;
            labelTotalStock.Location = new Point(25, 59);
            labelTotalStock.Name = "labelTotalStock";
            labelTotalStock.Size = new Size(97, 37);
            labelTotalStock.TabIndex = 28;
            labelTotalStock.Text = "12000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DodgerBlue;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(16, 20);
            label13.Name = "label13";
            label13.Size = new Size(206, 28);
            label13.TabIndex = 27;
            label13.Text = "Total Stock Qauntity";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.icons8_stock_64;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Cursor = Cursors.AppStarting;
            pictureBox13.Location = new Point(294, 17);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(30, 30);
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Controls.Add(labelTotalValue);
            panel4.Controls.Add(pictureBox14);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(361, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(365, 130);
            panel4.TabIndex = 3;
            // 
            // labelTotalValue
            // 
            labelTotalValue.AutoSize = true;
            labelTotalValue.Cursor = Cursors.Hand;
            labelTotalValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTotalValue.ForeColor = Color.White;
            labelTotalValue.Location = new Point(36, 59);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(143, 37);
            labelTotalValue.TabIndex = 29;
            labelTotalValue.Text = "$ 120000 ";
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = Properties.Resources.icons8_money_100;
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Cursor = Cursors.AppStarting;
            pictureBox14.Location = new Point(312, 18);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(30, 30);
            pictureBox14.TabIndex = 29;
            pictureBox14.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Cursor = Cursors.Hand;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(15, 21);
            label15.Name = "label15";
            label15.Size = new Size(174, 28);
            label15.TabIndex = 29;
            label15.Text = "Total Stock Value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 136);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 29;
            label1.Text = " Low Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(260, 136);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 32;
            label2.Text = "Out-of-Stock ";
            // 
            // DataViewOutOfStock
            // 
            DataViewOutOfStock.BackgroundColor = Color.White;
            DataViewOutOfStock.BorderStyle = BorderStyle.None;
            DataViewOutOfStock.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataViewOutOfStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataViewOutOfStock.Location = new Point(260, 170);
            DataViewOutOfStock.Name = "DataViewOutOfStock";
            DataViewOutOfStock.Size = new Size(248, 494);
            DataViewOutOfStock.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(3, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(251, 494);
            dataGridView1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(512, 139);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 39;
            label3.Text = "Top5 Products Sold";
            // 
            // pbStockVsSales
            // 
            pbStockVsSales.BackColor = Color.Azure;
            pbStockVsSales.BackgroundImageLayout = ImageLayout.None;
            pbStockVsSales.Location = new Point(512, 167);
            pbStockVsSales.Margin = new Padding(0);
            pbStockVsSales.Name = "pbStockVsSales";
            pbStockVsSales.Size = new Size(596, 494);
            pbStockVsSales.TabIndex = 34;
            pbStockVsSales.TabStop = false;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(DataViewOutOfStock);
            Controls.Add(dataGridView1);
            Controls.Add(pbStockVsSales);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "UserControlDashboard";
            Size = new Size(1111, 664);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataViewOutOfStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStockVsSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel5;
        private PictureBox pictureBox15;
        private Label labelTotalProduct;
        private Label TotalProduct;
        private Panel panel3;
        private Label labelTotalStock;
        private Label label13;
        private PictureBox pictureBox13;
        private Panel panel4;
        private Label labelTotalValue;
        private PictureBox pictureBox14;
        private Label label15;
        private Label label1;
        private Label label2;
        private DataGridView DataViewOutOfStock;
        private DataGridView dataGridView1;
        private Label label3;
        private PictureBox pbStockVsSales;
    }
}
