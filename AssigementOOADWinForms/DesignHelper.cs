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
        // Enable double buffering via reflection to prevent flicker (like iOS fluid motion)
        typeof(DataGridView).InvokeMember(
            "DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.SetProperty,
            null, dgv, new object[] { true });

        // Header styling
        dgv.ColumnHeadersHeight = 50;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // iOS Azure-Blue
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

        // Rows styling
        dgv.RowTemplate.Height = 44; // iOS standard row height
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 232, 255);
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

        // Grid look
        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = Color.FromArgb(240, 240, 240);
        dgv.RowHeadersVisible = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;

        // Smooth scroll effect
        dgv.ScrollBars = ScrollBars.Both;
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

            // === Background: soft glass-like gradient ===
            Color topColor = (e.RowIndex % 2 == 0)
                ? Color.FromArgb(255, 250, 253, 255)   // light bluish-white
                : Color.FromArgb(255, 245, 248, 255);  // soft gray-blue tint
            Color bottomColor = Color.FromArgb(255, 230, 240, 255); // subtle glass fade

            using (var bgBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                e.CellBounds, topColor, bottomColor, 90f))
            {
                e.Graphics.FillRectangle(bgBrush, e.CellBounds);
            }

            // === Selection overlay (iOS translucent blue glow) ===
            if ((e.State & DataGridViewElementStates.Selected) != 0)
            {
                using (var selBrush = new SolidBrush(Color.FromArgb(90, 0, 122, 255))) // glassy blue
                {
                    e.Graphics.FillRectangle(selBrush, e.CellBounds);
                }

                // Optional highlight border
                using (var glowPen = new Pen(Color.FromArgb(180, 0, 122, 255), 1.5f))
                {
                    e.Graphics.DrawRectangle(glowPen,
                        e.CellBounds.X + 0.5f,
                        e.CellBounds.Y + 0.5f,
                        e.CellBounds.Width - 1.5f,
                        e.CellBounds.Height - 1.5f);
                }
            }

            // === Text rendering (clean, Apple-like font) ===
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.PaintContent(e.CellBounds);

            // === Subtle divider line (soft silver tone) ===
            using (var pen = new Pen(Color.FromArgb(220, 225, 235)))
            {
                e.Graphics.DrawRectangle(pen,
                    e.CellBounds.X,
                    e.CellBounds.Y,
                    e.CellBounds.Width - 1,
                    e.CellBounds.Height - 1);
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
    public static void PopulateRowControls(DataGridView dgv, Dictionary<string, Control> columnControlMap)
    {
        if (dgv.CurrentRow == null || dgv.RowCount == 0)
            return;

        // Ensure column names match DataPropertyName
        foreach (DataGridViewColumn col in dgv.Columns)
        {
            if (string.IsNullOrEmpty(col.Name) && !string.IsNullOrEmpty(col.DataPropertyName))
                col.Name = col.DataPropertyName;
        }

        var row = dgv.CurrentRow;

        foreach (var kvp in columnControlMap)
        {
            string columnName = kvp.Key;
            Control control = kvp.Value;

            // Skip if column does not exist or value is null
            if (!dgv.Columns.Contains(columnName) || row.Cells[columnName].Value == null)
                continue;

            object value = row.Cells[columnName].Value;

            switch (control)
            {
                case TextBox txt:
                    if (value is DateTime dt)
                        txt.Text = FormatDate(dt); // formatted date
                    else if (value is decimal dec)
                        txt.Text = dec.ToString("C"); // currency
                    else
                        txt.Text = value.ToString();
                    break;

                case ComboBox cb:
                    if (int.TryParse(value.ToString(), out int val))
                        cb.SelectedValue = val;
                    break;

                case Label lbl:
                    lbl.Text = value.ToString();
                    break;

                    // Add more control types here if needed
            }
        }
    }
    public static string FormatDate(DateTime date)
    {
        return date.ToString("dd/MM/yyyy");
    }

}
