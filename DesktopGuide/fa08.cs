using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa08 : MyForm
    {
        public fa08()
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

        private void myButton3_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa03());
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa09());
        }
    }
}
