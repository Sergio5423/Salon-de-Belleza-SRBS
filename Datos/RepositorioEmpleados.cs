using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEmpleados : GestorConexion
    {
        public RepositorioEmpleados() : base()
        {
            
        }

        public void Agregar(Empleados empleado)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Empleados (Cedula,Nombre,Telefono)" +
                " values (@Cedula,@Nombre,@Telefono)";
                Command.Parameters.Add("Cedula", SqlDbType.VarChar).Value = empleado.Cedula;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = empleado.Telefono;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(string cedula)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Empleados where Cedula = '{cedula}'";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Actualizar(string ced, Empleados empleado)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Update Empleados Set Cédula = @Cedula," +
                                                           "Nombre = @Nombre" +
                                                           "Telefono = @Telefono" +    
                                                           
                                                           " Where Cedula = '@CedulaAnt'";
                Command.Parameters.Add("Cedula", SqlDbType.VarChar).Value = empleado.Cedula;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = empleado.Telefono;


                Command.Parameters.Add("CedulaAnt", SqlDbType.Int).Value = ced;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }        

        //public void AgregarTrabajo(int codigo, int generado, int comision)
        //{
        //    using (var Command = connection.CreateCommand())
        //    {
        //        Command.CommandText = "Update Empleados Set Generado = @Generado," +
        //                                                   "Comisión = @Comision " +


        //                                                   "Where Id = @Id";
        //        Command.Parameters.Add("Generado", SqlDbType.Int).Value = generado;
        //        Command.Parameters.Add("Comision", SqlDbType.Int).Value = comision;


        //        Command.Parameters.Add("Id", SqlDbType.Int).Value = id;
        //        Open();
        //        Command.ExecuteNonQuery();
        //       Close();
        //    }
        //}

        public List<Empleados> Filtrar(string nombre)
        {
            List<Empleados> empleados = new List<Empleados>();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from Empleados where Nombre like '%{nombre}%'";
            Open();
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                empleados.Add(Mapeador(lector));
            }
            Close();
            return empleados;
        }

        public List<Empleados> Consultar()
        {
            List<Empleados> empleados = new List<Empleados>();
            var command = connection.CreateCommand();
            command.CommandText = "select * from Empleados";
            Open();
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                empleados.Add(Mapeador(lector));
            }
            Close();
            return empleados;
        }

        public Empleados Mapeador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            Empleados empleado = new Empleados();            
            empleado.Cedula = dataReader.GetString(0);
            empleado.Nombre = dataReader.GetString(1);
            empleado.Telefono = dataReader.GetString(2);
            return empleado;
        }
    }
}
