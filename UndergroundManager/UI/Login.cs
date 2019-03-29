using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // TODO: remove after debug
            textBoxPassword.Text = "UndergroundPassword";
            textBoxUsername.Text = "underground";
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            EnableMod(false);
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += updateProgressBarValue;
            try
            {
                SQLConnectionData data = new SQLConnectionData();
                data.IP = UI.Properties.Settings.Default.ServerIP;
                data.Port = UI.Properties.Settings.Default.ServerPort;
                data.DatabaseName = UI.Properties.Settings.Default.ServerDatabaseName;
                data.User = textBoxUsername.Text;
                data.Password = textBoxPassword.Text;
                await SQLServerManager.instance.OpenConnectionNewAsync(data, progress);
                await Task.Delay(400);
                FormManager.instance.OpenMainWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel collegamento al database.\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableMod(true);
            }
        }

        void EnableMod(bool enable)
        {
            pictureBoxDatabaseImpostazioni.Enabled = enable;
            progressBarConnection.Visible = !enable;
            progressBarConnection.Value = 0;
            textBoxPassword.Enabled = enable;
            textBoxUsername.Enabled = enable;
        }

        void updateProgressBarValue(object sender, ProgressReportModel e)
        {
            progressBarConnection.Value = e.Percentuale;
        }

        private void pictureBoxDatabaseImpostazioni_Click(object sender, EventArgs e)
        {
            var confView = new ServerConfigurator();
            confView.ShowDialog();
        }
    }
}
