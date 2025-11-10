

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
        NovaCompany = new Label();
        pictureBox2 = new PictureBox();
        panel1 = new Panel();
        pictureBox3 = new PictureBox();
        btLogin = new Button();
        lbExit = new Label();
        lbClearFields = new Label();
        tbUser = new TextBox();
        tbPassword = new TextBox();
        panel2 = new Panel();
        panel3 = new Panel();
        label2 = new Label();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // NovaCompany
        // 
        NovaCompany.Anchor = AnchorStyles.None;
        NovaCompany.AutoSize = true;
        NovaCompany.Font = new Font("Bauhaus 93", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        NovaCompany.ForeColor = Color.Red;
        NovaCompany.Location = new Point(74, 154);
        NovaCompany.Name = "NovaCompany";
        NovaCompany.Size = new Size(330, 50);
        NovaCompany.TabIndex = 1;
        NovaCompany.Text = "Nova Company";
        // 
        // pictureBox2
        // 
        pictureBox2.Anchor = AnchorStyles.None;
        pictureBox2.Image = Properties.Resources.user;
        pictureBox2.Location = new Point(43, 277);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(50, 50);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 2;
        pictureBox2.TabStop = false;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.None;
        panel1.BackColor = Color.FromArgb(0, 117, 214);
        panel1.Location = new Point(47, 340);
        panel1.Name = "panel1";
        panel1.Size = new Size(379, 1);
        panel1.TabIndex = 3;
        // 
        // pictureBox3
        // 
        pictureBox3.Anchor = AnchorStyles.None;
        pictureBox3.Image = Properties.Resources.padlock;
        pictureBox3.Location = new Point(43, 398);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(50, 50);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 4;
        pictureBox3.TabStop = false;
        // 
        // btLogin
        // 
        btLogin.Anchor = AnchorStyles.None;
        btLogin.BackColor = Color.FromArgb(0, 117, 214);
        btLogin.FlatAppearance.BorderSize = 0;
        btLogin.FlatStyle = FlatStyle.Flat;
        btLogin.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btLogin.ForeColor = Color.White;
        btLogin.Location = new Point(47, 550);
        btLogin.Name = "btLogin";
        btLogin.Size = new Size(379, 46);
        btLogin.TabIndex = 6;
        btLogin.Text = "LOG IN";
        btLogin.UseVisualStyleBackColor = false;
        btLogin.KeyPress += btLogin_KeyPress;
        // 
        // lbExit
        // 
        lbExit.Anchor = AnchorStyles.None;
        lbExit.AutoSize = true;
        lbExit.BackColor = SystemColors.Control;
        lbExit.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbExit.ForeColor = Color.FromArgb(0, 117, 214);
        lbExit.Location = new Point(193, 622);
        lbExit.Name = "lbExit";
        lbExit.Size = new Size(70, 29);
        lbExit.TabIndex = 7;
        lbExit.Text = "Close";
        lbExit.Click += lbExit_Click;
        // 
        // lbClearFields
        // 
        lbClearFields.Anchor = AnchorStyles.None;
        lbClearFields.AutoSize = true;
        lbClearFields.BackColor = SystemColors.Control;
        lbClearFields.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbClearFields.ForeColor = Color.FromArgb(0, 117, 214);
        lbClearFields.Location = new Point(298, 516);
        lbClearFields.Name = "lbClearFields";
        lbClearFields.Size = new Size(120, 26);
        lbClearFields.TabIndex = 8;
        lbClearFields.Text = "Clear Fields";
        lbClearFields.Click += lbClearFields_Click;
        // 
        // tbUser
        // 
        tbUser.Anchor = AnchorStyles.None;
        tbUser.BackColor = SystemColors.Control;
        tbUser.BorderStyle = BorderStyle.None;
        tbUser.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        tbUser.ForeColor = Color.FromArgb(0, 117, 214);
        tbUser.Location = new Point(116, 286);
        tbUser.Name = "tbUser";
        tbUser.Size = new Size(310, 31);
        tbUser.TabIndex = 9;
        // 
        // tbPassword
        // 
        tbPassword.Anchor = AnchorStyles.None;
        tbPassword.BackColor = SystemColors.Control;
        tbPassword.BorderStyle = BorderStyle.None;
        tbPassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        tbPassword.ForeColor = Color.FromArgb(0, 117, 214);
        tbPassword.Location = new Point(116, 412);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(310, 31);
        tbPassword.TabIndex = 10;
        // 
        // panel2
        // 
        panel2.Anchor = AnchorStyles.None;
        panel2.BackColor = Color.FromArgb(0, 117, 214);
        panel2.Location = new Point(47, 465);
        panel2.Name = "panel2";
        panel2.Size = new Size(379, 1);
        panel2.TabIndex = 11;
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.Control;
        panel3.Controls.Add(label2);
        panel3.Controls.Add(label1);
        panel3.Controls.Add(panel2);
        panel3.Controls.Add(tbPassword);
        panel3.Controls.Add(tbUser);
        panel3.Controls.Add(lbClearFields);
        panel3.Controls.Add(lbExit);
        panel3.Controls.Add(btLogin);
        panel3.Controls.Add(pictureBox3);
        panel3.Controls.Add(panel1);
        panel3.Controls.Add(pictureBox2);
        panel3.Controls.Add(NovaCompany);
        panel3.Dock = DockStyle.Right;
        panel3.Location = new Point(1042, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(445, 800);
        panel3.TabIndex = 12;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(57, 215);
        label2.Name = "label2";
        label2.Size = new Size(369, 20);
        label2.TabIndex = 13;
        label2.Text = "Welcome to Nova Company! Please log in to continue.";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.Black;
        label1.Location = new Point(72, 742);
        label1.Name = "label1";
        label1.Size = new Size(322, 20);
        label1.TabIndex = 12;
        label1.Text = "Make sure all fields are filled before logging in.";
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = Properties.Resources.kontakt_td4zgcpwpjf0ha6;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(1042, 800);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 13;
        pictureBox1.TabStop = false;
        // 
        // FormLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1487, 800);
        Controls.Add(pictureBox1);
        Controls.Add(panel3);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "FormLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "NovaCompany";
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Label NovaCompany;
    private PictureBox pictureBox2;
    private Panel panel1;
    private PictureBox pictureBox3;
    private Button btLogin;
    private Label lbExit;
    private Label lbClearFields;
    private TextBox tbUser;
    private TextBox tbPassword;
    private Panel panel2;
    private Panel panel3;
    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
}