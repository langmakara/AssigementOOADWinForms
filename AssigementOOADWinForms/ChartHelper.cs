using System.Drawing;

namespace AssigementOOADWinForms
{
    public static class ChartHelper
    {
        public static void DrawStockVsSales(Graphics g, string[] products, int[] stock, int[] sales, int width, int height)
        {
            g.Clear(Color.White);
            int count = products.Length;
            if (count == 0) return;

            int margin = 30;
            int barWidth = (width - 2 * margin) / (count * 2);
            int maxVal = Math.Max(Max(stock), Max(sales));
            maxVal = maxVal == 0 ? 1 : maxVal;

            for (int i = 0; i < count; i++)
            {
                int x = margin + i * barWidth * 2;

                // Stock bar
                int stockHeight = (int)((stock[i] / (float)maxVal) * (height - 60));
                g.FillRectangle(new SolidBrush(Color.MediumSeaGreen), x, height - margin - stockHeight, barWidth, stockHeight);
                // Sales bar
                int salesHeight = (int)((sales[i] / (float)maxVal) * (height - 60));
                g.FillRectangle(new SolidBrush(Color.DodgerBlue), x + barWidth, height - margin - salesHeight, barWidth, salesHeight);

                // Product label
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString(products[i], new Font("Segoe UI", 8), Brushes.Black, x + barWidth, height - margin + 5, sf);
            }
        }

        public static void DrawLineChart(Graphics g, string[] labels, int[] values, Color lineColor, string title, int width, int height)
        {
            g.Clear(Color.White);
            int count = labels.Length;
            if (count == 0) return;

            int margin = 40;
            int chartHeight = height - 2 * margin;
            int chartWidth = width - 2 * margin;
            int maxVal = Max(values);
            maxVal = maxVal == 0 ? 1 : maxVal;

            // Draw lines
            for (int i = 0; i < count - 1; i++)
            {
                int x1 = margin + i * chartWidth / (count - 1);
                int y1 = height - margin - (int)((values[i] / (float)maxVal) * chartHeight);
                int x2 = margin + (i + 1) * chartWidth / (count - 1);
                int y2 = height - margin - (int)((values[i + 1] / (float)maxVal) * chartHeight);
                g.DrawLine(new Pen(lineColor, 2), x1, y1, x2, y2);
                g.FillEllipse(new SolidBrush(lineColor), x1 - 3, y1 - 3, 6, 6);
            }

            // Last point
            int lastX = margin + (count - 1) * chartWidth / (count - 1);
            int lastY = height - margin - (int)((values[count - 1] / (float)maxVal) * chartHeight);
            g.FillEllipse(new SolidBrush(lineColor), lastX - 3, lastY - 3, 6, 6);

            // Draw title
            g.DrawString(title, new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, new PointF(width / 2 - 40, 5));

            // Draw labels
            for (int i = 0; i < count; i++)
            {
                int x = margin + i * chartWidth / (count - 1);
                g.DrawString(labels[i], new Font("Segoe UI", 8), Brushes.Black, x - 10, height - margin + 5);
            }
        }

        private static int Max(int[] arr)
        {
            int max = 0;
            foreach (var v in arr)
                if (v > max) max = v;
            return max;
        }

    }
}
