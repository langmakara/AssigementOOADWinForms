using AssigementOOADWinForms.Controls;
namespace AssigementOOADWinForms;
public partial class Form1 : Form
{
    private readonly HttpClient _httpClient;
    private UserControlDashboard? userControlDashboard;
    private UserControlInventory? userControlInventory;
    private UserControlUser? userControlUser;
    private UserControlEmployee? userControlEmployee;
    private UserControlSupplier? userControlSupplier;
    public Form1()
    {
        InitializeComponent();
        DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
        DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
        DesignHelper.ApplyRoundedStyle(panelMain, borderRadius: 5);
        userControlDashboard = new UserControlDashboard();
        userControlInventory = new UserControlInventory();
        userControlUser = new UserControlUser();
        userControlEmployee = new UserControlEmployee();
        userControlSupplier = new UserControlSupplier();
        LbDash.Click += HandleClickDashBoard;
        LbInventory.Click += HandleClickInventory;
        Lbuser.Click += HandleClickUser;
        LbEmployee.Click += HandleClickEmployee;
        LbSupplier.Click += HandleClickSupplier;
        this.Load += Form1_Load;

    }
    private void HandleClickDashBoard(object? sender, EventArgs e)
    {
        panelMain.Controls.Clear();
        LbPage.Text = "";
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
        LbPage.Text = "";
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
        LbPage.Text = "";
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
        LbPage.Text = "";
        LbPage.Text = LbEmployee.Text;
        if (userControlEmployee != null) {
            panelMain.Controls.Add(userControlEmployee);
            userControlEmployee.Dock = DockStyle.Fill;
        }
    }
    private void HandleClickSupplier(object? sender, EventArgs e)
    {
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbSupplier.Text;
        if (userControlSupplier != null)
        {
            panelMain.Controls.Add(userControlSupplier);
            userControlSupplier.Dock = DockStyle.Fill;
        }
    }
    private void Form1_Load(object? sender, EventArgs e)
    {
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbDash.Text;
        if (userControlDashboard != null)
        {
            panelMain.Controls.Add(userControlDashboard);
            userControlDashboard.Dock = DockStyle.Fill;
        }
    }
}
