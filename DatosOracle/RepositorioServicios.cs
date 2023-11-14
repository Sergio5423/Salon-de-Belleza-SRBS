using Datos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Entidades;

namespace DatosOracle
{
    public class RepositorioServicios : GestorConexion
    {
        public RepositorioServicios() : base()
        {

        }

        public void Agregar(Servicios servicio)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();                
                command.Connection = connection;
                command.CommandText = "pkg_manipular_servicios.prc_agregar_servicio";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("ser_nombre", OracleDbType.Varchar2).Value = servicio.Nombre;
                command.Parameters.Add("ser_duracion", OracleDbType.Int32).Value = servicio.Duracion;
                command.Parameters.Add("ser_valor", OracleDbType.Int32).Value = servicio.Valor;
        
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();                
            }
        }

        public string Borrar(string codigo)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                try
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = connection;
                    command.CommandText = "pkg_manipular_servicios.prc_eliminar_servicio";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("ser_codigo", OracleDbType.Int32).Value = int.Parse(codigo);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return "Eliminado";
                } catch (Exception e)
                {
                    return "Error";
                }
                
            }
        }

        public List<Servicios> Consultar()
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                List<Servicios> servicios = new List<Servicios>();
                connection.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = "begin :refcursor1 := pkg_manipular_servicios.func_consultar_servicios ; end;";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("refcursor1", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader rdr = cmd.ExecuteReader();                
                while (rdr.Read())
                {
                    Servicios servicio = new Servicios();
                    servicio.Codigo = (rdr.GetInt32(0)).ToString();
                    servicio.Nombre = rdr.GetString(1);
                    servicio.Duracion = rdr.GetInt32(2);
                    servicio.Valor = rdr.GetInt32(3);
                    servicios.Add(servicio);
                }
                Console.ReadLine();
                return servicios;
            }
        }
    }
}
