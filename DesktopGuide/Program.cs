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
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MyForm form = CreateForm(args);

            Application.Run(form);
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
