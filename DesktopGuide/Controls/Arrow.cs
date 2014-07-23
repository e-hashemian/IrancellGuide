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
    public partial class Arrow : UserControl
    {
        private Pen pen = new Pen(Color.Black, 1);
        private AdjustableArrowCap cap = new AdjustableArrowCap(5, 5, false);
        private bool secondaryDiagonal = false;

        public Arrow()
        {
            InitializeComponent();

            pen.CustomEndCap = cap;
            pen.StartCap = LineCap.Flat;
            BackColor = Color.Transparent;
        }

        #region Properties
        public Control _transparentParent
        {
            get { return this.Parent; }
            set { this.Parent = value; }
        }

        public bool _RightToLeft
        {
            get { return pen.StartCap != LineCap.Flat; }
            set
            {
                if (value)
                {
                    pen.CustomStartCap = cap;
                    pen.EndCap = LineCap.Flat;
                }
                else
                {
                    pen.CustomEndCap = cap;
                    pen.StartCap = LineCap.Flat;
                }
                Refresh();
            }
        }

        public float _CapSize
        {
            get { return cap.Width; }
            set
            {
                cap.Width = value;
                cap.Height = value;
                if (pen.EndCap == LineCap.Custom)
                    pen.CustomEndCap = cap;
                else
                    pen.CustomStartCap = cap;
                Refresh();
            }
        }

        public bool _FilledCap
        {
            get { return cap.Filled; }
            set
            {
                cap.Filled = value;
                if (pen.EndCap == LineCap.Custom)
                    pen.CustomEndCap = cap;
                else
                    pen.CustomStartCap = cap;
                Refresh();
            }
        }

        public float _LineWidth
        {
            get { return pen.Width; }
            set
            {
                pen.Width = value;
                Refresh();
            }
        }

        public bool _SecondaryDiagonal
        {
            get { return secondaryDiagonal; }
            set
            {
                secondaryDiagonal = value;
                Refresh();
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            int startX, startY, endX, endY;
            startX = 0 + (int)pen.Width;
            startY = 0 + (int)pen.Width;
            endX = Width - (int)pen.Width;
            endY = Height - (int)pen.Width;

            if ((double)Width / Height > 0.5)
                if ((double)Height / Width > 0.5)
                    if (secondaryDiagonal)
                        e.Graphics.DrawLine(pen, endX, startY, startX, endY);
                    else
                        e.Graphics.DrawLine(pen, startX, startY, endX, endY);
                else
                    e.Graphics.DrawLine(pen, startX, Height / 2, endX, Height / 2);
            else
                e.Graphics.DrawLine(pen, Width / 2, startY, Width / 2, endY);
        }

        protected override void OnResize(EventArgs e)
        {
            Refresh();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            pen.Color = ForeColor;
            Refresh();
        }
    }
}
