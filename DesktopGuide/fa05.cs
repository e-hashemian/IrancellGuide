using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa05 : MyForm
    {
        public fa05()
        {            
            InitializeComponent();                        
        }

        private void fa02_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa06());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }        
    }
}
