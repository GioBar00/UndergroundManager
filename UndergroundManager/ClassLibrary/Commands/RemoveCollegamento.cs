using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class RemoveCollegamento : ICommand
    {
        internal int idLinea;
        internal int idStazioneA;
        internal int idStazioneB;

        internal RemoveCollegamento(int idLinea, int idStazioneA, int idStazioneB)
        {
            this.idLinea = idLinea;
            this.idStazioneA = idStazioneA;
            this.idStazioneB = idStazioneB;
        }
        public RemoveCollegamento(Linea linea, Stazione a, Stazione b) : this(linea.ID, a.ID, b.ID)
        { }
        public RemoveCollegamento(Collegamento coll) : this(coll.IDLinea, coll.IDStazioneA, coll.IDStazioneB)
        { }

        public void Do()
        {
            // TODO: remove collegamento from form
            
        }

        public void Undo()
        {
            // TODO: add collegamento to form
        }
    }
}
