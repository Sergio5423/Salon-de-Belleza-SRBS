using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Entidades;
using Datos;

namespace DatosOracle
{
    public class RepositorioClientes : GestorConexion
    {
        public RepositorioClientes() : base()
        {
            
        }

        public void Agregar(Clientes cliente)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_clientes.prc_agregar_cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cl_cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
                command.Parameters.Add("cl_nombre", OracleDbType.Varchar2).Value = cliente.Nombre;
                command.Parameters.Add("cl_telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.Parameters.Add("cl_correo", OracleDbType.Varchar2).Value = cliente.Correo;
                command.Parameters.Add("cl_cumFecha", OracleDbType.Date).Value = cliente.Cumpleaños;
                command.Parameters.Add("cl_ultVisita", OracleDbType.Date).Value = cliente.UltimaVisita;
                command.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = cliente.Empleado_Cedula;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Borrar(string cedula)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_clientes.prc_eliminar_cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cl_cedula", OracleDbType.Varchar2).Value = cedula;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Clientes> Consultar()
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                List<Clientes> clientes = new List<Clientes>();
                connection.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = "begin :refcursor1 := pkg_manipular_clientes.func_consultar_clientes ; end;";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("refcursor1", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Clientes cliente = new Clientes();
                    cliente.Cedula = rdr.GetString(0);
                    cliente.Nombre = rdr.GetString(1);
                    cliente.Telefono = rdr.GetString(2);
                    cliente.Correo = rdr.GetString(3);
                    cliente.Cumpleaños = rdr.GetDateTime(4);
                    cliente.UltimaVisita = rdr.GetDateTime(5);
                    try
                    {
                        cliente.Empleado_Cedula = rdr.GetString(6);
                    } catch
                    {
                        cliente.Empleado_Cedula = "No Disponible";
                    }                    
                    clientes.Add(cliente);
                }
                Console.ReadLine();
                return clientes;
            }
        }

        public void Actualizar(string CedAnt,Clientes cliente)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_clientes.prc_actualizar_cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cl_cedulaANT", OracleDbType.Varchar2).Value = CedAnt;
                command.Parameters.Add("cl_cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
                command.Parameters.Add("cl_nombre", OracleDbType.Varchar2).Value = cliente.Nombre;
                command.Parameters.Add("cl_telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.Parameters.Add("cl_correo", OracleDbType.Varchar2).Value = cliente.Correo;
                command.Parameters.Add("cl_cumFecha", OracleDbType.Date).Value = cliente.Cumpleaños;
                command.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = cliente.Empleado_Cedula;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
