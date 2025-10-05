using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AssigementOOADWinForms.DTOs;

namespace AssigementOOADWinForms.Controls.ComponentControl
{
    public partial class UserControlComponentProductCard : UserControl
    {
        public UserControlComponentProductCard()
        {
            InitializeComponent();
        }

        // 🔹 Create fake products (temporary data)
        public static List<Product> GetFakeProducts()
        {
            string basePath = Path.Combine(Application.StartupPath, "Images");

            return new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Cake 1", UnitPrice = 5, QuantityInStock = 10, ImageUrl = Path.Combine(basePath, "Cake1.jpg") },
                new Product { ProductID = 2, ProductName = "Cake 2", UnitPrice = 6, QuantityInStock = 8, ImageUrl = Path.Combine(basePath, "Cake2.jpg") },
                new Product { ProductID = 3, ProductName = "Cake 3", UnitPrice = 4, QuantityInStock = 0, ImageUrl = Path.Combine(basePath, "Cake3.jpg") },
                new Product { ProductID = 4, ProductName = "Cake 4", UnitPrice = 7, QuantityInStock = 12, ImageUrl = Path.Combine(basePath, "Cake4.jpg") },
                new Product { ProductID = 5, ProductName = "Cake 5", UnitPrice = 5, QuantityInStock = 15, ImageUrl = Path.Combine(basePath, "Cake5.jpg") },
                new Product { ProductID = 6, ProductName = "Cake 6", UnitPrice = 8, QuantityInStock = 9, ImageUrl = Path.Combine(basePath, "Cake6.jpg") },
                new Product { ProductID = 7, ProductName = "Cake 7", UnitPrice = 6, QuantityInStock = 7, ImageUrl = Path.Combine(basePath, "Cake7.jpg") }
            };
        }

        // 🔹 Fill card with product data
        public void SetData(Product p)
        {
            Lbproduct.Text = p.ProductName;
            Lbprice.Text = $"${p.UnitPrice:N2}";
            Lbdescription.Text = p.QuantityInStock > 0 ? "In Stock" : "Out of Stock";

            try
            {
                if (File.Exists(p.ImageUrl))
                {
                    pictureBox1.Image = Image.FromFile(p.ImageUrl); // Load from local folder
                }
                else
                {
                    pictureBox1.Load(p.ImageUrl); // Or from URL
                }

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                pictureBox1.Image = null;
                pictureBox1.BackColor = Color.LightGray;
            }
        }
    }
}
