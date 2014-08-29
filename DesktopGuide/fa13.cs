using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa13 : MyForm
    {
        public fa13()
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

        private void myButton3_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa11());
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa03());
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa04());
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa11());
        }
        
        
    }
}
