using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void fa02_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa03());
        }        
    }
}
