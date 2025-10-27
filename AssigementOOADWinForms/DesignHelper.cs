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

        // Enable double buffering to reduce flicker
        typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                     .SetValue(panel, true, null);

        panel.Paint += (sender, e) =>
        {
            Rectangle rect = panel.ClientRectangle;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                panel.Region = new Region(path);

                // --- Glass effect ---
                // Keep original BackColor but add transparency
                Color baseColor = panel.BackColor;
                Color glassColor = Color.FromArgb(180, baseColor.R, baseColor.G, baseColor.B); // semi-transparent

                using (var brush = new LinearGradientBrush(
                    rect,
                    Color.FromArgb(200, baseColor.R, baseColor.G, baseColor.B), // slightly lighter top
                    glassColor, // base at bottom
                    90f))
                {
                    e.Graphics.FillPath(brush, path);
                }

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
        if (e.RowIndex < 0 || e.ColumnIndex < 0)
            return;

        var dgv = (DataGridView)sender;

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        int radius = 5; // rounded-lg
        int padding = 2; // padding inside the cell
        Rectangle rect = e.CellBounds;
        rect.Inflate(1, 1); // cover hidden grid lines

        // --- Step 1: Fill background behind rounded cell (corners white) ---
        using (var bgFill = new SolidBrush(Color.White))
        {
            e.Graphics.FillRectangle(bgFill, rect);
        }

        // --- Step 2: Create rounded rectangle path with padding ---
        Rectangle paddedRect = new Rectangle(
            rect.X + padding,
            rect.Y + padding,
            rect.Width - padding * 2,
            rect.Height - padding * 2
        );

        GraphicsPath path = new GraphicsPath();
        int d = radius * 2;
        path.AddArc(paddedRect.X, paddedRect.Y, d, d, 180, 90);
        path.AddArc(paddedRect.Right - d, paddedRect.Y, d, d, 270, 90);
        path.AddArc(paddedRect.Right - d, paddedRect.Bottom - d, d, d, 0, 90);
        path.AddArc(paddedRect.X, paddedRect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        // --- Step 3: Fill cell background with gradient ---
        Color topColor = (e.RowIndex % 2 == 0)
            ? Color.FromArgb(255, 250, 253, 255)
            : Color.FromArgb(255, 245, 248, 255);
        Color bottomColor = Color.FromArgb(255, 230, 240, 255);

        using (var brush = new LinearGradientBrush(paddedRect, topColor, bottomColor, 90f))
        {
            e.Graphics.FillPath(brush, path);
        }

        // --- Step 4: Selection overlay ---
        if ((e.State & DataGridViewElementStates.Selected) != 0)
        {
            using (var selBrush = new SolidBrush(Color.FromArgb(90, 0, 122, 255)))
            {
                e.Graphics.FillPath(selBrush, path);
            }
        }

        // --- Step 5: Paint content with padding ---
        Rectangle contentRect = new Rectangle(
            paddedRect.X + 2,
            paddedRect.Y + 2,
            paddedRect.Width - 4,
            paddedRect.Height - 4
        );
        e.PaintContent(contentRect);

        e.Handled = true;
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
        if (dgv == null || columnControlMap == null)
            return;

        if (dgv.RowCount == 0)
            return;

        foreach (DataGridViewColumn col in dgv.Columns)
        {
            if (string.IsNullOrEmpty(col.Name) && !string.IsNullOrEmpty(col.DataPropertyName))
                col.Name = col.DataPropertyName;
        }

        DataGridViewRow? row = null;
        if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            row = dgv.CurrentRow;
        else if (dgv.CurrentCell != null && dgv.CurrentCell.RowIndex >= 0)
            row = dgv.Rows[dgv.CurrentCell.RowIndex];
        else if (dgv.SelectedRows != null && dgv.SelectedRows.Count > 0 && dgv.SelectedRows[0].Index >= 0)
            row = dgv.SelectedRows[0];
        else
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (!r.IsNewRow && r.Index >= 0)
                {
                    row = r;
                    break;
                }
            }
        }

        if (row == null)
            return;

        foreach (var kvp in columnControlMap)
        {
            string columnName = kvp.Key;
            Control control = kvp.Value;

            if (!dgv.Columns.Contains(columnName))
                continue;

            DataGridViewColumn col = dgv.Columns[columnName];
            int colIndex = col?.Index ?? -1;
            if (colIndex < 0 || colIndex >= row.Cells.Count)
                continue;

            try
            {
                var cell = row.Cells[colIndex];
                var cellValue = cell?.Value;
                if (cellValue == null || cellValue == DBNull.Value)
                    continue;

                switch (control)
                {
                    case TextBox txt:
                        var typeCode = Type.GetTypeCode(cellValue.GetType());

                        // Treat integers (IDs, counts) as plain numbers
                        if (typeCode == TypeCode.Int16 || typeCode == TypeCode.Int32 || typeCode == TypeCode.Int64
                            || typeCode == TypeCode.UInt16 || typeCode == TypeCode.UInt32 || typeCode == TypeCode.UInt64)
                        {
                            txt.Text = Convert.ToString(cellValue);
                        }
                        else if (typeCode == TypeCode.DateTime)
                        {
                            txt.Text = ((DateTime)cellValue).ToString("dd/MM/yyyy");
                        }
                        else if (typeCode == TypeCode.Decimal || typeCode == TypeCode.Double || typeCode == TypeCode.Single)
                        {
                            // Only format as currency for columns that represent money
                            var lower = columnName.ToLowerInvariant();
                            if (lower.Contains("price") || lower.Contains("amount") || lower.Contains("total"))
                            {
                                if (decimal.TryParse(Convert.ToString(cellValue), out decimal dec))
                                    txt.Text = dec.ToString("C2");
                                else
                                    txt.Text = Convert.ToString(cellValue);
                            }
                            else
                            {
                                // Non-money numeric values: show raw number (no currency symbol)
                                txt.Text = Convert.ToString(cellValue);
                            }
                        }
                        else
                        {
                            txt.Text = Convert.ToString(cellValue);
                        }
                        break;

                    case ComboBox cb:
                        if (!string.IsNullOrEmpty(cb.ValueMember))
                        {
                            try
                            {
                                cb.SelectedValue = cellValue;
                                if (cb.SelectedIndex >= 0) break;
                            }
                            catch { }
                        }

                        bool matched = false;
                        foreach (var item in cb.Items)
                        {
                            if (Equals(item, cellValue) || (item != null && item.ToString() == cellValue.ToString()))
                            {
                                cb.SelectedItem = item;
                                matched = true;
                                break;
                            }
                        }
                        if (!matched)
                            cb.SelectedIndex = -1;
                        break;

                    case Label lbl:
                        lbl.Text = Convert.ToString(cellValue);
                        break;

                    default:
                        break;
                }
            }
            catch
            {
                continue;
            }
        }
    }

    public static string FormatDate(DateTime date)
    {
        return date.ToString("dd/MM/yyyy");
    }

}
