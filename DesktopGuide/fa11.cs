using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa11 : MyForm
    {
        public fa11()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }        

        private void myButton2_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void fa10_Load(object sender, EventArgs e)
        {

        }

        private void main_Click(object sender, EventArgs e)
        {

        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa12());
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa13());
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa04());
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa14());
        }

        private void myButton7_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa15());
        }

        private void myButton8_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa16());
        }

    }
}
