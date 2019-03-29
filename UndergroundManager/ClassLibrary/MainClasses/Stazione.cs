using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Stazione : IEquatable<Stazione>
    {
        int id;
        internal string nome;
        int idMetropolitana;
        int x;
        int y;

        public int ID
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
            set
            {
                if (value != null && value != "")
                {
                    nome = value;
                    // TODO: fare update database con nuovo nome
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

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        //TODO: Fix as Internal
        public Stazione(int id, string nome, int idMetropolitana, int x, int y)
        {
            this.id = id;
            this.nome = nome;
            this.idMetropolitana = idMetropolitana;
            this.x = x;
            this.y = y;
        }

        internal bool AppartieneA(int idMetropolitana)
        {
            return this.idMetropolitana == idMetropolitana;
        }

        public bool AppartieneA(Metropolitana metropolitana)
        {
            return AppartieneA(metropolitana.ID);
        }

        public bool Equals(Stazione other)
        {
            return id == other.id;
        }
    }
}
