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
    public partial class MainWindow : Form, ISelectManager<MetropolitanaElement>
    {
        List<MetropolitanaElement> elementi = new List<MetropolitanaElement>();
        List<UndergroundEdit> edits = new List<UndergroundEdit>();
        List<Metropolitana> metropolitane
        {
            get
            {
                return elementi.Select(x => x.Metropolitana).ToList();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            SQLServerManager.instance.OnConnectionStateChange += (object sender, StateChangeEventArgs e) =>
            {
                ConnectionStateChanged(e.CurrentState);
            };
            ConnectionStateChanged(SQLServerManager.instance.ConnectionState);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Reload();
        }

        void Reload()
        {
            LoadData();
            ItemSelected(false);
        }

        async void LoadData()
        {
            EnableMod(false);
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += updateProgressBarValue;
            try
            {
                await SQLServerManager.instance.GetMetropolitanaAsync(1, progress);
                List<Metropolitana> metro = await SQLServerManager.instance.GetMetropolitaneAsync(progress);
                CreateElements(metro);
                LoadElements();
                CheckOpens();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            EnableMod(true);

        }

        void CreateElements(List<Metropolitana> metro)
        {
            elementi.Clear();
            foreach (Metropolitana m in metro)
            {
                var el = new MetropolitanaElement(m, this);
                el.Dock = DockStyle.Top;
                elementi.Add(el);
            }
        }

        void LoadElements()
        {
            panelMetropolitane.Controls.Clear();
            foreach (MetropolitanaElement el in elementi)
            {
                panelMetropolitane.Controls.Add(el);
                el.OnDelete = async (Metropolitana metro) =>
                {
                    await SQLServerManager.instance.DeleteMetropolitana(metro);
                    Reload();
                };
                el.OnRename = async (Metropolitana metro, string nome) =>
                {
                    if (metropolitane.Where(x => !x.Equals(metro)).Select(x => x.Nome).ToList().Contains(nome))
                    {
                        MessageBox.Show("Non è possibile rinominare una stazione con il nome di un'altra.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        await SQLServerManager.instance.RenameMetropolitana(metro, nome);
                        Reload();
                    }
                };
            }
        }

        void CheckOpens()
        {
            var metroOpen = edits.Select(x => x.Metropolitana).ToList();
            foreach (var el in elementi)
            {
                if (metroOpen.Contains(el.Metropolitana))
                    el.Enabled = false;
            }
        }

        void EnableMod(bool enable)
        {
            toolStripButtonDatabaseReload.Enabled = enable;
            toolStripProgressBar.Visible = !enable;
            tableLayoutPanelBottom.Enabled = enable;
        }

        void updateProgressBarValue(object sender, ProgressReportModel e)
        {
            toolStripProgressBar.Value = e.Percentuale;
        }

        private void toolStripButtonDatabaseReload_Click(object sender, EventArgs e)
        {
            Reload();
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

        void ItemSelected(bool yes)
        {
            toolStripButtonEdit.Enabled = yes;
            toolStripLabelText.Visible = !yes;
        }

        public void Select(MetropolitanaElement item)
        {
            item.Selected = !item.Selected;
            if (item.Selected)
            {
                var els = elementi.Where(x => x != item && x.Selected).ToList();
                foreach(var el in els)
                {
                    el.Selected = false;
                }
            }
            ItemSelected(item.Selected);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            var els = elementi.Where(x => x.Selected).ToList();
            if (els.Count == 1)
            {
                var edit = FormManager.instance.OpenNewUndergroundEdit(els[0].Metropolitana);
                edit.FormClosed += Edit_FormClosed;
                els[0].Enabled = false;
                Select(els[0]);
                edits.Add(edit);
            }
            else
            {
                Reload();
            }
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            var edit = (UndergroundEdit)sender;
            var els = elementi.Where(x => x.Metropolitana.Equals(edit.Metropolitana)).ToList();
            if (els.Count == 1)
            {
                els[0].Enabled = true;
                edits.Remove(edit);
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddUnderground();
            addForm.OnStringConfirm = AddUnderground;
            addForm.ShowDialog();
        }

        private async Task AddUnderground(string s)
        {
            if (metropolitane.Select(x => x.Nome.Replace(" ","")).ToList().Contains(s.Replace(" ","")))
            {
                MessageBox.Show("Non puoi avere 2 metropolitane con lo stesso nome, considera aggiungere dei numeri", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    await SQLServerManager.instance.AddMetropolitana(s);
                }
                catch (Exception e)
                {
                    MessageBox.Show("È stato riscontrato un problema con il database, controlla che la connessione col database sia attiva e riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Reload();
            }
        }
    }
}
