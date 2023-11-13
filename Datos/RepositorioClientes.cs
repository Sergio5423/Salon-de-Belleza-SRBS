using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Data;
using System.Data.OracleClient;

namespace Datos
{
    public class RepositorioClientes : GestorConexion/*, IOperacionesBD<Clientes>*/
    {
        public RepositorioClientes() : base()
        {
                    
        }

        public void Agregar(Clientes cliente)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Clientes (Cedula,Nombre,Telefono,Correo,Cumpleaños,[Ultima Visita],[Estilista Favorito])" +
                " values (@Cedula,@Nombre,@Telefono,@Correo,@Cumpleaños,@UltimaVisita,@EstilistaFavorito)";
                Command.Parameters.Add("Cedula", SqlDbType.VarChar).Value = cliente.Cedula;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                Command.Parameters.Add("Correo", SqlDbType.VarChar).Value = cliente.Correo;
                Command.Parameters.Add("Cumpleaños", SqlDbType.DateTime).Value = cliente.Cumpleaños;
                Command.Parameters.Add("UltimaVisita", SqlDbType.DateTime).Value = cliente.UltimaVisita;
                Command.Parameters.Add("Empleado_Cedula", SqlDbType.VarChar).Value = cliente.Empleado_Cedula;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(string cedula)
        {
            //BorrarServiciosVinculados(id);
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Clientes where Cedula = '{cedula}'";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }            
        }

        public void Actualizar(string ced, Clientes cliente)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Update Clientes Set " +
                                      "Cedula = @Cedula," +
                                      "Nombre = @Nombre," +
                                      "Telefono = @Telefono," +
                                      "Correo = @Correo," +
                                      "Cumpleaños = @Cumpleaños," +                                
                                      "Empleado_Cedula = @Empleado_Cedula " +
                                      "Where Cedula = @Ced";
                Command.Parameters.Add("Cedula", SqlDbType.VarChar).Value = cliente.Cedula;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                Command.Parameters.Add("Correo", SqlDbType.VarChar).Value = cliente.Correo;
                Command.Parameters.Add("Cumpleaños", SqlDbType.Date).Value = cliente.Cumpleaños.ToShortDateString();
                Command.Parameters.Add("Empleado_Cedula", SqlDbType.VarChar).Value = cliente.Empleado_Cedula;
                Command.Parameters.Add("Ced", SqlDbType.Int).Value = ced;                
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        //public void BorrarServiciosVinculados(int Vinculo)
        //{
        //    using (var Command = connection.CreateCommand())
        //    {
        //        Command.CommandText = $"Delete Servicios where Vinculo = {Vinculo}";
        //        Open();
        //        Command.ExecuteNonQuery();
        //        Close();
        //    }
        //}

        public List<Clientes> Filtrar(string nombre)
        {
            List<Clientes> clientes = new List<Clientes>();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from Clientes where Nombre like '%{nombre}%'";
            Open();
            OracleDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                clientes.Add(Mapeador(lector));
            }
            Close();
            return clientes;
        }

        public List<Clientes> Consultar()
        {
            List<Clientes> clientes = new List<Clientes>();
            var command = connection.CreateCommand();
            command.CommandText = "select * from Clientes";
            Open();
            OracleDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                clientes.Add(Mapeador(lector));
            }
            Close();
            return clientes;
        }

        public Clientes Mapeador(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            Clientes cliente = new Clientes();
            cliente.Cedula = dataReader.GetString(0);
            cliente.Nombre = dataReader.GetString(1);
            cliente.Telefono = dataReader.GetString(2);
            cliente.Correo = dataReader.GetString(3);
            cliente.Cumpleaños = dataReader.GetDateTime(4);
            cliente.UltimaVisita = dataReader.GetDateTime(5);
            cliente.Empleado_Cedula = dataReader.GetString(6);

            return cliente;
        }
    }
}

