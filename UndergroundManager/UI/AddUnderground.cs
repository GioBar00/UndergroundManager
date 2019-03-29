using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddUnderground : Form
    {
        public Func<string, Task> OnStringConfirm;
        public AddUnderground()
        {
            InitializeComponent();
            btnAggiungi.Text = "Aggiungi";
            this.Text = "Aggiungi Metropolitana";
        }

        public AddUnderground(string nome)
        {
            InitializeComponent();
            textBoxNome.Text = nome;
            btnAggiungi.Text = "Rinomina";
            this.Text = "Rinomina Metropolitana";
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                OnStringConfirm?.Invoke(textBoxNome.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Inserisci qualcosa nel nome", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool checkTextBox()
        {
            string text = textBoxNome.Text;
            return text.Replace(" ", "").Length != 0;
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxNome.Text.Length == 0 && e.KeyChar == ' ' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }
    }
}
