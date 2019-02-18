using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Linea : IEquatable<Linea>
    {
        int id;
        internal string nome;
        internal int coloreArgb;
        int idMetropolitana;

        internal int ID
        {
            get
            {
                return id;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
        }
        public Color Colore
        {
            get
            {
                return Color.FromArgb(coloreArgb);
            }
            set
            {
                if (!value.IsEmpty)
                {
                    coloreArgb = value.ToArgb();
                    // TODO: fare update database del colore
                }
            }
        }
        internal int IDMetropolitana
        {
            get
            {
                return idMetropolitana;
            }
        }

        internal Linea(int id, string nome, int idMetropolitana, int coloreArgb)
        {
            this.id = id;
            this.idMetropolitana = idMetropolitana;
            this.coloreArgb = coloreArgb;
        }

        internal bool AppartieneA(int idMetropolitana)
        {
            return this.idMetropolitana == idMetropolitana;
        }

        public bool AppartieneA(Metropolitana metropolitana)
        {
            return AppartieneA(metropolitana.ID);
        }

        public bool Equals(Linea other)
        {
            return id == other.id;
        }
    }
}

