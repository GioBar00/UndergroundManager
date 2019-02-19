using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class AddNewCollegamento : ICommand
    {
        internal int idLinea;
        internal int idStazioneA;
        internal int idStazioneB;

        public AddNewCollegamento(Linea linea, Stazione a, Stazione b)
        {
            idLinea = linea.ID;
            idStazioneA = a.ID;
            idStazioneB = b.ID;
        }

        public void Do()
        {
            // TODO: add collegamento to form
        }

        public void Undo()
        {
            // TODO: remove collegamento from form
        }
    }
}
