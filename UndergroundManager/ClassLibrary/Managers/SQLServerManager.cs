using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class SQLServerManager
    {
        public static SQLServerManager instance = new SQLServerManager();
        private SQLServerManager() { }

        string dataOraFormat = "yyyy-MM-dd hh:mm:ss";

        #region Connection
        public event StateChangeEventHandler OnConnectionStateChange;

        private SQLConnectionData data;

        private MySqlConnection conn;
        private MySqlConnection Connection
        {
            get
            {
                return conn;
            }
            set
            {
                conn = value;
                // TODO: ricordare di aggiungere evento per ogni istanza di mod metropolitana
                conn.StateChange += Conn_StateChange;
            }
        }

        private void Conn_StateChange(object sender, StateChangeEventArgs e)
        {
            OnConnectionStateChange(sender, e);
        }

        public ConnectionState ConnectionState
        {
            get
            {
                if (conn != null)
                {
                    return conn.State;
                }
                return ConnectionState.Closed;
            }
        }

        public async Task OpenConnectionAsync(IProgress<ProgressReportModel> progress)
        {
            ProgressReportModel model = new ProgressReportModel();
            model.Percentuale = 10;
            progress.Report(model);
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = data.IP;
            sb.Port = data.Port;
            sb.Database = data.DatabaseName;
            sb.UserID = data.User;
            sb.Password = data.Password;
            Connection = new MySqlConnection(sb.ToString());
            await Connection.OpenAsync();
            model.Percentuale = 100;
            progress.Report(model);
        }
        public async Task OpenConnectionNewAsync(SQLConnectionData data, IProgress<ProgressReportModel> progress)
        {
            this.data = data;
            if (Connection != null)
            {
                await Connection.CloseAsync();
            }
            await OpenConnectionAsync(progress);
        }

        private async Task ForceOpenConnection()
        {
            if (ConnectionState == ConnectionState.Closed)
            {
                await OpenConnectionAsync(new Progress<ProgressReportModel>());
            }
        }
        #endregion
        #region Command Execution
        private async Task ExecuteNonQueryAsync(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            await cmd.ExecuteNonQueryAsync();
        }

        private async Task<DbDataReader> StartExecuteQueryAsync(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            return await cmd.ExecuteReaderAsync();
        }

        private void EndExecuteQuery(DbDataReader rdr)
        {
            rdr.Close();
        }
        #endregion
        #region Metropolitana
        public Metropolitana ParseMetropolitana(DbDataReader rdr)
        {
            int id = (int)rdr["idmetropolitana"];
            string nome = rdr["nome"].ToString();
            DateTime creazione = rdr.GetDateTime(2);
            DateTime mod = rdr.GetDateTime(3);
            return new Metropolitana(id, nome, creazione, mod);
        }
        public async Task<List<Metropolitana>> GetMetropolitaneAsync(IProgress<ProgressReportModel> progress)
        {
            await ForceOpenConnection();
            List<Metropolitana> metro = new List<Metropolitana>();
            var percent = new ProgressReportModel();
            percent.Percentuale = 10;
            progress.Report(percent);
            string query = "select * from metropolitana;";
            DbDataReader rdr = await StartExecuteQueryAsync(query);
            while (rdr.Read())
            {
                metro.Add(ParseMetropolitana(rdr));
            }
            EndExecuteQuery(rdr);
            percent.Percentuale = 100;
            progress.Report(percent);
            return metro;
        }

        public async Task<Metropolitana> GetMetropolitanaAsync(int id, IProgress<ProgressReportModel> progress)
        {
            await ForceOpenConnection();
            Metropolitana metro = null;
            var percent = new ProgressReportModel();
            percent.Percentuale = 10;
            progress.Report(percent);
            string query = $"select * from metropolitana where idmetropolitana = { id.ToString() };";
            DbDataReader rdr = await StartExecuteQueryAsync(query);
            while (rdr.Read())
            {
                metro = ParseMetropolitana(rdr);
            }
            EndExecuteQuery(rdr);
            percent.Percentuale = 100;
            progress.Report(percent);
            return metro;
        }
        public async Task AddMetropolitana(string nome)
        {
            await ForceOpenConnection();
            string query = $"insert into metropolitana (nome, dataOraCreazione, dataOraUltimaModifica) values (\"{ nome }\", '{ DateTime.Now.ToString(dataOraFormat)}', '{ DateTime.Now.ToString(dataOraFormat)}')";
            await ExecuteNonQueryAsync(query);
        }
        public async Task DeleteMetropolitana(Metropolitana metro)
        {
            await ForceOpenConnection();
            string query = $"delete from metropolitana where idmetropolitana = { metro.ID }";
            await ExecuteNonQueryAsync(query);
        }
        public async Task RenameMetropolitana(Metropolitana metro, string nome)
        {
            await ForceOpenConnection();
            string query = $"update metropolitana set nome = '{ nome }' where idmetropolitana = { metro.ID }";
            await ExecuteNonQueryAsync(query);
        }
        #endregion
        #region Stazione
        public Stazione ParseStazione(DbDataReader rdr)
        {
            int id = (int)rdr["idstazione"];
            string nome = rdr["nome"].ToString();
            int idmetro = (int)rdr["idmetropolitana"];
            int x = (int)rdr["x"];
            int y = (int)rdr["y"];
            return new Stazione(id, nome, idmetro, x, y);
        }
        public async Task<List<Stazione>> GetStazioniAsync(Metropolitana metro, IProgress<ProgressReportModel> progress)
        {
            await ForceOpenConnection();
            List<Stazione> stazioni = new List<Stazione>();
            var percent = new ProgressReportModel();
            percent.Percentuale = 10;
            progress.Report(percent);
            string query = $"select * from stazione where idmetropolitana = { metro.ID };";
            DbDataReader rdr = await StartExecuteQueryAsync(query);
            while (rdr.Read())
            {
                stazioni.Add(ParseStazione(rdr));
            }
            EndExecuteQuery(rdr);
            percent.Percentuale = 100;
            progress.Report(percent);
            return stazioni;
        }
        #endregion
        #region Linea
        public Linea ParseLinea(DbDataReader rdr)
        {
            int id = (int)rdr["idlinea"];
            string nome = rdr["nome"].ToString();
            int colArgb = (int)rdr["colore"];
            int idmetro = (int)rdr["idmetropolitana"];
            return new Linea(id, nome, idmetro, colArgb);
        }
        public async Task<List<Linea>> GetLineeAsync(Metropolitana metro, IProgress<ProgressReportModel> progress)
        {
            await ForceOpenConnection();
            List<Linea> linee = new List<Linea>();
            var percent = new ProgressReportModel();
            percent.Percentuale = 10;
            progress.Report(percent);
            string query = $"select * from linea where idmetropolitana = { metro.ID };";
            DbDataReader rdr = await StartExecuteQueryAsync(query);
            while (rdr.Read())
            {
                linee.Add(ParseLinea(rdr));
            }
            EndExecuteQuery(rdr);
            percent.Percentuale = 100;
            progress.Report(percent);
            return linee;
        }
        #endregion
    }
}
