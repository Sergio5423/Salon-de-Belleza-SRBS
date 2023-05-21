using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class GestorConexion
    {
        protected SqlConnection connection;

        public GestorConexion()
        {
            string connectionString = "server=SERGIOPC ; database=BDSalonDeBelleza ; trusted_connection = true ; multipleactiveresultsets = true";
            connection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
