using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace DesktopGuide.Controls
{
    class MyLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StringFormat format = RightToLeft == System.Windows.Forms.RightToLeft.Yes
                ? new StringFormat(StringFormatFlags.DirectionRightToLeft)
                : new StringFormat();
            e.Graphics.DrawString(Text, Font, new SolidBrush(Color.Black), this.ClientRectangle, format);            
        }
    }
}
