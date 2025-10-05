namespace AssigementOOADWinForms.Controls
{
    partial class UserControlInventory
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
            comboBox1 = new ComboBox();
            dgvinventory = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            btnRefresh = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvinventory).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.TabIndex = 0;
            // 
            // dgvinventory
            // 
            dgvinventory.BackgroundColor = Color.White;
            dgvinventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventory.Location = new Point(13, 83);
            dgvinventory.Name = "dgvinventory";
            dgvinventory.Size = new Size(956, 573);
            dgvinventory.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 37);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 30;
            label1.Text = "Product";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Location = new Point(840, 41);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 37);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(227, 9);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 32;
            label2.Text = "Transition";
            // 
            // UserControlInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvinventory);
            Controls.Add(comboBox1);
            Name = "UserControlInventory";
            Size = new Size(984, 668);
            ((System.ComponentModel.ISupportInitialize)dgvinventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dgvinventory;
        private TextBox textBox1;
        private Label label1;
        private Button btnRefresh;
        private Label label2;
    }
}
