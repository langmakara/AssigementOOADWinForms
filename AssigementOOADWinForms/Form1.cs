using AssigementOOADWinForms.Controls;

namespace AssigementOOADWinForms
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        private UserControlDashboard? userControlDashboard;
        private UserControlInventory? userControlInventory;
        private UserControlUser? userControlUser;
        private UserControlEmployee? userControlEmployee;
        private UserControlSupplier? userControlSupplier;
        private UserControlProduct? userControlProduct;

        // --- Animation helpers ---
        private bool isCollapsed = false;
        // --- Animation helpers ---
        private System.Windows.Forms.Timer sidebarTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            // --- Rounded corners (modern style) ---
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panelMain, borderRadius: 5);

            // --- Docking (responsiveness) ---
            panel2.Dock = DockStyle.Left;
            panel1.Dock = DockStyle.Top;
            panelMain.Dock = DockStyle.Fill;

            // --- Init user controls ---
            userControlDashboard = new UserControlDashboard();
            userControlInventory = new UserControlInventory();
            userControlUser = new UserControlUser();
            userControlEmployee = new UserControlEmployee();
            userControlSupplier = new UserControlSupplier();
            userControlProduct = new UserControlProduct();

            // --- Assign menu click handlers ---
            LbDash.Click += HandleClickDashBoard;
            LbInventory.Click += HandleClickInventory;
            Lbuser.Click += HandleClickUser;
            LbEmployee.Click += HandleClickEmployee;
            LbSupplier.Click += HandleClickSupplier;
            Lbproduct.Click += HandleClickProduct;

            // --- Hover animation for labels ---
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.MouseEnter += (s, e) => lbl.ForeColor = Color.Yellow;
                    lbl.MouseLeave += (s, e) => lbl.ForeColor = Color.White;
                }
            }

            // --- Sidebar animation ---
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += SidebarTimer_Tick;
            pictureBox13.Click += (s, e) => sidebarTimer.Start(); // lotus logo collapse/expand

            // --- Fade-in animation ---
            fadeTimer.Interval = 30;
            fadeTimer.Tick += FadeTimer_Tick;

            this.Load += Form1_Load;
        }

        // --- Navigation handlers ---
        private void HandleClickDashBoard(object? sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            LbPage.Text = LbDash.Text;
            if (userControlDashboard != null)
            {
                panelMain.Controls.Add(userControlDashboard);
                userControlDashboard.Dock = DockStyle.Fill;
            }
        }

        private void HandleClickInventory(object? sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            LbPage.Text = LbInventory.Text;
            if (userControlInventory != null)
            {
                panelMain.Controls.Add(userControlInventory);
                userControlInventory.Dock = DockStyle.Fill;
            }
        }

        private void HandleClickUser(object? sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            LbPage.Text = Lbuser.Text;
            if (userControlUser != null)
            {
                panelMain.Controls.Add(userControlUser);
                userControlUser.Dock = DockStyle.Fill;
            }
        }

        private void HandleClickEmployee(object? sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            LbPage.Text = LbEmployee.Text;
            if (userControlEmployee != null)
            {
                panelMain.Controls.Add(userControlEmployee);
                userControlEmployee.Dock = DockStyle.Fill;
            }
        }

        private void HandleClickSupplier(object? sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            LbPage.Text = LbSupplier.Text;
            if (userControlSupplier != null)
            {
                panelMain.Controls.Add(userControlSupplier);
                userControlSupplier.Dock = DockStyle.Fill;
            }
        }

        private void HandleClickProduct(object? sender, EventArgs args)
        {
            panelMain.Controls.Clear();
            LbPage.Text = Lbproduct.Text;
            if (userControlProduct != null)
            {
                panelMain.Controls.Add(userControlProduct);
                userControlProduct.Dock = DockStyle.Fill;
            }
        }

        // --- Form load: show Dashboard + fade-in effect ---
        private void Form1_Load(object? sender, EventArgs e)
        {
            this.Opacity = 0; // fade start
            fadeTimer.Start();

            panelMain.Controls.Clear();
            LbPage.Text = LbDash.Text;
            if (userControlDashboard != null)
            {
                panelMain.Controls.Add(userControlDashboard);
                userControlDashboard.Dock = DockStyle.Fill;
            }
        }

        // --- Sidebar animation ---
        private void SidebarTimer_Tick(object? sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel2.Width += 10; // expand
                if (panel2.Width >= 200)
                {
                    sidebarTimer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel2.Width -= 10; // collapse
                if (panel2.Width <= 60)
                {
                    sidebarTimer.Stop();
                    isCollapsed = true;
                }
            }
        }

        // --- Fade-in animation ---
        private void FadeTimer_Tick(object? sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                fadeTimer.Stop();
        }
    }
}
