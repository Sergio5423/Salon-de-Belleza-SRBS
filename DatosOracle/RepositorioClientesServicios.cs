using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Entidades;
using Oracle.ManagedDataAccess.Types;
using Datos;

namespace DatosOracle
{
    public class RepositorioClientesServicios : GestorConexion
    {
        public RepositorioClientesServicios() : base()         
        {
            
        }

        public void Agregar(Clientes_Servicios cliente_servicio)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_clientes_servicios.prc_agregar_clientes_servicios";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("sc_cliente_ced", OracleDbType.Varchar2).Value = cliente_servicio.Cedula_Cliente;
                command.Parameters.Add("sc_servicio_cod", OracleDbType.Int32).Value = int.Parse(cliente_servicio.Codigo_Servicio);
                command.Parameters.Add("sc_empleado_ced", OracleDbType.Varchar2).Value = cliente_servicio.Empleado_Cedula;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        /*Consulta los servicios que tiene el cliente*/
        public List<Servicios> Consultar(string ced)
        {            
                using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
                {
                    List<Servicios> servicios = new List<Servicios>();
                    connection.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "begin :refcursor1 := pkg_manipular_clientes_servicios.func_consultar_clientes_servicios ; end;";
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.Add("sc_cliente_ced", OracleDbType.Varchar2).Value = ced;
                    cmd.Parameters.Add("refcursor1", OracleDbType.RefCursor, ParameterDirection.Output);
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Servicios servicio = new Servicios();
                        servicio.Codigo = rdr.GetInt32(0).ToString();
                        servicio.Nombre = rdr.GetString(1);
                        servicio.Duracion = rdr.GetInt32(2);
                        servicio.Valor = rdr.GetInt32(3);
                        servicios.Add(servicio);
                    }
                    Console.ReadLine();
                    return servicios;
                }

        }

        public void BorrarCliente(string cedula)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_clientes_servicios.prc_eliminar_cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("sc_cliente_ced", OracleDbType.Varchar2).Value = cedula;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void BorrarServicio(string codigo, string cedula)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_clientes_servicios.prc_eliminar_servicio";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("sc_cliente_ced", OracleDbType.Varchar2).Value = cedula;
                command.Parameters.Add("sc_servicio_cod", OracleDbType.Int32).Value = int.Parse(codigo);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
