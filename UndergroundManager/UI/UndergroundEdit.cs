using ClassLibrary;
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
    public partial class UndergroundEdit : Form
    {
        MetropolitanaInstaceManager manager;
        // TODO: REMOVE THIS
        List<Stazione> testStazioni = new List<Stazione>();
        List<Linea> testLinee = new List<Linea>();
        MetroVisualizer visual;

        public Metropolitana Metropolitana
        {
            get
            {
                return manager.Metropolitana;
            }
        }

        public UndergroundEdit(Metropolitana metropolitana)
        {
            InitializeComponent();
            

            testStazioni.Add(new Stazione(1, "Understasse", 1, 13, 12));
            testLinee.Add(new Linea(1, "U1", 1, 1367));

            manager = new MetropolitanaInstaceManager(metropolitana);
            toolStripLabelMetropolitana.Text = Metropolitana.Nome;
            aggiungiStazioniToolStripMenuItem.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Aggiungi stazione", "Hei");
                //TODO: open aggiungi stazione
            };
            aggiungiLineeToolStripMenuItem.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Aggiungi linea", "Hei");
                //TODO: open aggiungi linea
            };

            SQLServerManager.instance.OnConnectionStateChange += (object sender, StateChangeEventArgs e) =>
            {
                ConnectionStateChanged(e.CurrentState);
            };
            ConnectionStateChanged(SQLServerManager.instance.ConnectionState);

            Reload();

            visual = new MetroVisualizer(metropolitana);
            visual.Location = new Point(0, 0);
            panelContainer.Controls.Add(visual);
        }

        public void Reload()
        {
            btnRedo.Enabled = manager.CanRedo;
            btnUndo.Enabled = manager.CanUndo;
            CaricaDati();
        }

        void CaricaDati()
        {
            //carica stazioni
            elencoStazioniToolStripMenuItem.DropDownItems.Clear();
            //FIXME
            foreach (Stazione s in testStazioni)
            {
                var item = new ToolStripMenuItem();
                item.Text = s.Nome;
                item.Name = s.ID.ToString();
                item.DropDownItems.Add(new Func<ToolStripMenuItem>(() => {
                    var mod = new ToolStripMenuItem();
                    mod.Text = "Modifica";
                    mod.Click += (object sender, EventArgs e) =>
                    {
                        MessageBox.Show("Modifica stazione " + s.Nome, "Hei");
                        //TODO: open modifica stazione
                    };
                    return mod;
                })());
                item.DropDownItems.Add(new Func<ToolStripMenuItem>(() => {
                    var del = new ToolStripMenuItem();
                    del.Text = "Elimina";
                    del.Click += (object sender, EventArgs e) =>
                    {
                        MessageBox.Show("Elimina stazione " + s.Nome, "Hei");
                        //TODO: Ask To Delete
                    };
                    return del;
                })());
                elencoStazioniToolStripMenuItem.DropDownItems.Add(item);
            }
            //carica linee
            elencoLineeToolStripMenuItem.DropDownItems.Clear();
            //FIXME
            foreach (Linea l in testLinee)
            {
                var item = new ToolStripMenuItem();
                item.Text = l.Nome;
                item.Name = l.ID.ToString();
                item.DropDownItems.Add(new Func<ToolStripMenuItem>(() => {
                    var mod = new ToolStripMenuItem();
                    mod.Text = "Modifica";
                    mod.Click += (object sender, EventArgs e) =>
                    {
                        MessageBox.Show("Modifica linea " + l.Nome, "Hei");
                        //TODO: open modifica stazione
                    };
                    return mod;
                })());
                item.DropDownItems.Add(new Func<ToolStripMenuItem>(() => {
                    var del = new ToolStripMenuItem();
                    del.Text = "Elimina";
                    del.Click += (object sender, EventArgs e) =>
                    {
                        MessageBox.Show("Elimina linea " + l.Nome, "Hei");
                        //TODO: Ask To Delete
                    };
                    return del;
                })());
                elencoLineeToolStripMenuItem.DropDownItems.Add(item);
            }
            //carica linee su combobox
            toolStripComboBoxLinee.Items.Clear();
            foreach (Linea l in testLinee)
            {
                toolStripComboBoxLinee.Items.Add(l.Nome);
            }
        }

        void ConnectionStateChanged(ConnectionState state)
        {
            switch (state)
            {
                case ConnectionState.Broken:
                    toolStripLblImageDatabaseStatus.Image = UI.Properties.Resources.database_disconnected;
                    MessageBox.Show("Connection Broke");
                    break;
                case ConnectionState.Closed:
                    toolStripLblImageDatabaseStatus.Image = UI.Properties.Resources.database_disconnected;
                    break;
                case ConnectionState.Open:
                    toolStripLblImageDatabaseStatus.Image = UI.Properties.Resources.database_connected;
                    break;
                default:
                    toolStripLblImageDatabaseStatus.Image = UI.Properties.Resources.database_loading;
                    break;
            }
            toolStripLblImageDatabaseStatus.ToolTipText = state.ToString();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {

        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            
            panelContainer.Scale(new SizeF(1.1f, 1.1f));
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (visual.Size.Width >= this.Size.Width && visual.Size.Height >= this.Size.Height)
                panelContainer.Scale(new SizeF(0.9f, 0.9f));
        }

        private void btnZoomToFit_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
