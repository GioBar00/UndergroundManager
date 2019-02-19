using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class UndoRedoStack
    {
        private Stack<ICommand> undo;
        private Stack<ICommand> redo;

        public int UndoCount
        {
            get
            {
                return undo.Count;
            }
        }
        public int RedoCount
        {
            get
            {
                return redo.Count;
            }
        }

        public UndoRedoStack()
        {
            Reset();
        }
        public void Reset()
        {
            undo = new Stack<ICommand>();
            redo = new Stack<ICommand>();
        }

        public void Do(ICommand cmd)
        {
            cmd.Do();
            undo.Push(cmd);
            redo.Clear(); // Once we issue a new command, the redo stack clears
        }
        public void Undo()
        {
            if (undo.Count > 0)
            {
                ICommand cmd = undo.Pop();
                cmd.Undo();
                redo.Push(cmd);

            }
        }
        public void Redo()
        {
            if (redo.Count > 0)
            {
                ICommand cmd = redo.Pop();
                cmd.Do();
                undo.Push(cmd);
            }
        }
    }
}
