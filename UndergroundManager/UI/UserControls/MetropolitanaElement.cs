using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace UI
{
    public partial class MetropolitanaElement : UserControl
    {
        Metropolitana metropolitana;
        ISelectManager<MetropolitanaElement> selectManager;
        bool selected = false;

        public Func<Metropolitana, Task> OnDelete;
        public Func<Metropolitana, string, Task> OnRename;

        public Metropolitana Metropolitana
        {
            get
            {
                return metropolitana;
            }
        }
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                Select(selected);
            }
        }
        public MetropolitanaElement(Metropolitana metro, ISelectManager<MetropolitanaElement> selectManager)
        {
            metropolitana = metro;
            this.selectManager = selectManager;
            InitializeComponent();
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Rinomina", new EventHandler((object sender, EventArgs e) => {
                var modForm = new AddUnderground(Metropolitana.Nome);
                modForm.OnStringConfirm = (string nome) => {
                    return OnRename?.Invoke(metropolitana, nome);
                };
                modForm.ShowDialog();
            }));
            cm.MenuItems.Add("Elimina", new EventHandler((object sender, EventArgs e) => {
                var res = MessageBox.Show($"Sei sicuro di voler eliminare la metropolitana { metropolitana.Nome }?\nLa operazione non è reversibile.", "Attenzione!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    OnDelete?.Invoke(metropolitana);
                }
            }));
            tableLayoutPanel1.ContextMenu = cm;
            ReloadData();
        }

        public void ReloadData()
        {
            lblName.Text = metropolitana.Nome;
            lblCreationDate.Text = $"Data creazione:\n{ metropolitana.DateTimeCreazione.ToShortDateString() }\nalle { metropolitana.DateTimeCreazione.ToShortTimeString() }.";
            lblLastEdit.Text = $"Data ultima modifica:\n{ metropolitana.DateTimeUltimaModifica.ToShortDateString() }\nalle { metropolitana.DateTimeUltimaModifica.ToShortTimeString() }.";
        }

        private void pictureBoxRoute_Click(object sender, EventArgs e)
        {
            selectManager.Select(this);
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            selectManager.Select(this);
        }

        void Select(bool yes)
        {
            this.BackColor = yes ? Color.AliceBlue : Color.White;
        }
    }
}
