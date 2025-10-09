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
    private UserControlCustomer? userControlCustomer;
    private UserControlProduct? userControlProduct;
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
        userControlCustomer = new UserControlCustomer();
        userControlProduct = new UserControlProduct();


        LbDash.Click += HandleClickDashBoard;
        LbInventory.Click += HandleClickInventory;
        Lbuser.Click += HandleClickUser;
        LbEmployee.Click += HandleClickEmployee;
        LbSupplier.Click += HandleClickSupplier;
        LbCustomer.Click += HandleClickCustomer;
        Lbproduct.Click += HandleClickProduct;
        this.Load += Form1_Load;

    }

    private void Lbproduct_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
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
    private void HandleClickCustomer(object? sender, EventArgs args)
    {
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbCustomer.Text;
        if (userControlCustomer != null) {
            panelMain.Controls.Add(userControlCustomer);
            userControlCustomer.Dock = DockStyle.Fill;
        }
    }
    private void HandleClickProduct(object? sender, EventArgs args)
    {
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = Lbproduct.Text;
        if (userControlProduct != null)
        {
            panelMain.Controls.Add(userControlProduct);
            userControlProduct.Dock = DockStyle.Fill;
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
