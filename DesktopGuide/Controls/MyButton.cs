using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace DesktopGuide.Controls
{
    class MyButton : Button
    {
        //Color Hover = Color.FromArgb(128, Color.Red);
        //Color Blink1 = Color.FromArgb(128, Color.Blue);
        //Color Blink2 = Color.FromArgb(128, Color.Green);

        Color Hover = Color.FromArgb(128, Color.Red);
        Color Blink1 = Color.FromArgb(128, Color.Black);
        Color Blink2 = Color.FromArgb(0, Color.White);

        //Color Hover = Color.Blue;
        //Color Blink1 = Color.Red;
        //Color Blink2 = Color.FromArgb(0, Color.White);

        //Color Hover = Color.FromArgb(255, Color.Red);
        //Color Blink1 = Color.FromArgb(255, Color.Blue);
        //Color Blink2 = Color.FromArgb(0, Color.White);

        public MyButton()
        {
            UseVisualStyleBackColor = false;
            FlatStyle = FlatStyle.Flat;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            FlatAppearance.BorderColor = Blink1;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 2;
            Text = "";
            Cursor = Cursors.Hand;

            Timer timer = new Timer()
            {
                Interval = 1000,
                Enabled = true,
            };
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (FlatAppearance.BorderColor != Hover)
                if (FlatAppearance.BorderColor == Blink1)
                    FlatAppearance.BorderColor = Blink2;
                else
                    FlatAppearance.BorderColor = Blink1;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            FlatAppearance.BorderColor = Hover;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            FlatAppearance.BorderColor = Blink1;
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
