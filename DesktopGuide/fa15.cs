﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa15 : MyForm
    {
        public fa15()
        {
            InitializeComponent();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa05());
        }
    }
}
