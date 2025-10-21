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
            lbEmployeeName = new Label();
            tbEmployeeName = new TextBox();
            lbSupplierName = new Label();
            tbSupplierName = new TextBox();
            label1 = new Label();
            tbPuchaseOderID = new TextBox();
            DTPOrderDate = new DateTimePicker();
            lbTotal = new Label();
            tbTotal = new TextBox();
            lbEmployeeID = new Label();
            lbOrderDate = new Label();
            tbEmployeeID = new TextBox();
            lbSupplierID = new Label();
            tbSupplierID = new TextBox();
            tbPurchaseID = new TextBox();
            dgvPurchase = new DataGridView();
            OrderDate = new DateTimePicker();
            panel2 = new Panel();
            lbPurchaseID = new Label();
            btClear = new Button();
            btRemove = new Button();
            btSave = new Button();
            btnCreateInvoice = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchase).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbEmployeeName);
            panel1.Controls.Add(tbEmployeeName);
            panel1.Controls.Add(lbSupplierName);
            panel1.Controls.Add(tbSupplierName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbPuchaseOderID);
            panel1.Controls.Add(DTPOrderDate);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(tbTotal);
            panel1.Controls.Add(lbEmployeeID);
            panel1.Controls.Add(lbOrderDate);
            panel1.Controls.Add(tbEmployeeID);
            panel1.Controls.Add(lbSupplierID);
            panel1.Controls.Add(tbSupplierID);
            panel1.Location = new Point(894, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 697);
            panel1.TabIndex = 76;
            // 
            // lbEmployeeName
            // 
            lbEmployeeName.AutoSize = true;
            lbEmployeeName.Cursor = Cursors.Hand;
            lbEmployeeName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmployeeName.ForeColor = Color.White;
            lbEmployeeName.Location = new Point(10, 397);
            lbEmployeeName.Name = "lbEmployeeName";
            lbEmployeeName.Size = new Size(200, 35);
            lbEmployeeName.TabIndex = 84;
            lbEmployeeName.Text = "Employee Name";
            // 
            // tbEmployeeName
            // 
            tbEmployeeName.Font = new Font("Segoe UI", 15F);
            tbEmployeeName.Location = new Point(10, 440);
            tbEmployeeName.Margin = new Padding(3, 4, 3, 4);
            tbEmployeeName.Multiline = true;
            tbEmployeeName.Name = "tbEmployeeName";
            tbEmployeeName.Size = new Size(355, 48);
            tbEmployeeName.TabIndex = 83;
            // 
            // lbSupplierName
            // 
            lbSupplierName.AutoSize = true;
            lbSupplierName.Cursor = Cursors.Hand;
            lbSupplierName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSupplierName.ForeColor = Color.White;
            lbSupplierName.Location = new Point(7, 199);
            lbSupplierName.Name = "lbSupplierName";
            lbSupplierName.Size = new Size(184, 35);
            lbSupplierName.TabIndex = 82;
            lbSupplierName.Text = "Supplier Name";
            // 
            // tbSupplierName
            // 
            tbSupplierName.Font = new Font("Segoe UI", 15F);
            tbSupplierName.Location = new Point(7, 242);
            tbSupplierName.Margin = new Padding(3, 4, 3, 4);
            tbSupplierName.Multiline = true;
            tbSupplierName.Name = "tbSupplierName";
            tbSupplierName.Size = new Size(355, 48);
            tbSupplierName.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 1);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 80;
            label1.Text = "Puchase Oder ID";
            // 
            // tbPuchaseOderID
            // 
            tbPuchaseOderID.Font = new Font("Segoe UI", 15F);
            tbPuchaseOderID.Location = new Point(7, 44);
            tbPuchaseOderID.Margin = new Padding(3, 4, 3, 4);
            tbPuchaseOderID.Multiline = true;
            tbPuchaseOderID.Name = "tbPuchaseOderID";
            tbPuchaseOderID.Size = new Size(355, 48);
            tbPuchaseOderID.TabIndex = 79;
            // 
            // DTPOrderDate
            // 
            DTPOrderDate.CalendarFont = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTPOrderDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DTPOrderDate.Location = new Point(7, 539);
            DTPOrderDate.Name = "DTPOrderDate";
            DTPOrderDate.Size = new Size(355, 38);
            DTPOrderDate.TabIndex = 78;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Cursor = Cursors.Hand;
            lbTotal.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.White;
            lbTotal.Location = new Point(7, 585);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(178, 35);
            lbTotal.TabIndex = 63;
            lbTotal.Text = "Total Amount ";
            // 
            // tbTotal
            // 
            tbTotal.Font = new Font("Segoe UI", 15F);
            tbTotal.Location = new Point(7, 628);
            tbTotal.Margin = new Padding(3, 4, 3, 4);
            tbTotal.Multiline = true;
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(355, 48);
            tbTotal.TabIndex = 62;
            // 
            // lbEmployeeID
            // 
            lbEmployeeID.AutoSize = true;
            lbEmployeeID.Cursor = Cursors.Hand;
            lbEmployeeID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmployeeID.ForeColor = Color.White;
            lbEmployeeID.Location = new Point(7, 298);
            lbEmployeeID.Name = "lbEmployeeID";
            lbEmployeeID.Size = new Size(158, 35);
            lbEmployeeID.TabIndex = 59;
            lbEmployeeID.Text = "Employee ID";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Cursor = Cursors.Hand;
            lbOrderDate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrderDate.ForeColor = Color.White;
            lbOrderDate.Location = new Point(7, 496);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(154, 35);
            lbOrderDate.TabIndex = 58;
            lbOrderDate.Text = "Order Date  ";
            // 
            // tbEmployeeID
            // 
            tbEmployeeID.Font = new Font("Segoe UI", 15F);
            tbEmployeeID.Location = new Point(7, 341);
            tbEmployeeID.Margin = new Padding(3, 4, 3, 4);
            tbEmployeeID.Multiline = true;
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(355, 48);
            tbEmployeeID.TabIndex = 56;
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.Cursor = Cursors.Hand;
            lbSupplierID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSupplierID.ForeColor = Color.White;
            lbSupplierID.Location = new Point(7, 100);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new Size(142, 35);
            lbSupplierID.TabIndex = 55;
            lbSupplierID.Text = "Supplier ID";
            // 
            // tbSupplierID
            // 
            tbSupplierID.Font = new Font("Segoe UI", 15F);
            tbSupplierID.Location = new Point(7, 143);
            tbSupplierID.Margin = new Padding(3, 4, 3, 4);
            tbSupplierID.Multiline = true;
            tbSupplierID.Name = "tbSupplierID";
            tbSupplierID.Size = new Size(355, 48);
            tbSupplierID.TabIndex = 54;
            // 
            // tbPurchaseID
            // 
            tbPurchaseID.Font = new Font("Segoe UI", 15F);
            tbPurchaseID.Location = new Point(8, 58);
            tbPurchaseID.Margin = new Padding(3, 4, 3, 4);
            tbPurchaseID.Multiline = true;
            tbPurchaseID.Name = "tbPurchaseID";
            tbPurchaseID.Size = new Size(267, 41);
            tbPurchaseID.TabIndex = 72;
            // 
            // dgvPurchase
            // 
            dgvPurchase.BackgroundColor = Color.White;
            dgvPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchase.Location = new Point(6, 129);
            dgvPurchase.Margin = new Padding(3, 4, 3, 4);
            dgvPurchase.Name = "dgvPurchase";
            dgvPurchase.RowHeadersWidth = 51;
            dgvPurchase.Size = new Size(882, 747);
            dgvPurchase.TabIndex = 70;
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
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(lbPurchaseID);
            panel2.Controls.Add(OrderDate);
            panel2.Controls.Add(tbPurchaseID);
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 122);
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
            // btClear
            // 
            btClear.BackColor = Color.White;
            btClear.FlatAppearance.BorderColor = Color.DodgerBlue;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btClear.ForeColor = Color.DodgerBlue;
            btClear.Location = new Point(1082, 757);
            btClear.Margin = new Padding(0);
            btClear.Name = "btClear";
            btClear.Size = new Size(182, 64);
            btClear.TabIndex = 135;
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
            btRemove.Location = new Point(894, 821);
            btRemove.Margin = new Padding(0);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(370, 56);
            btRemove.TabIndex = 134;
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
            btSave.Location = new Point(894, 757);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(187, 64);
            btSave.TabIndex = 133;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.BackColor = Color.FromArgb(255, 128, 0);
            btnCreateInvoice.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnCreateInvoice.FlatAppearance.BorderSize = 0;
            btnCreateInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Location = new Point(894, 700);
            btnCreateInvoice.Margin = new Padding(0);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(370, 57);
            btnCreateInvoice.TabIndex = 136;
            btnCreateInvoice.Text = "View / Create Purchase Detail";
            btnCreateInvoice.UseVisualStyleBackColor = false;
            // 
            // UserControlPurchasOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreateInvoice);
            Controls.Add(btClear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btRemove);
            Controls.Add(dgvPurchase);
            Controls.Add(btSave);
            Name = "UserControlPurchasOrder";
            Size = new Size(1264, 885);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchase).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTotal;
        private TextBox tbTotal;
        private Label lbEmployeeID;
        private Label lbOrderDate;
        private TextBox tbEmployeeID;
        private Label lbSupplierID;
        private TextBox tbSupplierID;
        private TextBox tbPurchaseID;
        private DataGridView dgvPurchase;
        private DateTimePicker OrderDate;
        private DateTimePicker DTPOrderDate;
        private Panel panel2;
        private Label lbPurchaseID;
        private Button btClear;
        private Button btRemove;
        private Button btSave;
        private Label label1;
        private TextBox tbPuchaseOderID;
        private Label lbSupplierName;
        private TextBox tbSupplierName;
        private Label lbEmployeeName;
        private TextBox tbEmployeeName;
        private Button btnCreateInvoice;
    }
}
