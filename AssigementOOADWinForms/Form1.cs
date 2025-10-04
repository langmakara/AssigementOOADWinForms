using System.Net.Http.Json;
using AssigementOOADWinForms.Classes;
namespace AssigementOOADWinForms;
public partial class Form1 : Form
{
    private readonly HttpClient _httpClient;
    public Form1()
    {
        InitializeComponent();
        RoundedPanelHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
        RoundedPanelHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
        RoundedPanelHelper.ApplyRoundedStyle(panel3, borderRadius: 5);
        RoundedPanelHelper.ApplyRoundedStyle(panel4, borderRadius: 5);
        RoundedPanelHelper.ApplyRoundedStyle(panel5, borderRadius: 5);
    }
}


