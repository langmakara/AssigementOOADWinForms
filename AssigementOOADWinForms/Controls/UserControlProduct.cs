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
            flpProducts.FlowDirection = FlowDirection.LeftToRight;
            flpProducts.WrapContents = true;
            flpProducts.AutoScroll = true;

            this.Load += HandleLoadProduct;
            flpProducts.Resize += HandleResizeProducts;
        }
        private void HandleLoadProduct(object? sender, EventArgs e)
        {
            LoadProducts();
        }

        private void HandleResizeProducts(object? sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            flpProducts.Controls.Clear();

            int columns = 2;
            var products = UserControlComponentProductCard.GetFakeProducts();

            TableLayoutPanel tblProducts = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = columns,
                AutoSize = true,
                AutoScroll = true
            };

            for (int i = 0; i < columns; i++)
                tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));

            int row = 0;
            foreach (var p in products)
            {
                if (tblProducts.RowCount <= row)
                {
                    tblProducts.RowCount++;
                    tblProducts.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
                var card = new UserControlComponentProductCard();
                card.SetData(p);
                card.Dock = DockStyle.Fill;
                card.Margin = new Padding(1);

                int col = tblProducts.Controls.Count % columns;
                tblProducts.Controls.Add(card, col, row);

                if (col == columns - 1)
                    row++;
            }
            flpProducts.Controls.Add(tblProducts);
        }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
