using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Collegamento : IEquatable<Collegamento>
    {
        int id;
        internal int lunghezza;
        int idLinea;
        int idStazioneA;
        int idStazioneB;

        internal int ID
        {
            get
            {
                return id;
            }
        }
        public int Lunghezza
        {
            get
            {
                return lunghezza;
            }
            set
            {
                if (value > 0)
                {
                    lunghezza = value;
                    // TODO: fare update database con nuova lunghezza
                }
            }
        }
        internal int IDLinea
        {
            get
            {
                return idLinea;
            }
        }
        internal int IDStazioneA
        {
            get
            {
                return idStazioneA;
            }
        }
        internal int IDStazioneB
        {
            get
            {
                return idStazioneB;
            }
        }

        internal Collegamento(int id, int lunghezza, int idLinea, int idStazioneA, int idStazioneB)
        {
            this.id = id;
            this.lunghezza = lunghezza;
            this.idLinea = idLinea;
            this.idStazioneA = idStazioneA;
            this.idStazioneB = idStazioneB;
        }

        public bool Equals(Collegamento other)
        {
            return id == other.id;
        }
    }
}
