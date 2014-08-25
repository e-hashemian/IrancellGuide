using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        protected void MoveToSlide(MyForm f)
        {
            this.Hide();
            switch (f.ShowDialog())
            {
                case DialogResult.Cancel:
                    this.Close();
                    break;

                case DialogResult.Retry:
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    break;
            }
        }        
    }
}
