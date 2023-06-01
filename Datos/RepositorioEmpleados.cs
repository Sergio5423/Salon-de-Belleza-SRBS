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
    public class RepositorioEmpleados : GestorConexion, IOperacionesBD<Empleados>
    {
        public void Actualizar(Empleados empleado)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Update Empleados Set Cédula = @Cedula," +
                                                           "Nombre = @Nombre," +    
                                                           

                                                           "Where Id = @Id";
                Command.Parameters.Add("Cedula", SqlDbType.VarChar).Value = empleado.Ced;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                

                Command.Parameters.Add("Id", SqlDbType.Int).Value = empleado.Id;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Agregar(Empleados empleado)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Empleados (Cédula,Nombre,Generado,Comisión)" +
                " values (@Cedula,@Nombre,@Generado,@Comision)";
                Command.Parameters.Add("Cedula", SqlDbType.VarChar).Value = empleado.Ced;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                Command.Parameters.Add("Generado", SqlDbType.Int).Value = empleado.Generado;
                Command.Parameters.Add("Comision", SqlDbType.Int).Value = empleado.Comision;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void AgregarTrabajo(int id, int generado, int comision)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Update Empleados Set Generado = @Generado," +
                                                           "Comisión = @Comision " +


                                                           "Where Id = @Id";
                Command.Parameters.Add("Generado", SqlDbType.Int).Value = generado;
                Command.Parameters.Add("Comision", SqlDbType.Int).Value = comision;


                Command.Parameters.Add("Id", SqlDbType.Int).Value = id;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(int id)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Empleados where Id = {id}";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

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
            empleado.Id = dataReader.GetInt32(0);
            empleado.Ced = dataReader.GetString(1);
            empleado.Nombre = dataReader.GetString(2);
            empleado.Generado = dataReader.GetInt32(3);
            empleado.Comision = dataReader.GetInt32(4);

            return empleado;
        }
    }
}
