using System;
using System.Drawing;
using System.Windows.Forms;
using AssigementOOADWinForms.Services;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlDashboard : UserControl
    {
        private readonly ProductService productService = new();
        private string[] products = { "Product A", "Product B", "Product C" };
        private int[] stock = { 50, 30, 70 };
        private int[] sales = { 20, 15, 60 };

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

            // Style DataGridViews
            // For Low Stock table
          

            DesignHelper.StyleDataGridView(dataGridView1);
            DesignHelper.StyleDataGridView(DataViewOutOfStock);
            dataGridView1.CellPainting += DesignHelper.dataGridView1_CellPainting;
            DataViewOutOfStock.CellPainting += DesignHelper.dataGridView1_CellPainting;
  


            LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Totals
            label14.Text = Sum(stock).ToString();                // Total Stock Quantity
            label16.Text = CalculateTotalValue().ToString("C");  // Total Stock Value
            label18.Text = products.Length.ToString();           // Total Categories

           var lowStock = productService.GetProductLowStock();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = lowStock;
            var hiddenColumns = new List<string>
            {
            "ProductID",
            "SupplierID",
            "ReorderLevel",
            "CreatedAt"};
            DesignHelper.HideColumns(dataGridView1, hiddenColumns);


            DataViewOutOfStock.Rows.Clear();
            DataViewOutOfStock.Columns.Clear();
            DataViewOutOfStock.Columns.Add("Product", "Product");
            foreach (var item in outStockProducts)
            {
                DataViewOutOfStock.Rows.Add(item);
            }

            // Refresh charts
            pbStockVsSales.Invalidate();

        }

        #region Chart Paint Events
        private void PbStockVsSales_Paint(object sender, PaintEventArgs e)
        {
            ChartHelper.DrawStockVsSales(e.Graphics, products, stock, sales,
                pbStockVsSales.Width, pbStockVsSales.Height);
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
