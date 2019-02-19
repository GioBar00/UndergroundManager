using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Metropolitana : IEquatable<Metropolitana>
    {
        int id;
        internal string nome;

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

        internal Metropolitana(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public bool Equals(Metropolitana other)
        {
            return id == other.id;
        }
    }
}
