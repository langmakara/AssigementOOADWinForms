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
   
    private static System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        int d = Math.Max(0, radius * 2);
        var path = new System.Drawing.Drawing2D.GraphicsPath();
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }


    private const string IsGlassKey = "IsGlassStyled";

    public static void MakeAllInputs(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            switch (control)
            {
                case TextBox txt:
                    ApplyGlassTextBox(txt);
                    break;

                case ComboBox cb:
                    ApplyGlassComboBox(cb);
                    break;

                default:
                    if (control.HasChildren)
                        MakeAllInputs(control);
                    break;
            }
        }
    }

    private static void ApplyGlassTextBox(TextBox txt)
    {
        if (txt.Tag is string tag && tag == IsGlassKey) return;
        txt.Tag = IsGlassKey;

        txt.Font = new Font("Segoe UI", 15f);
        txt.BackColor = Color.FromArgb(250, 250, 250);
        txt.ForeColor = Color.Black;
        txt.BorderStyle = BorderStyle.None;
        txt.TextAlign = HorizontalAlignment.Left;
        txt.Padding = new Padding(8, 4, 8, 4);

        // Draw subtle border only on TextBox
        txt.Paint += (s, e) =>
        {
            var rect = new Rectangle(0, 0, txt.Width - 1, txt.Height - 1);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var penBorder = new Pen(Color.FromArgb(200, 200, 200), 1);
            e.Graphics.DrawRectangle(penBorder, rect);
            var innerRect = new Rectangle(1, 1, txt.Width - 3, txt.Height - 3);
            using var penHighlight = new Pen(Color.FromArgb(120, 255, 255, 255), 1);
            e.Graphics.DrawRectangle(penHighlight, innerRect);
        };
    }

    private static void ApplyGlassComboBox(ComboBox cb)
    {
        if (cb.Tag is string tag && tag == IsGlassKey) return;
        cb.Tag = IsGlassKey;

        cb.Font = new Font("Segoe UI", 15f);
        cb.BackColor = Color.FromArgb(250, 250, 250); // light glass-like
        cb.ForeColor = Color.Black;
        cb.FlatStyle = FlatStyle.Flat;

        // Remove borders and padding issues
        cb.DropDownStyle = ComboBoxStyle.DropDownList; // or DropDown
        cb.IntegralHeight = true;

        // Optional: subtle border using a slight Padding trick
        cb.Margin = new Padding(1);
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

        if (!dgv.Columns.Contains(columnName))
            continue; // skip if column does not exist

        var cellValue = row.Cells[columnName].Value;
        if (cellValue == null)
            continue; // skip if value is null

        switch (control)
        {
            case TextBox txt:
                if (cellValue is DateTime dt)
                    txt.Text = dt.ToString("dd/MM/yyyy");
                else if (cellValue is decimal dec)
                    txt.Text = dec.ToString("C2");
                else
                    txt.Text = cellValue.ToString();
                break;

            case ComboBox cb:
                // Try to select by value or by string match
                if (cb.Items.Contains(cellValue))
                    cb.SelectedItem = cellValue;
                else if (int.TryParse(cellValue.ToString(), out int val))
                    cb.SelectedValue = val;
                else
                    cb.SelectedIndex = -1; // fallback if not found
                break;

            case Label lbl:
                lbl.Text = cellValue.ToString();
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
