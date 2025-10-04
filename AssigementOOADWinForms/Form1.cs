using System.ComponentModel;
using System.Net.Http.Json;
using AssigementOOADWinForms.Classes;
using AssigementOOADWinForms.Controls;

namespace AssigementOOADWinForms;

public partial class Form1 : Form
{
    private readonly HttpClient _httpClient;
    private UserControlDashboard? userControlDashboard;
    public Form1()
    {
        InitializeComponent();
        RoundedPanelHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
        RoundedPanelHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
        RoundedPanelHelper.ApplyRoundedStyle(panelMain, borderRadius: 5);
        userControlDashboard = new UserControlDashboard();
        LbDash.Click += HandleClickDashBoard;
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

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
