using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class StazioneElement : Panel
    {
        Stazione stazione;
        public Stazione Stazione
        {
            get
            {
                return stazione;
            }
        }

        bool panning = false;
        Point panMouseStart = new Point();
        Point panThisStart = new Point();

        public StazioneElement(Stazione s) : base()
        {
            stazione = s;
            this.Location = new Point(s.X, s.Y);
            this.BackColor = Color.Wheat;

            var pic = new PictureBox();
            pic.Size = new Size(40, 40);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = UI.Properties.Resources.station;
            
            //pic.Dock = DockStyle.Top;
            pic.MouseDown += (object sender, MouseEventArgs e) => MouseDownE(e);
            pic.MouseMove += (object sender, MouseEventArgs e) => MouseMoveE(e);
            pic.MouseUp += (object sender, MouseEventArgs e) => MouseUpE(e);

            var lbl = new Label();
            lbl.Dock = DockStyle.Bottom;
            lbl.Text = s.Nome + "pepepepepepepepepepe";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = false;
            lbl.MouseDown += (object sender, MouseEventArgs e) => MouseDownE(e);
            lbl.MouseMove += (object sender, MouseEventArgs e) => MouseMoveE(e);
            lbl.MouseUp += (object sender, MouseEventArgs e) => MouseUpE(e);

            int width = TextRenderer.MeasureText(lbl.Text, lbl.Font).Width;
            if (width < 40)
                width = 40;

            this.Size = new Size(width, 65);
            pic.Location = new Point((this.Size.Width - pic.Size.Width) / 2, 0);
            this.Controls.Add(pic);
            this.Controls.Add(lbl);
            
        }

        public void InvalidatePan()
        {
            panning = false;
            this.Location = panThisStart;
            this.Invalidate();
        }

        void MouseDownE(MouseEventArgs e)
        {
            panning = true;
            panMouseStart = new Point(e.Location.X, e.Location.Y);
            panThisStart = new Point(this.Location.X, this.Location.Y);
        }

        void MouseUpE(MouseEventArgs e)
        {
            panning = false;
        }
        void MouseMoveE(MouseEventArgs e)
        {
            if (panning)
            {
                this.Left = e.X + this.Left - panMouseStart.X;
                this.Top = e.Y + this.Top - panMouseStart.Y;
                if (this.Left < 0)
                {
                    MessageBox.Show(this.Left.ToString(), "haha");
                }
            }
        }
    }
}
