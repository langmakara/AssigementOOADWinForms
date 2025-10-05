using System;
using System.Drawing;
using System.Windows.Forms;
using AssigementOOADWinForms.Controls.ComponentControl;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlProduct : UserControl
    {
        public UserControlProduct()
        {
            InitializeComponent();
            this.Load += HandleLoadProduct; // ✅ Automatically load on startup
        }

        private void HandleLoadProduct(object? sender, EventArgs e)
        {
            flpProducts.Controls.Clear(); // FlowLayoutPanel (from Designer)

            var products = UserControlComponentProductCard.GetFakeProducts();

            foreach (var p in products)
            {
                var card = new UserControlComponentProductCard();
                card.SetData(p);
                card.Width = 346;
                card.Height = 324;
                card.Margin = new Padding(10);

                flpProducts.Controls.Add(card);
            }
        }
    }
}
