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

        internal Stazione(int id, string nome, int idMetropolitana)
        {
            this.id = id;
            this.idMetropolitana = idMetropolitana;
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
