using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        static bool closeApplication = false;
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormManager.instance.OpenLogin();
            while (!closeApplication)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }

        public static void Exit()
        {
            closeApplication = true;
        }
    }
}
