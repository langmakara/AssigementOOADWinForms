using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Reflection;
public static class DesignHelper
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
    public static void StyleDataGridView(DataGridView dgv)
    {
        dgv.EnableHeadersVisualStyles = false;

        // Header style
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

        // Row style
        dgv.RowTemplate.Height = 28;
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.Black;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
        dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

        // Remove borders
        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgv.GridColor = Color.White;

        // Remove row headers
        dgv.RowHeadersVisible = false;

        // Fill columns to available width
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // Other settings
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
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
