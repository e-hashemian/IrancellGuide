using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa19 : MyForm
    {
        public fa19()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa03());
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa05());
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa07());
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa11());
        }

        private void myButton1_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void myButton2_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void myButton3_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa20());
        }

        private void myButton4_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa21());
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa22());
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa23());
        }

        private void myButton7_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa24());
        }

        private void myButton8_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa25());
        }

        private void myButton9_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa26());
        }

        private void myButton10_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa27());
        }
    }
}
