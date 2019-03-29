using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SQLConnectionData
    {
        public string IP { get; set; } = "localhost";
        public uint Port { get; set; } = 3306;
        public string DatabaseName { get; set; } = "";
        public string User { get; set; } = "";
        public string Password { get; set; } = "";

        public SQLConnectionData() { }
        //public SQLConnectionData(string ip, uint port, string databaseName, string user, string password)
        //{
        //    IP = ip;
        //    Port = port;
        //    DatabaseName = databaseName;
        //    User = user;
        //    Password = password;
        //}
    }
}
