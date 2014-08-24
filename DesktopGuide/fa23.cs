using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa23 : MyForm
    {
        public fa23()
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

        private void myButton3_Click_2(object sender, EventArgs e)
        {
            MoveToSlide(new fa21());
        }
    }
}
