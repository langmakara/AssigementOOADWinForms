using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Reflection;
using AssigementOOADWinForms.Controls;

public static class DesignHelper
{
    // --- Apply Rounded Style to Panel ---
    public static void ApplyRoundedStyle(Panel panel, int borderRadius = 20, Color? borderColor = null, int borderThickness = 0)
    {
        panel.BorderStyle = BorderStyle.None;

        typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                     .SetValue(panel, true, null);

        panel.Paint += (sender, e) =>
        {
            Rectangle rect = panel.ClientRectangle;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                panel.Region = new Region(path);

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

    // --- Style DataGridView ---
    public static void StyleDataGridView(DataGridView dgv)
    {
        dgv.EnableHeadersVisualStyles = false;

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

        dgv.RowTemplate.Height = 30;
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.Black;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
        dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgv.GridColor = Color.White;
        dgv.RowHeadersVisible = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
    }

    // --- Circular Button ---
    public static void MakeCircular(Button btn)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, btn.Width, btn.Height);
        btn.Region = new Region(path);
    }

    // --- CellPainting for DataGridView ---
    public static void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            int padding = 4;
            Rectangle rect = new Rectangle(
                e.CellBounds.Left + padding,
                e.CellBounds.Top + padding,
                e.CellBounds.Width - (padding * 2),
                e.CellBounds.Height - (padding * 2)
            );

            e.PaintBackground(e.CellBounds, true);

            using (Brush glassBrush = new LinearGradientBrush(
                rect,
                Color.FromArgb(80, Color.White),
                Color.FromArgb(30, Color.Gray),
                90f))
            {
                e.Graphics.FillRectangle(glassBrush, rect);
            }
            e.PaintContent(rect);
            e.Handled = true;
        }
    }

    // --- Rounded TextBox and ComboBox ---
    public static void MakeAllInputsRounded(Control parent, int radius = 20)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is TextBox txt)
            {
                ApplyRoundedRegion(txt, radius);
            }
            else if (control is ComboBox cbo)
            {
                ApplyRoundedRegion(cbo, radius);
            }
            else if (control.HasChildren)
            {
                MakeAllInputsRounded(control, radius);
            }
        }
    }

    // ✅ Round a single TextBox safely
    private static void ApplyRoundedRegion(TextBox txt, int radius)
    {
        txt.BorderStyle = BorderStyle.None;
        txt.Region = new Region(GetRoundedPath(txt.ClientRectangle, radius));
        txt.Resize += (s, e) =>
        {
            txt.Region = new Region(GetRoundedPath(txt.ClientRectangle, radius));
        };
    }

    // ✅ Round a single ComboBox safely
    private static void ApplyRoundedRegion(ComboBox cbo, int radius)
    {
        cbo.FlatStyle = FlatStyle.Flat;
        cbo.Region = new Region(GetRoundedPath(cbo.ClientRectangle, radius));
        cbo.Resize += (s, e) =>
        {
            cbo.Region = new Region(GetRoundedPath(cbo.ClientRectangle, radius));
        };
    }

    // ✅ Shared Rounded Path Helper
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
