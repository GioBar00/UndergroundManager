using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class RemoveCollegamento : ICommand
    {
        internal Collegamento collegamento;
        public event EventHandler<Collegamento> OnDo;
        public event EventHandler<Collegamento> OnUndo;

        public RemoveCollegamento(Collegamento coll)
        {
            collegamento = coll;
        }

        public void Do()
        {
            // TODO: remove collegamento from form
            OnDo(this, collegamento);
        }

        public void Undo()
        {
            // TODO: add collegamento to form
            OnUndo(this, collegamento);
        }
    }
}
