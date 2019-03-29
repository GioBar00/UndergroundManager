using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MetropolitanaInstaceManager
    {
        Metropolitana metropolitana;
        public List<Stazione> stazioni = new List<Stazione>();
        public List<Linea> linee = new List<Linea>();
        public List<Collegamento> collegamenti = new List<Collegamento>();
        UndoRedoStack historyStack = new UndoRedoStack();

        public Metropolitana Metropolitana
        {
            get
            {
                return metropolitana;
            }
        }
        public bool CanUndo
        {
            get
            {
                if (historyStack.UndoCount != 0)
                    return true;
                return false;
            }
        }
        public bool CanRedo
        {
            get
            {
                if (historyStack.RedoCount != 0)
                    return true;
                return false;
            }
        }

        public MetropolitanaInstaceManager(Metropolitana metro)
        {
            metropolitana = metro;
            // get all data
        }



        public Stazione GetStazioneAFrom(Collegamento collegamento)
        {
            return stazioni.Where(x => x.ID == collegamento.IDStazioneA).First();
        }
        public Stazione GetStazioneBFrom(Collegamento collegamento)
        {
            return stazioni.Where(x => x.ID == collegamento.IDStazioneB).First();
        }
        public List<Linea> GetAllLinee()
        {
            return linee;
        }
        public List<Collegamento> GetCollegamentiFrom(Linea linea)
        {
            return collegamenti.Where(x => x.IDLinea == linea.ID).OrderBy(x => x.ID).ToList();
        }

        public async Task Save(IProgress<ProgressReportModel> progress)
        {
            // TODO: save to database using historymanager
        }

    }
}
