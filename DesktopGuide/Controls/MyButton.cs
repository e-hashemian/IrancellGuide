using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace DesktopGuide.Controls
{
    class MyButton : Button
    {
        public MyButton()
        {
            UseVisualStyleBackColor = false;
            FlatStyle = FlatStyle.Flat;     
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            FlatAppearance.BorderColor = Color.FromArgb(80, Color.Blue);
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 2;                   
            Text = "";
            Cursor = Cursors.Hand;

            Timer timer = new Timer()
            {
                Interval = 500,
                Enabled = true,
            };
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (FlatAppearance.BorderColor != Color.FromArgb(128, Color.Red))
                if (FlatAppearance.BorderColor == Color.FromArgb(128, Color.Blue))
                    FlatAppearance.BorderColor = Color.FromArgb(128, Color.Green);
                else
                    FlatAppearance.BorderColor = Color.FromArgb(128, Color.Blue);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            FlatAppearance.BorderColor = Color.FromArgb(128, Color.Red);
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            FlatAppearance.BorderColor = Color.FromArgb(128, Color.Blue);
            base.OnMouseLeave(e);
        }

        public Control _transparentParent
        {
            get { return this.Parent; }
            set { this.Parent = value; }
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
        protected override void OnPaintBackground(PaintEventArgs e) { }
    }
}
