using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UndergroundManager
    {
        public static UndergroundManager instance = new UndergroundManager();
        private UndergroundManager() { }

        Metropolitana metropolitana;
        List<Stazione> stazioni = new List<Stazione>();
        List<Linea> linee = new List<Linea>();
        List<Collegamento> collegamenti = new List<Collegamento>();

        public List<Metropolitana> GetAllMetropolitane()
        {
            // TODO: SQL get all metropolitane
            return null;
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
        
        public async Task Save()
        {
            // TODO: save to database using historymanager
        }
        public void OpenNew(Metropolitana metropolitana)
        {
            // TODO: clear & Get data from database
            this.metropolitana = metropolitana;
        }
    }
}
