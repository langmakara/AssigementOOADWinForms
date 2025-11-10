namespace AssigementOOADWinForms.Controls
{
    partial class UserControlReport
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
            label4 = new Label();
            label3 = new Label();
            SeachSupplier = new TextBox();
            label2 = new Label();
            btnLoadExport = new Button();
            btnLoadImport = new Button();
            dateSearchStart = new DateTimePicker();
            dateSearchEnd = new DateTimePicker();
            DGVreport = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVreport).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(SeachSupplier);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLoadExport);
            panel2.Controls.Add(btnLoadImport);
            panel2.Controls.Add(dateSearchStart);
            panel2.Controls.Add(dateSearchEnd);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1259, 109);
            panel2.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.IBeam;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(694, 6);
            label4.Name = "label4";
            label4.Size = new Size(58, 35);
            label4.TabIndex = 146;
            label4.Text = "End";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(461, 7);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 145;
            label3.Text = "Start";
            // 
            // SeachSupplier
            // 
            SeachSupplier.Font = new Font("Segoe UI", 16F);
            SeachSupplier.Location = new Point(34, 46);
            SeachSupplier.Name = "SeachSupplier";
            SeachSupplier.Size = new Size(371, 43);
            SeachSupplier.TabIndex = 144;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 7);
            label2.Name = "label2";
            label2.Size = new Size(258, 35);
            label2.TabIndex = 143;
            label2.Text = "Seach Supplier Name";
            label2.Click += label2_Click;
            // 
            // btnLoadExport
            // 
            btnLoadExport.BackColor = Color.DodgerBlue;
            btnLoadExport.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLoadExport.FlatAppearance.BorderSize = 0;
            btnLoadExport.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLoadExport.ForeColor = Color.White;
            btnLoadExport.Location = new Point(1071, 46);
            btnLoadExport.Margin = new Padding(0);
            btnLoadExport.Name = "btnLoadExport";
            btnLoadExport.Size = new Size(171, 43);
            btnLoadExport.TabIndex = 142;
            btnLoadExport.Text = "Export";
            btnLoadExport.UseVisualStyleBackColor = false;
            // 
            // btnLoadImport
            // 
            btnLoadImport.BackColor = Color.DodgerBlue;
            btnLoadImport.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLoadImport.FlatAppearance.BorderSize = 0;
            btnLoadImport.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLoadImport.ForeColor = Color.White;
            btnLoadImport.Location = new Point(900, 46);
            btnLoadImport.Margin = new Padding(0);
            btnLoadImport.Name = "btnLoadImport";
            btnLoadImport.Size = new Size(171, 43);
            btnLoadImport.TabIndex = 141;
            btnLoadImport.Text = "Import";
            btnLoadImport.UseVisualStyleBackColor = false;
            // 
            // dateSearchStart
            // 
            dateSearchStart.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateSearchStart.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dateSearchStart.Checked = false;
            dateSearchStart.Font = new Font("Segoe UI", 16F);
            dateSearchStart.Location = new Point(461, 46);
            dateSearchStart.Margin = new Padding(3, 4, 3, 4);
            dateSearchStart.Name = "dateSearchStart";
            dateSearchStart.ShowCheckBox = true;
            dateSearchStart.Size = new Size(226, 43);
            dateSearchStart.TabIndex = 136;
            // 
            // dateSearchEnd
            // 
            dateSearchEnd.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateSearchEnd.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dateSearchEnd.Checked = false;
            dateSearchEnd.Font = new Font("Segoe UI", 16F);
            dateSearchEnd.Location = new Point(694, 46);
            dateSearchEnd.Margin = new Padding(3, 4, 3, 4);
            dateSearchEnd.Name = "dateSearchEnd";
            dateSearchEnd.ShowCheckBox = true;
            dateSearchEnd.Size = new Size(203, 43);
            dateSearchEnd.TabIndex = 135;
            // 
            // DGVreport
            // 
            DGVreport.BackgroundColor = Color.White;
            DGVreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVreport.Location = new Point(3, 119);
            DGVreport.Name = "DGVreport";
            DGVreport.RowHeadersWidth = 51;
            DGVreport.Size = new Size(1258, 763);
            DGVreport.TabIndex = 53;
            // 
            // UserControlReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DGVreport);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlReport";
            Size = new Size(1264, 885);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVreport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView DGVreport;
        private DateTimePicker dateSearchStart;
        private DateTimePicker dateSearchEnd;
        private Button btnLoadExport;
        private Button btnLoadImport;
        private TextBox SeachSupplier;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
