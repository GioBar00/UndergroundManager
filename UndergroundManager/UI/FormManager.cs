using ClassLibrary;
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
        private FormManager()
        {
            SQLServerManager.instance.OnConnectionStateChange += SQLConnectionStateChange;
        }

        List<Form> formsOpen = new List<Form>();
        public Form current
        {
            get
            {
                if (formsOpen.Count != 0)
                    return formsOpen.Last();
                return null;
            }
            set
            {
                formsOpen.Add(value);
                if (formsOpen.Count != 1)
                {
                    formsOpen[formsOpen.Count - 2].Close();
                }
            }
        }

        public void OpenLogin()
        {
            current = new Login();
            current.FormClosed += FormClosed;
            current.Show();
        }

        public void OpenMainWindow()
        {
            if (current != null)
            {
                current = new MainWindow();
                current.FormClosed += FormClosed;
                current.Show();
            }
            else
            {
                Program.Exit();
            }
        }

        public UndergroundEdit OpenNewUndergroundEdit(Metropolitana metro)
        {
            var newForm = new UndergroundEdit(metro);
            newForm.FormClosed += FormClosed;
            formsOpen.Add(newForm);
            current.Show();
            return newForm;
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            Form closeMe = (Form)sender;
            formsOpen.Remove(closeMe);
            if (formsOpen.Count == 0)
                Program.Exit();
        }

        private void SQLConnectionStateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            if (e.CurrentState == System.Data.ConnectionState.Broken)
            {
                MessageBox.Show("È avvenuto un problema con il collegamento col database.\nSi prega di riaprire la connessione.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //TODO: aprire login e bloccare tutte le altre schede
            }
        }
    }
}
