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
            BackColor = Color.Transparent;
            FlatAppearance.BorderColor = Color.FromArgb(80, Color.Blue);
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 2;
            FlatStyle = FlatStyle.Flat;
            UseVisualStyleBackColor = false;
            Text = "";
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            FlatAppearance.BorderColor = Color.FromArgb(80, Color.Red);
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            FlatAppearance.BorderColor = Color.FromArgb(80, Color.Blue);
            base.OnMouseLeave(e);
        }

        public Control _transparentParent
        {
            get { return this.Parent; }
            set { this.Parent = value; }
        }
    }
}
