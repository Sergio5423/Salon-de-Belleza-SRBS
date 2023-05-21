using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Data;

namespace Datos
{
    public class RepositorioClientes : GestorConexion, IOperacionesBD<Clientes>
    {
        RepositorioServicios repositorioServicios = new RepositorioServicios();

        public void Agregar(Clientes cliente)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Clientes (Nombre,Telefono,Correo,Cumpleaños,UltimaVisita)" +
                " values (@Nombre,@Telefono,@Correo,@Cumpleaños,@UltimaVisita)";
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                Command.Parameters.Add("Correo", SqlDbType.VarChar).Value = cliente.Correo;
                Command.Parameters.Add("Cumpleaños", SqlDbType.DateTime).Value = cliente.Cumpleaños;
                Command.Parameters.Add("UltimaVisita", SqlDbType.DateTime).Value = cliente.UltimaVisita;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(int id)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Delete Clientes" +
                 $"where Id = {id}";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
            repositorioServicios.Borrar(id);
        }

        public List<Clientes> Filtrar(string dato)
        {
            List<Clientes> clientes = new List<Clientes>();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from Clientes where Nombre like '%{dato}%'";
            Open();
            SqlDataReader lector = command.ExecuteReader();
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
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                clientes.Add(Mapeador(lector));
            }
            Close();
            return clientes;
        }

        public Clientes Mapeador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            Clientes cliente = new Clientes();
            cliente.Id = dataReader.GetInt32(0);
            cliente.Nombre = dataReader.GetString(1);
            cliente.Telefono = dataReader.GetString(2);
            cliente.Correo = dataReader.GetString(3);
            cliente.Cumpleaños = dataReader.GetDateTime(4);
            cliente.UltimaVisita = dataReader.GetDateTime(5);

            return cliente;
        }
    }
}

