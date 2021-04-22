using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Classes
{
    class Connection
    {
        private string connectionString;

        public Connection()
        {
            ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=APP_MUSIC;Integrated Security=True";
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }
    }
}
