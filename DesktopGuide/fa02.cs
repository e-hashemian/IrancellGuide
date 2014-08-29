using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa02 : MyForm
    {
        public fa02()
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

        private void myButton5_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa18());
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa19());
        }
    }
}
