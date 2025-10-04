using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Reflection;
public static class RoundedPanelHelper
{
    /// <summary>
    /// Apply rounded corners to any panel.
    /// </summary>
    /// <param name="panel">The panel to modify</param>
    /// <param name="borderRadius">Corner radius</param>
    /// <param name="borderColor">Optional border color</param>
    /// <param name="borderThickness">Optional border thickness</param>
    public static void ApplyRoundedStyle(Panel panel, int borderRadius = 20, Color? borderColor = null, int borderThickness = 0)
    {
        // Keep panel.BackColor as is; do not modify
        panel.BorderStyle = BorderStyle.None;

        // Enable double buffering
        typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                     .SetValue(panel, true, null);

        panel.Paint += (sender, e) =>
        {
            Rectangle rect = panel.ClientRectangle;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                // Clip panel to rounded corners
                panel.Region = new Region(path);

                // Optional border
                if (borderThickness > 0 && borderColor.HasValue)
                {
                    using (Pen pen = new Pen(borderColor.Value, borderThickness))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        };
    }
    private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int d = radius * 2;
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}
