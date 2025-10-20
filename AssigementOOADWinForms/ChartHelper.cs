using System.Drawing;
using System.Drawing.Drawing2D;

namespace AssigementOOADWinForms
{
    public static class ChartHelper
    {
        private static GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // === DrawStockVsSales ===
        public static void DrawStockVsSales(Graphics g, string[] products, int[] stock, int[] sales, int width, int height)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var bgBrush = new LinearGradientBrush(new Rectangle(0, 0, width, height),
                Color.FromArgb(245, 247, 250), Color.FromArgb(230, 235, 240), 90f))
            {
                g.FillRectangle(bgBrush, 0, 0, width, height);
            }

            int count = products.Length;
            if (count == 0) return;

            int margin = 30;
            int barWidth = (width - 2 * margin) / (count * 2);
            int maxVal = Math.Max(Max(stock), Max(sales));
            maxVal = maxVal == 0 ? 1 : maxVal;

            using (var font = new Font("Segoe UI", 9, FontStyle.Bold))
            using (var textBrush = new SolidBrush(Color.FromArgb(51, 51, 51)))
            using (var borderPen = new Pen(Color.FromArgb(80, 80, 80), 1f))
            {
                for (int i = 0; i < count; i++)
                {
                    int x = margin + i * barWidth * 2;

                    int stockHeight = (int)((stock[i] / (float)maxVal) * (height - 60));
                    if (stockHeight < 1) stockHeight = 1;
                    Rectangle stockRect = new Rectangle(x, height - margin - stockHeight, barWidth, stockHeight);
                    using (var stockBrush = new LinearGradientBrush(stockRect, Color.MediumSeaGreen, Color.Honeydew, 90f))
                    using (var path = RoundedRect(stockRect, 6))
                    {
                        g.FillPath(stockBrush, path);
                        g.DrawPath(borderPen, path);
                    }

                    int salesHeight = (int)((sales[i] / (float)maxVal) * (height - 60));
                    if (salesHeight < 1) salesHeight = 1;
                    Rectangle salesRect = new Rectangle(x + barWidth, height - margin - salesHeight, barWidth, salesHeight);
                    using (var salesBrush = new LinearGradientBrush(salesRect, Color.DodgerBlue, Color.LightSkyBlue, 90f))
                    using (var path = RoundedRect(salesRect, 6))
                    {
                        g.FillPath(salesBrush, path);
                        g.DrawPath(borderPen, path);
                    }

                    using (var sf = new StringFormat { Alignment = StringAlignment.Center })
                        g.DrawString(products[i], font, textBrush, x + barWidth, height - margin + 5, sf);
                }
            }
        }

        // === DrawLineChart ===
        public static void DrawLineChart(Graphics g, string[] labels, int[] values, Color lineColor, string title, int width, int height)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Background
            using (var bg = new LinearGradientBrush(new Rectangle(0, 0, width, height),
                Color.FromArgb(245, 247, 250), Color.FromArgb(230, 235, 240), LinearGradientMode.Vertical))
            {
                g.FillRectangle(bg, 0, 0, width, height);
            }

            int count = labels.Length;
            if (count == 0) return;

            int margin = 40;
            int chartHeight = height - 2 * margin;
            int chartWidth = width - 2 * margin;
            int maxVal = Max(values);
            maxVal = maxVal == 0 ? 1 : maxVal;

            PointF[] points = new PointF[count];
            for (int i = 0; i < count; i++)
            {
                float x = margin + i * chartWidth / (float)(count - 1);
                float y = height - margin - (values[i] / (float)maxVal) * chartHeight;
                points[i] = new PointF(x, y);
            }

            using (GraphicsPath smoothPath = CreateSmoothCurve(points))
            using (Pen linePen = new Pen(lineColor, 2) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawPath(linePen, smoothPath);

                foreach (var p in points)
                {
                    using (SolidBrush halo = new SolidBrush(Color.FromArgb(70, lineColor)))
                        g.FillEllipse(halo, p.X - 6, p.Y - 6, 12, 12);
                    using (SolidBrush pointBrush = new SolidBrush(lineColor))
                        g.FillEllipse(pointBrush, p.X - 4, p.Y - 4, 8, 8);
                }
            }

            using (Font titleFont = new Font("Segoe UI", 10, FontStyle.Bold))
            using (Font labelFont = new Font("Segoe UI", 8))
            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(51, 51, 51)))
            {
                StringFormat center = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString(title, titleFont, textBrush, new PointF(width / 2f, 8), center);

                for (int i = 0; i < count; i++)
                    g.DrawString(labels[i], labelFont, textBrush, points[i].X, height - margin + 5, center);
            }

            using (Pen baseLine = new Pen(Color.FromArgb(220, 225, 230), 1))
                g.DrawLine(baseLine, margin, height - margin, width - margin, height - margin);
        }

        private static GraphicsPath CreateSmoothCurve(PointF[] points)
        {
            GraphicsPath path = new GraphicsPath();
            if (points.Length < 2) return path;
            path.AddCurve(points, 0.5f);
            return path;
        }

        private static int Max(int[] values)
        {
            int max = 0;
            foreach (int v in values)
                if (v > max) max = v;
            return max;
        }
    }
}
