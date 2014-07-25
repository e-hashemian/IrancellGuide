using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa03 : MyForm
    {
        public fa03()
        {            
            InitializeComponent();                        
        }

        private void fa02_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa04());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDialog(new fa02());            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowDialog(new fa02());
        }        
    }
}
