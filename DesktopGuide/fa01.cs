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

            q1.Image = Program.LoadQuastionImage();
            q2.Image = q1.Image;
            login.Image = Program.LoadImage("login");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
