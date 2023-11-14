using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Entidades;
using Oracle.ManagedDataAccess.Types;
using Datos;

namespace DatosOracle
{
    public class RepositorioEnpleados : GestorConexion
    {
        public RepositorioEnpleados() : base()
        {
            
        }

        public void Agregar(Empleados empleado)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_empleados.prc_agregar_empleado";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = empleado.Cedula;
                command.Parameters.Add("emp_nombre", OracleDbType.Varchar2).Value = empleado.Nombre;
                command.Parameters.Add("emp_telefono", OracleDbType.Varchar2).Value = empleado.Telefono;

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
                command.CommandText = "pkg_manipular_empleados.prc_eliminar_empleado";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = cedula;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Actualizar(string cedulaANT, Empleados empleado)
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = "pkg_manipular_empleados.prc_actualizar_empleado";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("emp_cedulaANT", OracleDbType.Varchar2).Value = cedulaANT;
                command.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = empleado.Cedula;
                command.Parameters.Add("emp_nombre", OracleDbType.Varchar2).Value = empleado.Nombre;
                command.Parameters.Add("emp_telefono", OracleDbType.Varchar2).Value = empleado.Telefono;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Empleados> Consultar()
        {
            using (OracleConnection connection = new OracleConnection(base.connection.ConnectionString))
            {
                List<Empleados> empleados = new List<Empleados>();
                connection.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = "begin :refcursor1 := pkg_manipular_empleados.func_consultar_empleados ; end;";
                cmd.CommandType = CommandType.Text;                
                cmd.Parameters.Add("refcursor1", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Empleados empleado = new Empleados();
                    empleado.Cedula = rdr.GetString(0);
                    empleado.Nombre = rdr.GetString(1);
                    empleado.Telefono = rdr.GetString(2);                    
                    empleados.Add(empleado);
                }
                Console.ReadLine();
                return empleados;
            }
        }
    }
}
