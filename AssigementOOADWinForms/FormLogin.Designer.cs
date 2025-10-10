

namespace AssigementOOADWinForms;

partial class FormLogin
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pictureBox1 = new PictureBox();
        NovaCompany = new Label();
        pictureBox2 = new PictureBox();
        panel1 = new Panel();
        panel2 = new Panel();
        pictureBox3 = new PictureBox();
        btLogin = new Button();
        lbExit = new Label();
        lbClearFields = new Label();
        tbUser = new TextBox();
        tbPassword = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Top;
        pictureBox1.Image = Properties.Resources.icons8_pink_lotus_flower_100;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(381, 123);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // NovaCompany
        // 
        NovaCompany.Anchor = AnchorStyles.None;
        NovaCompany.AutoSize = true;
        NovaCompany.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        NovaCompany.ForeColor = Color.FromArgb(0, 117, 124);
        NovaCompany.Location = new Point(44, 126);
        NovaCompany.Name = "NovaCompany";
        NovaCompany.Size = new Size(289, 45);
        NovaCompany.TabIndex = 1;
        NovaCompany.Text = "NovaCompany";
        // 
        // pictureBox2
        // 
        pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox2.Image = Properties.Resources.user;
        pictureBox2.Location = new Point(65, 216);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(25, 25);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 2;
        pictureBox2.TabStop = false;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panel1.BackColor = Color.FromArgb(0, 117, 214);
        panel1.Location = new Point(65, 247);
        panel1.Name = "panel1";
        panel1.Size = new Size(236, 1);
        panel1.TabIndex = 3;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(0, 117, 214);
        panel2.Location = new Point(65, 322);
        panel2.Name = "panel2";
        panel2.Size = new Size(236, 1);
        panel2.TabIndex = 5;
        // 
        // pictureBox3
        // 
        pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox3.Image = Properties.Resources.padlock;
        pictureBox3.Location = new Point(65, 291);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(25, 25);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 4;
        pictureBox3.TabStop = false;
        // 
        // btLogin
        // 
        btLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btLogin.BackColor = Color.FromArgb(0, 117, 214);
        btLogin.FlatAppearance.BorderSize = 0;
        btLogin.FlatStyle = FlatStyle.Flat;
        btLogin.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btLogin.ForeColor = Color.White;
        btLogin.Location = new Point(65, 369);
        btLogin.Name = "btLogin";
        btLogin.Size = new Size(236, 46);
        btLogin.TabIndex = 6;
        btLogin.Text = "LOG IN";
        btLogin.UseVisualStyleBackColor = false;
        btLogin.Click += btLogin_Click_1;
        // 
        // lbExit
        // 
        lbExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbExit.AutoSize = true;
        lbExit.BackColor = Color.White;
        lbExit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbExit.ForeColor = Color.FromArgb(0, 117, 214);
        lbExit.Location = new Point(163, 431);
        lbExit.Name = "lbExit";
        lbExit.Size = new Size(57, 20);
        lbExit.TabIndex = 7;
        lbExit.Text = "Close";
        lbExit.Click += lbExit_Click;
        // 
        // lbClearFields
        // 
        lbClearFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lbClearFields.AutoSize = true;
        lbClearFields.BackColor = Color.White;
        lbClearFields.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbClearFields.ForeColor = Color.FromArgb(0, 117, 214);
        lbClearFields.Location = new Point(196, 346);
        lbClearFields.Name = "lbClearFields";
        lbClearFields.Size = new Size(105, 20);
        lbClearFields.TabIndex = 8;
        lbClearFields.Text = "ClearFields";
        lbClearFields.Click += lbClearFields_Click;
        // 
        // tbUser
        // 
        tbUser.BorderStyle = BorderStyle.None;
        tbUser.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        tbUser.ForeColor = Color.FromArgb(0, 117, 214);
        tbUser.Location = new Point(101, 216);
        tbUser.Name = "tbUser";
        tbUser.Size = new Size(200, 21);
        tbUser.TabIndex = 9;
        // 
        // tbPassword
        // 
        tbPassword.BorderStyle = BorderStyle.None;
        tbPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
        tbPassword.ForeColor = Color.FromArgb(0, 117, 214);
        tbPassword.Location = new Point(101, 289);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(200, 21);
        tbPassword.TabIndex = 10;
        // 
        // FormLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(381, 555);
        Controls.Add(tbPassword);
        Controls.Add(tbUser);
        Controls.Add(lbClearFields);
        Controls.Add(lbExit);
        Controls.Add(btLogin);
        Controls.Add(panel2);
        Controls.Add(pictureBox3);
        Controls.Add(panel1);
        Controls.Add(pictureBox2);
        Controls.Add(NovaCompany);
        Controls.Add(pictureBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "FormLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "NovaCompany";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label NovaCompany;
    private PictureBox pictureBox2;
    private Panel panel1;
    private Panel panel2;
    private PictureBox pictureBox3;
    private Button btLogin;
    private Label lbExit;
    private Label lbClearFields;
    private TextBox tbUser;
    private TextBox tbPassword;
}