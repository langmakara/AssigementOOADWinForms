namespace AssigementOOADWinForms.Controls
{
    partial class UserControlStockAdjustment
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
            lbAdjustmentDate = new Label();
            tbAdjustmentDate = new DateTimePicker();
            cbAdjustmentType = new ComboBox();
            dgvStockAdjustments = new DataGridView();
            btDelete = new Button();
            lbReason = new Label();
            tbReason = new TextBox();
            lbQuantity = new Label();
            tbQuantity = new TextBox();
            lbAdjustmentType = new Label();
            lbProductID = new Label();
            tbProductID = new TextBox();
            btSave = new Button();
            lbEmployeeID = new Label();
            tbEmployeeID = new TextBox();
            lbAdjustmentID = new Label();
            tbAdjustmentID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockAdjustments).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(lbAdjustmentDate);
            panel1.Controls.Add(tbAdjustmentDate);
            panel1.Controls.Add(cbAdjustmentType);
            panel1.Controls.Add(dgvStockAdjustments);
            panel1.Controls.Add(btDelete);
            panel1.Controls.Add(lbReason);
            panel1.Controls.Add(tbReason);
            panel1.Controls.Add(lbQuantity);
            panel1.Controls.Add(tbQuantity);
            panel1.Controls.Add(lbAdjustmentType);
            panel1.Controls.Add(lbProductID);
            panel1.Controls.Add(tbProductID);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(lbEmployeeID);
            panel1.Controls.Add(tbEmployeeID);
            panel1.Controls.Add(lbAdjustmentID);
            panel1.Controls.Add(tbAdjustmentID);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 870);
            panel1.TabIndex = 77;
            // 
            // lbAdjustmentDate
            // 
            lbAdjustmentDate.AutoSize = true;
            lbAdjustmentDate.Cursor = Cursors.Hand;
            lbAdjustmentDate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAdjustmentDate.ForeColor = Color.White;
            lbAdjustmentDate.Location = new Point(428, 111);
            lbAdjustmentDate.Name = "lbAdjustmentDate";
            lbAdjustmentDate.Size = new Size(201, 35);
            lbAdjustmentDate.TabIndex = 83;
            lbAdjustmentDate.Text = "AdjustmentDate";
            // 
            // tbAdjustmentDate
            // 
            tbAdjustmentDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAdjustmentDate.Format = DateTimePickerFormat.Short;
            tbAdjustmentDate.Location = new Point(428, 151);
            tbAdjustmentDate.Name = "tbAdjustmentDate";
            tbAdjustmentDate.Size = new Size(415, 47);
            tbAdjustmentDate.TabIndex = 82;
            // 
            // cbAdjustmentType
            // 
            cbAdjustmentType.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAdjustmentType.FormattingEnabled = true;
            cbAdjustmentType.Location = new Point(12, 149);
            cbAdjustmentType.Name = "cbAdjustmentType";
            cbAdjustmentType.Size = new Size(383, 49);
            cbAdjustmentType.TabIndex = 81;
            // 
            // dgvStockAdjustments
            // 
            dgvStockAdjustments.BackgroundColor = Color.Azure;
            dgvStockAdjustments.BorderStyle = BorderStyle.None;
            dgvStockAdjustments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockAdjustments.Location = new Point(3, 451);
            dgvStockAdjustments.Name = "dgvStockAdjustments";
            dgvStockAdjustments.RowHeadersWidth = 51;
            dgvStockAdjustments.Size = new Size(1252, 408);
            dgvStockAdjustments.TabIndex = 80;
            dgvStockAdjustments.CellClick += dgvStockAdjustments_CellClick;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.Red;
            btDelete.FlatAppearance.BorderColor = Color.DodgerBlue;
            btDelete.FlatAppearance.BorderSize = 0;
            btDelete.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btDelete.ForeColor = Color.White;
            btDelete.Location = new Point(611, 390);
            btDelete.Margin = new Padding(0);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(192, 49);
            btDelete.TabIndex = 77;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // lbReason
            // 
            lbReason.AutoSize = true;
            lbReason.Cursor = Cursors.Hand;
            lbReason.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbReason.ForeColor = Color.White;
            lbReason.Location = new Point(12, 207);
            lbReason.Name = "lbReason";
            lbReason.Size = new Size(97, 35);
            lbReason.TabIndex = 74;
            lbReason.Text = "Reason";
            // 
            // tbReason
            // 
            tbReason.BackColor = Color.White;
            tbReason.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbReason.Location = new Point(12, 246);
            tbReason.Margin = new Padding(3, 4, 3, 4);
            tbReason.Multiline = true;
            tbReason.Name = "tbReason";
            tbReason.Size = new Size(1229, 100);
            tbReason.TabIndex = 73;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Cursor = Cursors.Hand;
            lbQuantity.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuantity.ForeColor = Color.White;
            lbQuantity.Location = new Point(874, 110);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(115, 35);
            lbQuantity.TabIndex = 72;
            lbQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(874, 149);
            tbQuantity.Margin = new Padding(3, 4, 3, 4);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(367, 49);
            tbQuantity.TabIndex = 71;
            // 
            // lbAdjustmentType
            // 
            lbAdjustmentType.AutoSize = true;
            lbAdjustmentType.Cursor = Cursors.Hand;
            lbAdjustmentType.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAdjustmentType.ForeColor = Color.White;
            lbAdjustmentType.Location = new Point(12, 110);
            lbAdjustmentType.Name = "lbAdjustmentType";
            lbAdjustmentType.Size = new Size(209, 35);
            lbAdjustmentType.TabIndex = 70;
            lbAdjustmentType.Text = "Adjustment Type";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Cursor = Cursors.Hand;
            lbProductID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductID.ForeColor = Color.White;
            lbProductID.Location = new Point(428, 8);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(137, 35);
            lbProductID.TabIndex = 63;
            lbProductID.Text = "Product ID";
            // 
            // tbProductID
            // 
            tbProductID.Font = new Font("Segoe UI", 18F);
            tbProductID.Location = new Point(428, 47);
            tbProductID.Margin = new Padding(3, 4, 3, 4);
            tbProductID.Multiline = true;
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(415, 47);
            tbProductID.TabIndex = 62;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(402, 390);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(192, 49);
            btSave.TabIndex = 60;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // lbEmployeeID
            // 
            lbEmployeeID.AutoSize = true;
            lbEmployeeID.Cursor = Cursors.Hand;
            lbEmployeeID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmployeeID.ForeColor = Color.White;
            lbEmployeeID.Location = new Point(874, 8);
            lbEmployeeID.Name = "lbEmployeeID";
            lbEmployeeID.Size = new Size(158, 35);
            lbEmployeeID.TabIndex = 59;
            lbEmployeeID.Text = "Employee ID";
            // 
            // tbEmployeeID
            // 
            tbEmployeeID.Font = new Font("Segoe UI", 18F);
            tbEmployeeID.Location = new Point(874, 47);
            tbEmployeeID.Margin = new Padding(3, 4, 3, 4);
            tbEmployeeID.Multiline = true;
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(367, 47);
            tbEmployeeID.TabIndex = 56;
            // 
            // lbAdjustmentID
            // 
            lbAdjustmentID.AutoSize = true;
            lbAdjustmentID.Cursor = Cursors.Hand;
            lbAdjustmentID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAdjustmentID.ForeColor = Color.White;
            lbAdjustmentID.Location = new Point(12, 8);
            lbAdjustmentID.Name = "lbAdjustmentID";
            lbAdjustmentID.Size = new Size(173, 35);
            lbAdjustmentID.TabIndex = 55;
            lbAdjustmentID.Text = "AdjustmentID";
            // 
            // tbAdjustmentID
            // 
            tbAdjustmentID.Font = new Font("Segoe UI", 18F);
            tbAdjustmentID.Location = new Point(12, 47);
            tbAdjustmentID.Margin = new Padding(3, 4, 3, 4);
            tbAdjustmentID.Multiline = true;
            tbAdjustmentID.Name = "tbAdjustmentID";
            tbAdjustmentID.Size = new Size(383, 47);
            tbAdjustmentID.TabIndex = 54;
            // 
            // UserControlStockAdjustment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControlStockAdjustment";
            Size = new Size(1264, 873);
            Load += UserControlStockAdjustment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockAdjustments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbProductID;
        private TextBox tbProductID;
        private Button btSave;
        private Label lbEmployeeID;
        private TextBox tbEmployeeID;
        private Label lbAdjustmentID;
        private TextBox tbAdjustmentID;
        private Label lbAdjustmentType;
        private Label lbReason;
        private TextBox tbReason;
        private Label lbQuantity;
        private TextBox tbQuantity;
        private Button btDelete;
        private DataGridView dgvStockAdjustments;
        private ComboBox cbAdjustmentType;
        private Label lbAdjustmentDate;
        private DateTimePicker tbAdjustmentDate;
    }
}
