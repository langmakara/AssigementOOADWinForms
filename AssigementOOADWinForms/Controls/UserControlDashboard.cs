using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AssigementOOADWinForms.Services;
using Timer = System.Windows.Forms.Timer;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlDashboard : UserControl
    {
        private readonly ProductService productService = new();
        private readonly InvoiceDetailService invoiceDetailService = new();
        private string[] products = { };
        private int[] sales = { };
        private float animationProgress = 0f;
        private Timer animationTimer;

        public UserControlDashboard()
        {
            InitializeComponent();


            DesignHelper.StyleDataGridView(dataGridView1);
            DesignHelper.StyleDataGridView(DataViewOutOfStock);

            this.Load += (s, e) => LoadDashboard();

            // Double buffering for smooth animation
            pbStockVsSales.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(pbStockVsSales, true, null);

            pbStockVsSales.Paint += PbStockVsSales_Paint;

            // Timer for one-time animation
            animationTimer = new Timer();
            animationTimer.Interval = 20; // ~50 FPS
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void LoadDashboard()
        {
            var AllProduct = productService.GetAllProducts();
            int totalQuantity = AllProduct.AsEnumerable().Sum(row => row.Field<int>("QuantityInStock"));
            decimal TotalValue = AllProduct.AsEnumerable().Sum(row => row.Field<decimal>("UnitPrice"));
            int Coount = AllProduct.AsEnumerable().Count(row => row.Field<int?>("ProductID").HasValue);

            labelTotalValue.Text = TotalValue.ToString("C");
            labelTotalStock.Text = totalQuantity.ToString();
            labelTotalProduct.Text = Coount.ToString();

            var lowStock = productService.GetProductLowStock();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lowStock;
            var hiddenlowStock = new List<string> { "ProductID", "SupplierID", "ReorderLevel", "CreatedAt","UnitPrice" };
            DesignHelper.HideColumns(dataGridView1, hiddenlowStock);

            var outStock = productService.GetProductOutOfStock();
            DataViewOutOfStock.DataSource = null;
            DataViewOutOfStock.DataSource = outStock;
            var hiddenoutStock = new List<string> { "ProductID", "SupplierID", "ReorderLevel", "CreatedAt", "QuantityInStock" };
            DesignHelper.HideColumns(DataViewOutOfStock, hiddenoutStock);

            var productStockAndSaleAndName = invoiceDetailService.GetAllInvoiceDetails();
            var top5Products = productStockAndSaleAndName
                .GroupBy(p => p.ProductName)
                .Select(g => new { ProductName = g.Key, TotalSold = g.Sum(p => p.Quantity) })
                .OrderByDescending(x => x.TotalSold)
                .Take(5)
                .ToList();

            products = top5Products.Select(p => p.ProductName).ToArray();
            sales = top5Products.Select(p => p.TotalSold).ToArray();

            animationProgress = 0f;
            animationTimer.Start(); // Start animation once
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationProgress += 0.02f; // increase progress
            if (animationProgress >= 1f)
            {
                animationProgress = 1f;
                animationTimer.Stop(); // stop after reaching full height
            }

            pbStockVsSales.Invalidate(); // repaint PictureBox
        }

        private void PbStockVsSales_Paint(object sender, PaintEventArgs e)
        {
            ChartHelper.DrawStockVsSales(e.Graphics, pbStockVsSales.ClientRectangle, products, sales, animationProgress);
        }
    }
}
