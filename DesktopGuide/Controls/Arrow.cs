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

    public class Arrow : UserControl
    {
        public enum Direction
        {
            RightToLeft,
            LeftToRight,
            PrimaryDiagonalToButtom,
            PrimaryDiagonalToTop,
            SecondaryDiagonalToButtom,
            SecondaryDiagonalToTop,
            TopToButtom,
            ButtomToTop
        }

        private Pen pen = new Pen(Color.Black, 1);
        private AdjustableArrowCap cap = new AdjustableArrowCap(5, 5, false);
        private Direction dir = Direction.RightToLeft;

        public Arrow()
        {
            pen.CustomEndCap = cap;
            pen.StartCap = LineCap.Flat;
<<<<<<< HEAD
            BackColor = Color.Transparent;            
=======
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
>>>>>>> 931c559ef8ffaa7926bba44fac43512066d24d5e
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        #region Properties
        public Control _transparentParent
        {
            get { return this.Parent; }
            set { this.Parent = value; }
        }

        public Direction _Direction
        {
            get { return dir; }
            set
            {
                dir = value;
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
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            int startX, startY, endX, endY;
            startX = 0 + (int)pen.Width;
            startY = 0 + (int)pen.Width;
            endX = Width - (int)pen.Width;
            endY = Height - (int)pen.Width;

            switch (dir)
            {
                case Direction.ButtomToTop:
                case Direction.PrimaryDiagonalToTop:
                case Direction.SecondaryDiagonalToTop:
                case Direction.RightToLeft:
                    pen.CustomStartCap = cap;
                    pen.EndCap = LineCap.Flat;
                    break;

                case Direction.PrimaryDiagonalToButtom:
                case Direction.SecondaryDiagonalToButtom:
                case Direction.TopToButtom:
                case Direction.LeftToRight:
                    pen.CustomEndCap = cap;
                    pen.StartCap = LineCap.Flat;
                    break;
            }

            switch(dir)
            {
                case Direction.SecondaryDiagonalToButtom:
                case Direction.SecondaryDiagonalToTop:
                    e.Graphics.DrawLine(pen, endX, startY, startX, endY);
                    break;

                case Direction.PrimaryDiagonalToButtom:
                case Direction.PrimaryDiagonalToTop:
                    e.Graphics.DrawLine(pen, startX, startY, endX, endY);
                    break;

                case Direction.TopToButtom:
                case Direction.ButtomToTop:
                    e.Graphics.DrawLine(pen, Width / 2, startY, Width / 2, endY);                    
                    break;

                case Direction.LeftToRight:
                case Direction.RightToLeft:
                    e.Graphics.DrawLine(pen, startX, Height / 2, endX, Height / 2);
                    break;
            }
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
