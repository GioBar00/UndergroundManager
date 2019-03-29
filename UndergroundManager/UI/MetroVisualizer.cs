using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MetroVisualizer : UserControl
    {
        public MetroVisualizer(Metropolitana m)
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            var stazionePic = new StazioneElement(new Stazione(1, "test", 1, 15, 15));
            this.Controls.Add(stazionePic);
        }
    }
}
