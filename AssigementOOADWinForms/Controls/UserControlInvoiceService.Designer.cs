namespace AssigementOOADWinForms.Controls
{
    partial class UserControlInvoiceService
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
            dvgInvoiceService = new DataGridView();
            btnAccept = new Button();
            lbCancel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dvgInvoiceService).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dvgInvoiceService
            // 
            dvgInvoiceService.BackgroundColor = Color.White;
            dvgInvoiceService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInvoiceService.Location = new Point(2, 0);
            dvgInvoiceService.Name = "dvgInvoiceService";
            dvgInvoiceService.Size = new Size(944, 661);
            dvgInvoiceService.TabIndex = 0;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(40, 167, 69);
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.Location = new Point(7, 583);
            btnAccept.Margin = new Padding(0);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(142, 37);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            // 
            // lbCancel
            // 
            lbCancel.AutoSize = true;
            lbCancel.BackColor = Color.Transparent;
            lbCancel.Font = new Font("Segoe UI", 12F);
            lbCancel.ForeColor = Color.Transparent;
            lbCancel.Location = new Point(51, 625);
            lbCancel.Name = "lbCancel";
            lbCancel.Size = new Size(56, 21);
            lbCancel.TabIndex = 2;
            lbCancel.Text = "Cancel";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnAccept);
            panel1.Controls.Add(lbCancel);
            panel1.Location = new Point(953, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 664);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // UserControlInvoiceService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dvgInvoiceService);
            Controls.Add(panel1);
            Name = "UserControlInvoiceService";
            Size = new Size(1111, 664);
            ((System.ComponentModel.ISupportInitialize)dvgInvoiceService).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgInvoiceService;
        private Button btnAccept;
        private Label lbCancel;
        private Panel panel1;
    }
}
