using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.Admin
{
    public static class AdminDB
    {
        public static string cadena = Datos.Properties.Settings.Default.Key;
        public static SqlConnection connection = new SqlConnection(cadena);
        public static SqlConnection conectarBase()
        {
            connection.Open();
            return connection;
        }
    }
}
