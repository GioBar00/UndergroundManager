using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class AddNewCollegamento : ICommand
    {
        internal Collegamento collegamento;
        public event EventHandler<Collegamento> OnDo;
        public event EventHandler<Collegamento> OnUndo;

        public AddNewCollegamento(Collegamento coll)
        {
            collegamento = coll;
        }
        public AddNewCollegamento(Linea linea, Stazione a, Stazione b, int lunghezza) : this(linea.ID, a.ID, b.ID, lunghezza) { }
        internal AddNewCollegamento(int idLinea, int idStazioneA, int idStazioneB, int lunghezza)
        {
            collegamento = new Collegamento(0, lunghezza, idLinea, idStazioneA, idStazioneB);
        }

        public void Do()
        {
            // TODO: add collegamento to form
            OnDo(this, collegamento);
        }

        public void Undo()
        {
            // TODO: remove collegamento from form
            OnUndo(this, collegamento);
        }
    }
}
