using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa10 : MyForm
    {
        public fa10()
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
        
        
    }
}
