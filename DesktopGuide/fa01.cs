using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa01 : MyForm
    {
        public fa01()            
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void q2_Click(object sender, EventArgs e)
        {
            ShowDialog(new fa02());            
        }
    }
}
