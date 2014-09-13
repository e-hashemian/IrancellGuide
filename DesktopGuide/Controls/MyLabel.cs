using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Drawing;

namespace DesktopGuide.Controls
{
    class MyLabel : Label
    {
        public static PrivateFontCollection myFonts = new PrivateFontCollection();

        public MyLabel()
        {
            DoubleBuffered = true;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            if (myFonts.Families.Length > 0)            
            {                
                switch (this.Font.OriginalFontName)
                {
                    case "B Nazanin":                        
                        Font = new Font(myFonts.Families[0], this.Font.Size, this.Font.Style);
                        break;

                    case "B Titr":
                        if (this.Font.Bold)
                            Font = new Font(myFonts.Families[2], this.Font.Size, this.Font.Style);
                        else
                            Font = new Font(myFonts.Families[1], this.Font.Size, this.Font.Style);
                        break;

                    case "B Yekan":
                        Font = new Font(myFonts.Families[3], this.Font.Size, this.Font.Style);
                        break;
                }
            }            
            base.OnFontChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            base.OnPaint(e);
        }
    }
}
