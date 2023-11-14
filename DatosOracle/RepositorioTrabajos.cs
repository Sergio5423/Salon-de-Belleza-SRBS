using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Entidades;
using Datos;

namespace DatosOracle
{
    public class RepositorioTrabajos : GestorConexion
    {
        public RepositorioTrabajos() : base()
        {

        }

        public void Borrar(string codigo)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_trabajos.prc_eliminar_trabajo";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("trab_codigo", OracleDbType.Int32).Value = int.Parse(codigo);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Trabajos> Consultar()
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                List<Trabajos> trabajos = new List<Trabajos>();
                connection.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = "begin :refcursor1 := pkg_manipular_trabajos.func_consultar_trabajos ; end;";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("refcursor1", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Trabajos trabajo = new Trabajos();
                    trabajo.Codigo = (rdr.GetInt32(0)).ToString();
                    trabajo.Comision = rdr.GetInt32(1);
                    trabajo.Fecha = rdr.GetString(2);
                    try
                    {
                        trabajo.Empleado_Cedula = rdr.GetString(3);
                    }
                    catch
                    {
                        trabajo.Empleado_Cedula = "No Disponible";
                    }
                    trabajo.Servicio_Codigo = rdr.GetString(4);
                    trabajos.Add(trabajo);
                }
                Console.ReadLine();
                return trabajos;
            }
        }

        public List<Trabajos> ConsultarPorEmpleado(string ced)
        {
            List<Trabajos> trabajos = new List<Trabajos>();
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand("pkg_manipular_trabajos.func_consultar_trabajos_empleado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    OracleParameter inputParameter = new OracleParameter("emp_cedula", OracleDbType.Varchar2);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.Value = ced;
                    command.Parameters.Add(inputParameter);

                    OracleParameter outputParameter = new OracleParameter("cur_trabajos", OracleDbType.Varchar2);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);
                    OracleDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Trabajos trabajo = new Trabajos();
                        trabajo.Codigo = (rdr.GetInt32(0)).ToString();
                        trabajo.Comision = rdr.GetInt32(1);
                        trabajo.Fecha = rdr.GetString(2);
                        trabajo.Servicio_Codigo = (rdr.GetInt32(3)).ToString();
                        trabajos.Add(trabajo);
                    }
                    Console.ReadLine();
                    return trabajos;
                }
            }
            { //using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
              //{
              //    List<Trabajos> trabajos = new List<Trabajos>();
              //    connection.Open();
              //    OracleCommand cmd = new OracleCommand();
              //    cmd.Connection = connection;
              //    cmd.CommandText = "begin :refcursor1 := pkg_manipular_trabajos.func_consultar_trabajos_empleado ; end;";
              //    cmd.CommandType = CommandType.Text;
              //    cmd.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = ced;
              //    cmd.Parameters.Add("cur_trabajos", OracleDbType.RefCursor, ParameterDirection.Output);
              //    OracleDataReader rdr = cmd.ExecuteReader();
              //    while (rdr.Read())
              //    {
              //        Trabajos trabajo = new Trabajos();
              //        trabajo.Codigo = (rdr.GetInt32(0)).ToString();
              //        trabajo.Comision = rdr.GetInt32(1);
              //        trabajo.Fecha = rdr.GetString(2);
              //        trabajo.Servicio_Codigo = (rdr.GetInt32(3)).ToString();
              //        trabajos.Add(trabajo);
              //    }
              //    Console.ReadLine();
              //    return trabajos;
              //}}


            }
        }
    }
}
