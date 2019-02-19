using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class FormManager
    {
        public static FormManager instance = new FormManager();
        private FormManager() { }

        Form current;

        public void OpenLogin()
        {
            current = new Login();
            current.FormClosed += Program.Form_FormClosed;
            current.Show();
        }

        public void OpenMainWindow()
        {
            if (current != null)
            {
                current.FormClosed -= Program.Form_FormClosed;
                current.Close();
                current = new MainWindow();
                current.FormClosed += Program.Form_FormClosed;
                current.Show();
            }
            else
            {
                Program.Form_FormClosed(this, null);
            }
        }
    }
}
