using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ServerConfigurator : Form
    {
        public ServerConfigurator()
        {
            InitializeComponent();
            textBoxIP.Text = UI.Properties.Settings.Default.ServerIP;
            numericUpDownPort.Value = UI.Properties.Settings.Default.ServerPort;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplica_Click(object sender, EventArgs e)
        {
            //TODO: check valid ip
            UI.Properties.Settings.Default.ServerIP = textBoxIP.Text;
            UI.Properties.Settings.Default.ServerPort = Convert.ToUInt32(numericUpDownPort.Value);
            UI.Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
