namespace AssigementOOADWinForms.Controls.ComponentControl;
partial class UserControlComponentProductCard
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
        pictureBox1 = new PictureBox();
        Lbproduct = new Label();
        Lbprice = new Label();
        Lbdescription = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.White;
        pictureBox1.Location = new Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(340, 234);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // Lbproduct
        // 
        Lbproduct.AutoSize = true;
        Lbproduct.Cursor = Cursors.Hand;
        Lbproduct.Font = new Font("Segoe UI", 15F);
        Lbproduct.ForeColor = Color.White;
        Lbproduct.Location = new Point(3, 240);
        Lbproduct.Name = "Lbproduct";
        Lbproduct.Size = new Size(85, 28);
        Lbproduct.TabIndex = 72;
        Lbproduct.Text = "Product:";
        // 
        // Lbprice
        // 
        Lbprice.AutoSize = true;
        Lbprice.Cursor = Cursors.Hand;
        Lbprice.Font = new Font("Segoe UI", 15F);
        Lbprice.ForeColor = Color.White;
        Lbprice.Location = new Point(3, 268);
        Lbprice.Name = "Lbprice";
        Lbprice.Size = new Size(58, 28);
        Lbprice.TabIndex = 73;
        Lbprice.Text = "Price:";
        // 
        // Lbdescription
        // 
        Lbdescription.AutoSize = true;
        Lbdescription.Cursor = Cursors.Hand;
        Lbdescription.Font = new Font("Segoe UI", 15F);
        Lbdescription.ForeColor = Color.White;
        Lbdescription.Location = new Point(3, 296);
        Lbdescription.Name = "Lbdescription";
        Lbdescription.Size = new Size(112, 28);
        Lbdescription.TabIndex = 74;
        Lbdescription.Text = "Description";
        // 
        // UserControlConponentProductCard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DodgerBlue;
        Controls.Add(Lbdescription);
        Controls.Add(Lbprice);
        Controls.Add(Lbproduct);
        Controls.Add(pictureBox1);
        Name = "UserControlConponentProductCard";
        Size = new Size(346, 324);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label Lbproduct;
    private Label Lbprice;
    private Label Lbdescription;
}
