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
        internal DateTime dateTimeCreazione;
        internal DateTime dateTimeUltimaModifica;

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

        public DateTime DateTimeCreazione
        {
            get
            {
                return new DateTime(dateTimeCreazione.Ticks);
            }
        }

        public DateTime DateTimeUltimaModifica
        {
            get
            {
                return new DateTime(dateTimeUltimaModifica.Ticks);
            }
            set
            {
                dateTimeUltimaModifica = value;
                // TODO: fare update data su database
            }
        }

        internal Metropolitana(int id, string nome, DateTime creazione, DateTime ultimaModifica)
        {
            this.id = id;
            this.nome = nome;
            dateTimeCreazione = creazione;
            dateTimeUltimaModifica = ultimaModifica;
        }

        public bool Equals(Metropolitana other)
        {
            return id == other.id;
        }
    }
}
