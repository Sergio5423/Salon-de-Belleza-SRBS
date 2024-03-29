﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data.OracleClient;

namespace Datos
{
    public class GestorConexion
    {
        public OracleConnection connection = new OracleConnection();

        public GestorConexion()
        {
            try
            {
                connection.ConnectionString = connection.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)))" +
                                          ";User Id=SaRa;Password=123;";

            }
            catch (Exception ex)
            {
                connection = null;
                throw ex;
            }
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
