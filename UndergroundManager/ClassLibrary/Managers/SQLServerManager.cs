using System;
using System.Collections.Generic;
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

        private MySqlConnection connection;

        public async Task OpenConnectionAsync(string ip, string user, string password, IProgress<ProgressReportModel> progress)
        {
            ProgressReportModel model = new ProgressReportModel();
            model.Percentuale = 10;
            progress.Report(model);
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = ip;
            sb.Database = "undergroundmanager";
            sb.UserID = user;
            sb.Password = password;
            connection = new MySqlConnection(sb.ToString());
            await connection.OpenAsync();
            model.Percentuale = 100;
            progress.Report(model);
        }
    }
}
