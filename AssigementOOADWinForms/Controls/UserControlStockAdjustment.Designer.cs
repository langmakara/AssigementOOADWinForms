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
            lbProductID = new Label();
            tbProductID = new TextBox();
            btSave = new Button();
            lbEmployeeID = new Label();
            tbEmployee = new TextBox();
            lbAdjustmentID = new Label();
            tbAdjustmentID = new TextBox();
            lbAdjustmentType = new Label();
            tbAdjustmentType = new TextBox();
            lbQuantity = new Label();
            tbQuantity = new TextBox();
            lbReason = new Label();
            tbReason = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbReason);
            panel1.Controls.Add(tbReason);
            panel1.Controls.Add(lbQuantity);
            panel1.Controls.Add(tbQuantity);
            panel1.Controls.Add(lbAdjustmentType);
            panel1.Controls.Add(tbAdjustmentType);
            panel1.Controls.Add(lbProductID);
            panel1.Controls.Add(tbProductID);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(lbEmployeeID);
            panel1.Controls.Add(tbEmployee);
            panel1.Controls.Add(lbAdjustmentID);
            panel1.Controls.Add(tbAdjustmentID);
            panel1.Location = new Point(31, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 836);
            panel1.TabIndex = 77;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Cursor = Cursors.Hand;
            lbProductID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductID.ForeColor = Color.White;
            lbProductID.Location = new Point(29, 111);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(137, 35);
            lbProductID.TabIndex = 63;
            lbProductID.Text = "Product ID";
            // 
            // tbProductID
            // 
            tbProductID.Location = new Point(29, 155);
            tbProductID.Margin = new Padding(3, 4, 3, 4);
            tbProductID.Multiline = true;
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(355, 48);
            tbProductID.TabIndex = 62;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Green;
            btSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(1006, 510);
            btSave.Margin = new Padding(0);
            btSave.Name = "btSave";
            btSave.Size = new Size(175, 49);
            btSave.TabIndex = 60;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // lbEmployeeID
            // 
            lbEmployeeID.AutoSize = true;
            lbEmployeeID.Cursor = Cursors.Hand;
            lbEmployeeID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmployeeID.ForeColor = Color.White;
            lbEmployeeID.Location = new Point(29, 205);
            lbEmployeeID.Name = "lbEmployeeID";
            lbEmployeeID.Size = new Size(158, 35);
            lbEmployeeID.TabIndex = 59;
            lbEmployeeID.Text = "Employee ID";
            lbEmployeeID.Click += lbEmployee_Click;
            // 
            // tbEmployee
            // 
            tbEmployee.Location = new Point(29, 249);
            tbEmployee.Margin = new Padding(3, 4, 3, 4);
            tbEmployee.Multiline = true;
            tbEmployee.Name = "tbEmployee";
            tbEmployee.Size = new Size(355, 48);
            tbEmployee.TabIndex = 56;
            // 
            // lbAdjustmentID
            // 
            lbAdjustmentID.AutoSize = true;
            lbAdjustmentID.Cursor = Cursors.Hand;
            lbAdjustmentID.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAdjustmentID.ForeColor = Color.White;
            lbAdjustmentID.Location = new Point(29, 15);
            lbAdjustmentID.Name = "lbAdjustmentID";
            lbAdjustmentID.Size = new Size(173, 35);
            lbAdjustmentID.TabIndex = 55;
            lbAdjustmentID.Text = "AdjustmentID";
            // 
            // tbAdjustmentID
            // 
            tbAdjustmentID.Location = new Point(29, 59);
            tbAdjustmentID.Margin = new Padding(3, 4, 3, 4);
            tbAdjustmentID.Multiline = true;
            tbAdjustmentID.Name = "tbAdjustmentID";
            tbAdjustmentID.Size = new Size(355, 48);
            tbAdjustmentID.TabIndex = 54;
            // 
            // lbAdjustmentType
            // 
            lbAdjustmentType.AutoSize = true;
            lbAdjustmentType.Cursor = Cursors.Hand;
            lbAdjustmentType.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAdjustmentType.ForeColor = Color.White;
            lbAdjustmentType.Location = new Point(29, 306);
            lbAdjustmentType.Name = "lbAdjustmentType";
            lbAdjustmentType.Size = new Size(209, 35);
            lbAdjustmentType.TabIndex = 70;
            lbAdjustmentType.Text = "Adjustment Type";
            // 
            // tbAdjustmentType
            // 
            tbAdjustmentType.Location = new Point(29, 345);
            tbAdjustmentType.Margin = new Padding(3, 4, 3, 4);
            tbAdjustmentType.Multiline = true;
            tbAdjustmentType.Name = "tbAdjustmentType";
            tbAdjustmentType.Size = new Size(355, 48);
            tbAdjustmentType.TabIndex = 69;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Cursor = Cursors.Hand;
            lbQuantity.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuantity.ForeColor = Color.White;
            lbQuantity.Location = new Point(29, 400);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(115, 35);
            lbQuantity.TabIndex = 72;
            lbQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(29, 439);
            tbQuantity.Margin = new Padding(3, 4, 3, 4);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(355, 48);
            tbQuantity.TabIndex = 71;
            // 
            // lbReason
            // 
            lbReason.AutoSize = true;
            lbReason.Cursor = Cursors.Hand;
            lbReason.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbReason.ForeColor = Color.White;
            lbReason.Location = new Point(458, 20);
            lbReason.Name = "lbReason";
            lbReason.Size = new Size(97, 35);
            lbReason.TabIndex = 74;
            lbReason.Text = "Reason";
            // 
            // tbReason
            // 
            tbReason.Location = new Point(458, 59);
            tbReason.Margin = new Padding(3, 4, 3, 4);
            tbReason.Multiline = true;
            tbReason.Name = "tbReason";
            tbReason.Size = new Size(723, 428);
            tbReason.TabIndex = 73;
            // 
            // UserControlStockAdjustment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControlStockAdjustment";
            Size = new Size(1264, 885);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbProductID;
        private TextBox tbProductID;
        private Button btSave;
        private Label lbEmployeeID;
        private TextBox tbEmployee;
        private Label lbAdjustmentID;
        private TextBox tbAdjustmentID;
        private Label lbAdjustmentType;
        private TextBox tbAdjustmentType;
        private Label lbReason;
        private TextBox tbReason;
        private Label lbQuantity;
        private TextBox tbQuantity;
    }
}
