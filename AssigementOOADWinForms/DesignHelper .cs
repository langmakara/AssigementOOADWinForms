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
        dgv.ColumnHeadersHeight = 50; // <-- Set your desired header height here
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv.EnableHeadersVisualStyles = false;

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

        dgv.RowTemplate.Height = 40;
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
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw clean background
            Color backColor = (e.RowIndex % 2 == 0) ? Color.White : Color.FromArgb(245, 245, 245);
            using (SolidBrush brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.CellBounds);
            }

            // Draw selection highlight like iOS
            if ((e.State & DataGridViewElementStates.Selected) != 0)
            {
                using (SolidBrush selBrush = new SolidBrush(Color.FromArgb(50, Color.DodgerBlue)))
                {
                    e.Graphics.FillRectangle(selBrush, e.CellBounds);
                }
            }

            // Draw the cell text
            e.PaintContent(e.CellBounds);

            // Optional: subtle cell border
            using (Pen pen = new Pen(Color.FromArgb(220, 220, 220)))
            {
                e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
            }

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

        void updateRegion()
        {
            using (var path = GetRoundedPath(txt.ClientRectangle, radius))
            {
                txt.Region?.Dispose();
                txt.Region = new Region(path);
            }
        }

        txt.Resize += (s, e) => updateRegion();
        updateRegion();
    }

    // ✅ Helper: Build rounded corner path
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

    public static void HideColumns(DataGridView dgv, List<string> columnsToHide)
    {
        if (dgv == null || columnsToHide == null)
            return;

        foreach (string colName in columnsToHide)
        {
            if (dgv.Columns.Contains(colName))
            {
                dgv.Columns[colName].Visible = false;
            }
        }
    }
    public static string FormatDate(DateTime date)
    {
        return date.ToString("dd/MMMM/yyyy");
    }

}
