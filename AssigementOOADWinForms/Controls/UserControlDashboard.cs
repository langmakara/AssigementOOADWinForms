using System;
using System.Drawing;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlDashboard : UserControl
    {
        // Sample data (replace with database)
        private string[] products = { "Product A", "Product B", "Product C" };
        private int[] stock = { 50, 30, 70 };
        private int[] sales = { 20, 15, 60 };

        // Monthly data
        private string[] dates = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private int[] salesTrend = { 120, 150, 130, 160, 180, 200, 210, 190, 220, 230, 210, 240 };
        private int[] stockTrend = { 50, 45, 40, 35, 55, 60, 70, 65, 60, 55, 50, 45 };

        private string[] lowStockProducts = { "Product B - 3", "Product A - 5" };
        private string[] outStockProducts = { "Product X ❌", "Product Y ❌" };

        public UserControlDashboard()
        {
            InitializeComponent();

            // Rounded panels
            DesignHelper.ApplyRoundedStyle(panel3, 5);
            DesignHelper.ApplyRoundedStyle(panel4, 5);
            DesignHelper.ApplyRoundedStyle(panel5, 5);

            // Charts paint events
            pbStockVsSales.Paint += PbStockVsSales_Paint;
            pbStockTrend.Paint += PbStockTrend_Paint;
            pbSalesTrend.Paint += PbSalesTrend_Paint;

            // Style DataGridViews
            // For Low Stock table
          

            DesignHelper.StyleDataGridView(dataGridView1);
            DesignHelper.StyleDataGridView(DataViewOutOfStock);



            LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Totals
            label14.Text = Sum(stock).ToString();                // Total Stock Quantity
            label16.Text = CalculateTotalValue().ToString("C");  // Total Stock Value
            label18.Text = products.Length.ToString();           // Total Categories

            // Low-stock table
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Product", "Product");
            dataGridView1.Columns.Add("Qty", "Quantity");
            foreach (var item in lowStockProducts)
            {
                var parts = item.Split(" - ");
                dataGridView1.Rows.Add(parts[0], parts.Length > 1 ? parts[1] : "");
            }

            // Out-of-stock table
            DataViewOutOfStock.Rows.Clear();
            DataViewOutOfStock.Columns.Clear();
            DataViewOutOfStock.Columns.Add("Product", "Product");
            foreach (var item in outStockProducts)
            {
                DataViewOutOfStock.Rows.Add(item);
            }

            // Refresh charts
            pbStockVsSales.Invalidate();
            pbStockTrend.Invalidate();
            pbSalesTrend.Invalidate();
        }

        #region Chart Paint Events
        private void PbStockVsSales_Paint(object sender, PaintEventArgs e)
        {
            ChartHelper.DrawStockVsSales(e.Graphics, products, stock, sales,
                pbStockVsSales.Width, pbStockVsSales.Height);
        }

        private void PbStockTrend_Paint(object sender, PaintEventArgs e)
        {
            ChartHelper.DrawLineChart(e.Graphics, dates, stockTrend, Color.MediumSeaGreen, "Monthly Stock Trend",
                pbStockTrend.Width, pbStockTrend.Height);
        }

        private void PbSalesTrend_Paint(object sender, PaintEventArgs e)
        {
            ChartHelper.DrawLineChart(e.Graphics, dates, salesTrend, Color.DodgerBlue, "Monthly Sales Trend",
                pbSalesTrend.Width, pbSalesTrend.Height);
        }
        #endregion

        #region Helper Methods
        private int Sum(int[] arr)
        {
            int total = 0;
            foreach (var v in arr) total += v;
            return total;
        }

        private decimal CalculateTotalValue()
        {
            decimal total = 0;
            for (int i = 0; i < stock.Length; i++)
                total += stock[i] * 10; // example price
            return total;
        }  
        #endregion
    }
}
