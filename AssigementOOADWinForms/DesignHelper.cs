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
    private const string IsStyledKey = "IsRoundedStyled";

    public static void MakeAllInputsRounded(Control parent, int radius = 12)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is TextBox txt)
            {
                // Ensure the control is initialized and styled only once.
                EnsureRoundedStyleApplied(txt, radius);
            }
            else if (control.HasChildren)
            {
                // Recurse into containers
                MakeAllInputsRounded(control, radius);
            }
        }
    }

    private static void EnsureRoundedStyleApplied(TextBox txt, int radius)
    {
        // Prevent re-initialization and multiple event subscriptions (fixes the memory leak bug).
        // Check if the Tag is the correct Tuple type and contains the IsStyledKey flag.
        if (txt.Tag is Tuple<string, int> tupleTag && tupleTag.Item1 == IsStyledKey)
        {
            // If already styled, just ensure the region is current.
            UpdateControlRegion(txt, radius);
            return;
        }

        // --- 1. Apply Standard Modern Style Settings ---
        txt.BorderStyle = BorderStyle.None;
        txt.BackColor = Color.White;
        txt.Font = new Font("Segoe UI", 14f, FontStyle.Regular);
        txt.TextAlign = HorizontalAlignment.Left;

        // --- 2. Apply Initial Region and Attach Handlers (ONLY ONCE) ---
        // Store the radius and the flag in the control's Tag.
        txt.Tag = new Tuple<string, int>(IsStyledKey, radius);

        UpdateControlRegion(txt, radius);

        // Attach the Resize handler ONLY ONCE to update the region when size changes.
        txt.Resize += (s, e) =>
        {
            // Safely retrieve the stored radius from the Tag.
            int currentRadius = ((Control)s).Tag is Tuple<string, int> tag ? tag.Item2 : 12;
            UpdateControlRegion((Control)s, currentRadius);
        };

        // Attach the Paint handler ONLY ONCE to draw the subtle border.
        txt.Paint += DrawSubtleBorder;
    }

    private static void UpdateControlRegion(Control control, int radius)
    {
        if (control.Width < 2 || control.Height < 2) return;

        // Setting Region to null removes any custom rounding, reverting to a standard rectangle.
        control.Region?.Dispose();
        control.Region = null;
    }

    private static void DrawSubtleBorder(object sender, PaintEventArgs e)
    {
        Control control = sender as Control;
        if (control == null) return;

        // Use a consistent, light gray border color (slightly lighter for iOS look)
        using (var pen = new Pen(Color.FromArgb(220, 220, 220), 1))
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, control.Width - 1, control.Height - 1);

            // Draw a simple square border, honoring the "not rounded" requirement
            e.Graphics.DrawRectangle(pen, rect);
        }
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
