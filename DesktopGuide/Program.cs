using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Drawing;

namespace DesktopGuide
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fa01());
        }

        public static Image LoadQuastionImage()
        {
            return Image.FromFile("GuideImages\\Q.png");
        }

        public static Image LoadImage(string name)
        {
            return Image.FromFile("GuideImages\\"+name+".png");
        }
    }
}
