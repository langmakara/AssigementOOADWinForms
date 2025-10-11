namespace AssigementOOADWinForms.Controls
{
    partial class UserControlPurchasOrder
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
            panel1 = new Panel();
            btInsert = new Button();
            lbTotal = new Label();
            tbTotal = new TextBox();
            btRemove = new Button();
            btSave = new Button();
            lbEmployee = new Label();
            lbOrderDate = new Label();
            tbEmployee = new TextBox();
            lbSupplier = new Label();
            tbSupplier = new TextBox();
            btnRefresh = new Button();
            tbPurchaseID = new TextBox();
            dgvemployee = new DataGridView();
            OrderDate = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            lbPurchaseID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvemployee).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btInsert);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(tbTotal);
            panel1.Controls.Add(btRemove);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(lbEmployee);
            panel1.Controls.Add(lbOrderDate);
            panel1.Controls.Add(tbEmployee);
            panel1.Controls.Add(lbSupplier);
            panel1.Controls.Add(tbSupplier);
            panel1.Location = new Point(847, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 873);
            panel1.TabIndex = 76;
            // 
            // btInsert
            // 
            btInsert.BackColor = Color.DeepSkyBlue;
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
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Cursor = Cursors.Hand;
            lbTotal.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.White;
            lbTotal.Location = new Point(29, 318);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(178, 35);
            lbTotal.TabIndex = 63;
            lbTotal.Text = "Total Amount ";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(29, 362);
            tbTotal.Margin = new Padding(3, 4, 3, 4);
            tbTotal.Multiline = true;
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(355, 48);
            tbTotal.TabIndex = 62;
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
            // lbEmployee
            // 
            lbEmployee.AutoSize = true;
            lbEmployee.Cursor = Cursors.Hand;
            lbEmployee.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmployee.ForeColor = Color.White;
            lbEmployee.Location = new Point(29, 116);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(126, 35);
            lbEmployee.TabIndex = 59;
            lbEmployee.Text = "Employee";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Cursor = Cursors.Hand;
            lbOrderDate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrderDate.ForeColor = Color.White;
            lbOrderDate.Location = new Point(29, 217);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(154, 35);
            lbOrderDate.TabIndex = 58;
            lbOrderDate.Text = "Order Date  ";
            // 
            // tbEmployee
            // 
            tbEmployee.Location = new Point(29, 160);
            tbEmployee.Margin = new Padding(3, 4, 3, 4);
            tbEmployee.Multiline = true;
            tbEmployee.Name = "tbEmployee";
            tbEmployee.Size = new Size(355, 48);
            tbEmployee.TabIndex = 56;
            // 
            // lbSupplier
            // 
            lbSupplier.AutoSize = true;
            lbSupplier.Cursor = Cursors.Hand;
            lbSupplier.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSupplier.ForeColor = Color.White;
            lbSupplier.Location = new Point(29, 15);
            lbSupplier.Name = "lbSupplier";
            lbSupplier.Size = new Size(110, 35);
            lbSupplier.TabIndex = 55;
            lbSupplier.Text = "Supplier";
            // 
            // tbSupplier
            // 
            tbSupplier.Location = new Point(29, 59);
            tbSupplier.Margin = new Padding(3, 4, 3, 4);
            tbSupplier.Multiline = true;
            tbSupplier.Name = "tbSupplier";
            tbSupplier.Size = new Size(355, 48);
            tbSupplier.TabIndex = 54;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DeepSkyBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(673, 58);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(147, 41);
            btnRefresh.TabIndex = 74;
            btnRefresh.Text = "Clear";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tbPurchaseID
            // 
            tbPurchaseID.Location = new Point(8, 58);
            tbPurchaseID.Margin = new Padding(3, 4, 3, 4);
            tbPurchaseID.Multiline = true;
            tbPurchaseID.Name = "tbPurchaseID";
            tbPurchaseID.Size = new Size(267, 41);
            tbPurchaseID.TabIndex = 72;
            // 
            // dgvemployee
            // 
            dgvemployee.BackgroundColor = Color.White;
            dgvemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvemployee.Location = new Point(3, 121);
            dgvemployee.Margin = new Padding(3, 4, 3, 4);
            dgvemployee.Name = "dgvemployee";
            dgvemployee.RowHeadersWidth = 51;
            dgvemployee.Size = new Size(845, 755);
            dgvemployee.TabIndex = 70;
            // 
            // OrderDate
            // 
            OrderDate.CalendarFont = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            OrderDate.Location = new Point(281, 58);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(389, 38);
            OrderDate.TabIndex = 77;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(29, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(355, 38);
            dateTimePicker1.TabIndex = 78;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(lbPurchaseID);
            panel2.Controls.Add(OrderDate);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(tbPurchaseID);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 122);
            panel2.TabIndex = 78;
            // 
            // lbPurchaseID
            // 
            lbPurchaseID.AutoSize = true;
            lbPurchaseID.Cursor = Cursors.Hand;
            lbPurchaseID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lbPurchaseID.ForeColor = Color.White;
            lbPurchaseID.Location = new Point(8, 22);
            lbPurchaseID.Name = "lbPurchaseID";
            lbPurchaseID.Size = new Size(143, 35);
            lbPurchaseID.TabIndex = 78;
            lbPurchaseID.Text = "PurchaseID";
            // 
            // UserControlPurchasOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvemployee);
            Name = "UserControlPurchasOrder";
            Size = new Size(1264, 885);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvemployee).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btInsert;
        private Label lbTotal;
        private TextBox tbTotal;
        private Button btRemove;
        private Button btSave;
        private Label lbEmployee;
        private Label lbOrderDate;
        private TextBox tbEmployee;
        private Label lbSupplier;
        private TextBox tbSupplier;
        private Button btnRefresh;
        private TextBox tbPurchaseID;
        private DataGridView dgvemployee;
        private DateTimePicker OrderDate;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label lbPurchaseID;
    }
}
