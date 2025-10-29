using AssigementOOADWinForms.Controls;
namespace AssigementOOADWinForms;
public partial class Mainform : Form
{
    public Mainform()
    {
        InitializeComponent();
        LbDash.Click += HandleClickDashBoard;
        LbInventory.Click += HandleClickInventory;
        Lbuser.Click += HandleClickUser;
        LbEmployee.Click += HandleClickEmployee;
        LbSupplier.Click += HandleClickSupplier;
        Lbproduct.Click += HandleClickProduct;
        LbInvoice.Click += HandleClickInvoice;
        LbPurchaseOrder.Click += HandleClickPurchaseOrder;
        LbPayment.Click += HandleClickPayment;
        LbReport.Click += HandleClickReport;
        LbAdjustment.Click += HandleClickAdjustment;
        LbInvoiceService.Click += HandleClickInvoiceService; 
        this.Load += Form1_Load;
    }

    private void LbInvoiceService_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void HandleClickInvoiceService(object? sender, EventArgs e)
    {
        var userControlInvoiceService = new UserControlInvoiceService();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbInvoiceService.Text;
        if (userControlInvoiceService != null)
        {
            panelMain.Controls.Add(userControlInvoiceService);
            userControlInvoiceService.Dock = DockStyle.Fill;
        }
    }
    private void HandleClickAdjustment(object? sender, EventArgs e)
    {
        var UserControlStockAdjustment = new UserControlStockAdjustment();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbAdjustment.Text;
        if (UserControlStockAdjustment != null)
        {
            panelMain.Controls.Add(UserControlStockAdjustment);
            UserControlStockAdjustment.Dock = DockStyle.Fill;
        }
    }

    private void Lbproduct_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
    public void HandleUserControlReplacseItselfMainForm(UserControl control, string title = "")
    {
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = title;
        control.Dock = DockStyle.Fill;
        panelMain.Controls.Add(control);
        control.BringToFront();
    }
    private void HandleClickDashBoard(object? sender, EventArgs e)
    {
        var userControlDashboard = new UserControlDashboard();
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
        var userControlInventory = new UserControlInventory();
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
        var userControlUser = new UserControlUser();
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
        var userControlEmployee = new UserControlEmployee();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbEmployee.Text;
        if (userControlEmployee != null)
        {
            panelMain.Controls.Add(userControlEmployee);
            userControlEmployee.Dock = DockStyle.Fill;
        }
    }
    private void HandleClickSupplier(object? sender, EventArgs e)
    {
        var userControlSupplier = new UserControlSupplier();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbSupplier.Text;
        if (userControlSupplier != null)
        {
            panelMain.Controls.Add(userControlSupplier);
            userControlSupplier.Dock = DockStyle.Fill;
        }
    }
    private void HandleClickProduct(object? sender, EventArgs args)
    {
        var userControlProduct = new UserControlProduct();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = Lbproduct.Text;
        if (userControlProduct != null)
        {
            panelMain.Controls.Add(userControlProduct);
            userControlProduct.Dock = DockStyle.Fill;
        }
    }
    private void HandleClickInvoice(object? sender, EventArgs e)
    {
        var userControlInvoice = new UserControlInvoice();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbInvoice.Text;
        if (userControlInvoice != null)
        {
            panelMain.Controls.Add(userControlInvoice);
            userControlInvoice.Dock = DockStyle.Fill;
        }
    }
    private void HandleClickPurchaseOrder(object? sender, EventArgs e)
    {
        var userControlPurchaseOrder = new UserControlPurchasOrder();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbPurchaseOrder.Text;
        if (userControlPurchaseOrder != null)
        {
            panelMain.Controls.Add(userControlPurchaseOrder);
            userControlPurchaseOrder.Dock = DockStyle.Fill;
        }
    }
    private void Form1_Load(object? sender, EventArgs e)
    {
        var userControlDashboard = new UserControlDashboard();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbDash.Text;
        if (userControlDashboard != null)
        {
            panelMain.Controls.Add(userControlDashboard);
            userControlDashboard.Dock = DockStyle.Fill;
        }
    }

    private void HandleClickPayment(object? sender, EventArgs e)
    {
        var UserControlPayment  = new UserControlPayment();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbPayment.Text;
        if (UserControlPayment != null)
        {
            panelMain.Controls.Add(UserControlPayment);
            UserControlPayment.Dock = DockStyle.Fill;
        }
    }

    private void HandleClickReport(object? sender, EventArgs e)
    {
        var UserControlReport = new UserControlReport();
        panelMain.Controls.Clear();
        LbPage.Text = "";
        LbPage.Text = LbReport.Text;
        if (UserControlReport != null)
        {
            panelMain.Controls.Add(UserControlReport);
            UserControlReport.Dock = DockStyle.Fill;
        }

    }

}
