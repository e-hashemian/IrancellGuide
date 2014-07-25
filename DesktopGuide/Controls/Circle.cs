using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace DesktopGuide.Controls
{
    public class Circle : UserControl
    {
        public Circle()
        {
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillEllipse(new SolidBrush(ForeColor), 0, 0, Width - 1, Height - 1);
        }

        protected override void OnResize(EventArgs e)
        {
            Refresh();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            Refresh();
        }
    }
}
