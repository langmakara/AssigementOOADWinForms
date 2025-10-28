using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AssigementOOADWinForms
{
    public static class ChartHelper
    {
        // Create a rounded rectangle path
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

        // Draw Stock vs Sales chart (iOS 26 style, full rounded)
        public static void DrawStockVsSales(Graphics g, Rectangle bounds, string[] products, int[] sales, float progress = 1f)
        {
            if (products == null || products.Length == 0 || sales == null || sales.Length == 0)
                return;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Clip whole chart to rounded-lg
            using (var clipPath = RoundedRect(bounds, 30)) // 30 = large rounded corners
            {
                g.SetClip(clipPath);

                // Clear background (soft iOS color)
                g.Clear(Color.FromArgb(245, 247, 250));

                int count = products.Length;
                int marginTop = 20;
                int marginBottom = 30;
                int sidePadding = 20;
                int spacing = 8;
                int barWidth = (bounds.Width - 2 * sidePadding - (count - 1) * spacing) / count;
                int totalSales = TotalSales(sales);

                using (var font = new Font("Segoe UI", 9, FontStyle.Bold))
                using (var textBrush = new SolidBrush(Color.FromArgb(40, 40, 40)))
                using (var percentFont = new Font("Segoe UI", 8, FontStyle.Bold))
                using (var percentBrush = new SolidBrush(Color.White))
                using (var trackBrush = new SolidBrush(Color.FromArgb(50, 135, 206, 250))) // translucent azure track
                {
                    for (int i = 0; i < count; i++)
                    {
                        int x = sidePadding + i * (barWidth + spacing);

                        // Draw background track
                        Rectangle trackRect = new Rectangle(x, marginTop, barWidth, bounds.Height - marginTop - marginBottom);
                        using (var trackPath = RoundedRect(trackRect, 6))
                            g.FillPath(trackBrush, trackPath);

                        // Bar height proportional to total sales
                        int targetHeight = (int)((sales[i] / (float)totalSales) * (bounds.Height - marginTop - marginBottom));
                        int barHeight = (int)(targetHeight * Math.Min(progress, 1f));
                        if (barHeight < 1) barHeight = 1;

                        int y = bounds.Height - marginBottom - barHeight;
                        Rectangle rect = new Rectangle(x, y, barWidth, barHeight);

                        // Draw actual bar with gradient and subtle inner glow
                        using (var brush = new LinearGradientBrush(rect, Color.FromArgb(0, 122, 255), Color.FromArgb(100, 200, 255), 90f))
                        using (var path = RoundedRect(rect, 6))
                        {
                            g.FillPath(brush, path);

                            using (var glowBrush = new SolidBrush(Color.FromArgb(30, 255, 255, 255)))
                            {
                                Rectangle glowRect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height / 3);
                                using (var glowPath = RoundedRect(glowRect, 6))
                                    g.FillPath(glowBrush, glowPath);
                            }

                            // Draw product name (limit to 10 characters)
                            PointF textPoint = new PointF(rect.X + rect.Width / 2f, bounds.Height - marginBottom + 10);
                            string displayName = products[i].Length > 10 ? products[i].Substring(0, 10) + "..." : products[i];
                            g.DrawString(displayName, font, textBrush, textPoint,
                                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near });

                            // Draw percentage inside bar
                            float textY = rect.Y + rect.Height / 2f - 6;
                            if (textY < marginTop) textY = marginTop;
                            PointF percentPoint = new PointF(rect.X + rect.Width / 2f, textY);
                            float percentValue = (sales[i] / (float)totalSales) * 100f * Math.Min(progress, 1f);
                            g.DrawString($"{percentValue:0.0}%", percentFont, percentBrush, percentPoint,
                                new StringFormat { Alignment = StringAlignment.Center });
                        }
                    }
                }

                // Remove clip after drawing
                g.ResetClip();
            }
        }

        // Helper: total sales
        private static int TotalSales(int[] values)
        {
            int sum = 0;
            foreach (int v in values)
                sum += v;
            return sum == 0 ? 1 : sum; // avoid division by zero
        }
    }
}
