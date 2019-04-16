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
        PictureBox image = new PictureBox();
        Label lbl = new Label();
        private SizeF currentScaleFactor = new SizeF(1f, 1f);

        bool canPan = true;
        bool panning = false;
        Point panMouseStart = new Point();
        // TODO: Check if remove invalidate pan
        Point panThisStart = new Point();

        Point outOfContainer = new Point();
        public Point maxPoint = new Point(10000, 10000);

        public StazioneElement(Stazione s, bool canPan) : base()
        {
            stazione = s;
            this.canPan = canPan;
            this.BackColor = Color.Wheat;
            LoadResurces();
        }
        public StazioneElement(Stazione s) : this(s, true) {  }


        void LoadResurces()
        {
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.Image = UI.Properties.Resources.station;

            image.MouseDown += (object sender, MouseEventArgs e) => MouseDownE(e);
            image.MouseMove += (object sender, MouseEventArgs e) => MouseMoveE(e);
            image.MouseUp += (object sender, MouseEventArgs e) => MouseUpE(e);

            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = false;
            lbl.MouseDown += (object sender, MouseEventArgs e) => MouseDownE(e);
            lbl.MouseMove += (object sender, MouseEventArgs e) => MouseMoveE(e);
            lbl.MouseUp += (object sender, MouseEventArgs e) => MouseUpE(e);

            this.Controls.Add(image);
            this.Controls.Add(lbl);

            Reload();
        }

        public void Reload()
        {
            this.Location = new Point(stazione.X, stazione.Y);
            image.Size = new Size(40, 40);

            lbl.Text = stazione.Nome;
            lbl.BackColor = Color.Beige;

            int width = TextRenderer.MeasureText(lbl.Text, lbl.Font).Width;
            lbl.Width = width;
            if (width < 40)
                width = 40;

            this.Size = new Size(width, image.Height + lbl.Height + 5);
            lbl.Location = new Point((this.Size.Width - lbl.Size.Width) / 2, image.Height + 5);
            image.Location = new Point((this.Size.Width - image.Size.Width) / 2, 0);
        }

        public void InvalidatePan()
        {
            panning = false;
            this.Location = panThisStart;
            this.Invalidate();
        }

        void MouseDownE(MouseEventArgs e)
        {
            if (canPan)
            {
                panning = true;
                panMouseStart = new Point(e.Location.X, e.Location.Y);
                panThisStart = new Point(this.Location.X, this.Location.Y);
            }
        }

        void MouseUpE(MouseEventArgs e)
        {
            panning = false;
            outOfContainer = new Point();
        }
        void MouseMoveE(MouseEventArgs e)
        {
            if (panning)
            {
                if (this.Left <= 0)
                {
                    outOfContainer.X = -(e.X - panMouseStart.X);
                    if (outOfContainer.X > 0)
                    {
                        this.Left = 0;
                    }
                    else
                    {
                        this.Left = e.X + this.Left - panMouseStart.X;
                    }

                }
                else
                {
                    if (this.Left + this.Width >= maxPoint.X)
                    {
                        outOfContainer.X = (e.X - panMouseStart.X);
                        if (outOfContainer.X > 0)
                        {
                            this.Left = maxPoint.X - this.Width;
                        }
                        else
                        {
                            this.Left = e.X + this.Left - panMouseStart.X;
                        }
                    }
                    else
                    {
                        this.Left = e.X + this.Left - panMouseStart.X;
                    }
                    
                }

                if (this.Top <= 0)
                {
                    outOfContainer.Y = -(e.Y - panMouseStart.Y);
                    if (outOfContainer.Y > 0)
                    {
                        this.Top = 0;
                    }
                    else
                    {
                        this.Top = e.Y + this.Top - panMouseStart.Y;
                    }

                }
                else
                {
                    if (this.Top + this.Height >= maxPoint.Y)
                    {
                        outOfContainer.Y = (e.Y - panMouseStart.Y);
                        if (outOfContainer.Y > 0)
                        {
                            this.Top = maxPoint.Y - this.Height;
                        }
                        else
                        {
                            this.Top = e.Y + this.Top - panMouseStart.Y;
                        }
                    }
                    else
                    {
                        this.Top = e.Y + this.Top - panMouseStart.Y;
                    }
                    
                }
            }
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);

            this.currentScaleFactor = new SizeF(this.currentScaleFactor.Width * factor.Width, this.currentScaleFactor.Height * factor.Height);
            lbl.Font = new Font(lbl.Font.FontFamily, 8f * currentScaleFactor.Width * 0.9f);
        }
    }
}
