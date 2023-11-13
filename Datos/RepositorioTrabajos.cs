using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class RepositorioTrabajos : GestorConexion/*, IOperacionesBD<Trabajos>*/
    {
        public RepositorioTrabajos() : base()
        {
            
        }

        public void Agregar(Trabajos trabajo)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Trabajos (Codigo,Comision,Fecha,Servicio_Codigo,Empleado_Cedula)" +
                " values (@Codigo,@Comision,@Fecha,@Servicio_Codigo,@Empleado_Cedula)";
                Command.Parameters.Add("Codigo", SqlDbType.VarChar).Value = trabajo.Codigo;
                Command.Parameters.Add("Comision", SqlDbType.Int).Value = trabajo.Comision;
                Command.Parameters.Add("Fecha", SqlDbType.DateTime).Value = trabajo.Fecha;
                Command.Parameters.Add("Servicio_Codigo", SqlDbType.VarChar).Value = trabajo.Servicio_Codigo;
                Command.Parameters.Add("Empleado_Cedula", SqlDbType.VarChar).Value = trabajo.Empleado_Cedula;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(string codigo)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Trabajos where Codigo = '{codigo}'";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        //public void Actualizar(Trabajos trabajo)
        //{
        //    using (var Command = connection.CreateCommand())
        //    {
        //        Command.CommandText = "Update Trabajos Set Codigo = @Codigo," +
        //                                                   "Comision = @Comision" +
        //                                                   "Fecha = @Fecha" +
        //                                                   "" +    
                                                           
        //                                                   " Where Cedula = '@Cedula'";
        //        Command.Parameters.Add("Cedula", SqlDbType.VarChar).Value = empleado.Cedula;
        //        Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
        //        Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = empleado.Telefono;


        //        Command.Parameters.Add("Cedula", SqlDbType.Int).Value = empleado.Cedula;
        //        Open();
        //        Command.ExecuteNonQuery();
        //        Close();
        //    }
        //}        

        public List<Trabajos> Filtrar(string nombre)
        {
            List<Trabajos> empleados = new List<Trabajos>();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from Trabajos where Nombre like '%{nombre}%'";
            Open();
            OracleDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                empleados.Add(Mapeador(lector));
            }
            Close();
            return empleados;
        }

        public List<Trabajos> Consultar()
        {
            List<Trabajos> trabajos = new List<Trabajos>();
            var command = connection.CreateCommand();
            command.CommandText = "select * from Trabajos";
            Open();
            OracleDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                trabajos.Add(Mapeador(lector));
            }
            Close();
            return trabajos;
        }

        public List<Trabajos> ConsultarPorEmpleado(string ced)
        {
            List<Trabajos> trabajos = new List<Trabajos>();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from Trabajos " +
                                  $"WHERE Empleado_Cedula = '{ced}'";
            Open();
            OracleDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                trabajos.Add(Mapeador(lector));
            }
            Close();
            return trabajos;
        }

        public Trabajos Mapeador(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            Trabajos trabajo = new Trabajos();
            trabajo.Codigo = dataReader.GetString(0);
            trabajo.Comision = dataReader.GetInt32(1);
            trabajo.Fecha = dataReader.GetDateTime(2);
            trabajo.Servicio_Codigo = dataReader.GetString(3);
            trabajo.Empleado_Cedula = dataReader.GetString(4);
            return trabajo;
        }
    }
}
