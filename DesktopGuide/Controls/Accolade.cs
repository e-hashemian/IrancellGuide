//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//
//using System.Text;
//using System.Windows.Forms;

//using System.Drawing.Drawing2D;

//namespace DesktopGuide.Controls
//{
//    public class Accolade : UserControl
//    {
//        private Pen pen = new Pen(Color.Black, 1);
//        private bool rtl = false;

//        public Accolade()
//        {            
//            BackColor = Color.Transparent;
//        }

//        #region Properties
//        public bool _RightToLeft
//        {
//            get { return rtl; }
//            set
//            {
//                rtl = value;
//                Refresh();
//            }
//        }

//        public float _LineWidth
//        {
//            get { return pen.Width; }
//            set
//            {
//                pen.Width = value;
//                Refresh();
//            }
//        }
//        #endregion

//        protected override void OnPaint(PaintEventArgs e)
//        {
//            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

//            int w, h;
//            w = Width;
//            h = Height;

//            if (Width < Height)
//                if (!rtl)
//                {
//                    e.Graphics.DrawArc(pen, w / 2, pen.Width, w, w, 180, 90);
//                    e.Graphics.DrawLine(pen, w / 2, w / 2, w / 2, h / 2 - w / 2);
//                    e.Graphics.DrawArc(pen, -w / 2, h / 2 - w, w - 1, w - 1, 0, 90);
//                    e.Graphics.DrawArc(pen, -w / 2, h / 2, w - 1, w - 1, 270, 90);
//                    e.Graphics.DrawLine(pen, w / 2, h / 2 + w / 2, w / 2, h - w / 2);
//                    e.Graphics.DrawArc(pen, w / 2, h - w - pen.Width, w, w, 90, 90);
//                }
//                else
//                {
//                    e.Graphics.DrawArc(pen, -w / 2, pen.Width, w - 1, w - 1, 270, 90);
//                    e.Graphics.DrawLine(pen, w / 2, w / 2, w / 2, h / 2 - w / 2);
//                    e.Graphics.DrawArc(pen, w / 2, h / 2 - w, w - 1, w - 1, 90, 90);
//                    e.Graphics.DrawArc(pen, w / 2, h / 2, w - 1, w - 1, 180, 90);
//                    e.Graphics.DrawLine(pen, w / 2, h / 2 + w / 2, w / 2, h - w / 2);
//                    e.Graphics.DrawArc(pen, -w / 2, h - w - pen.Width, w - 1, w - 1, 0, 90);
//                }
//            else
//                if (!rtl)
//                {
//                    e.Graphics.DrawArc(pen, pen.Width, h / 2, h, h, 180, 90);
//                    e.Graphics.DrawLine(pen, h / 2, h / 2, w / 2 - h / 2, h / 2);
//                    e.Graphics.DrawArc(pen, w / 2 - h, -h / 2, h - 1, h - 1, 0, 90);
//                    e.Graphics.DrawArc(pen, w / 2, -h / 2, h - 1, h - 1, 90, 90);
//                    e.Graphics.DrawLine(pen, w / 2 + h / 2, h / 2, w - h / 2, h / 2);
//                    e.Graphics.DrawArc(pen, w - h - pen.Width, h / 2, h, h, 270, 90);
//                }
//                else
//                {
//                    e.Graphics.DrawArc(pen, pen.Width, -h / 2, h - 1, h - 1, 90, 90);
//                    e.Graphics.DrawLine(pen, h / 2, h / 2, w / 2 - h / 2, h / 2);
//                    e.Graphics.DrawArc(pen, w / 2 - h, h / 2, h - 1, h - 1, 270, 90);
//                    e.Graphics.DrawArc(pen, w / 2, h / 2, h - 1, h - 1, 180, 90);
//                    e.Graphics.DrawLine(pen, w / 2 + h / 2, h / 2, w - h / 2, h / 2);
//                    e.Graphics.DrawArc(pen, w - h - pen.Width, -h / 2, h - 1, h - 1, 0, 90);
//                }
//        }

//        protected override void OnForeColorChanged(EventArgs e)
//        {
//            pen.Color = ForeColor;
//            Refresh();
//        }

//        protected override void OnResize(EventArgs e)
//        {
//            Refresh();
//        }
//    }
//}
