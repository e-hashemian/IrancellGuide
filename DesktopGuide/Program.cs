using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Drawing;
using System.IO;
using DesktopGuide.Controls;

namespace DesktopGuide
{
    static class Program
    {
        public static string AppDir;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                AppDir = (new FileInfo(Application.ExecutablePath)).DirectoryName;
                MyLabel.myFonts.AddFontFile(Program.AppDir + "\\BNazanin.ttf");
                MyLabel.myFonts.AddFontFile(Program.AppDir + "\\BNazaninB.ttf");
                MyLabel.myFonts.AddFontFile(Program.AppDir + "\\BTitr.ttf");
                MyLabel.myFonts.AddFontFile(Program.AppDir + "\\BTitrB.ttf");
                MyLabel.myFonts.AddFontFile(Program.AppDir + "\\BYekan.ttf");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MyForm form = CreateForm(args);

                Application.Run(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static MyForm CreateForm(string[] args)
        {
            if (args.Length > 0)
            {
                Type type = Type.GetType("DesktopGuide." + args[0]);
                if (type != null)
                {
                    MyForm form = (MyForm)Activator.CreateInstance(type);
                    form.prevButton.Visible = false;
                    return form;
                }
            }

#if DEBUG
            return new en01();
#else
            return new fa01();
#endif
        }
    }
}
