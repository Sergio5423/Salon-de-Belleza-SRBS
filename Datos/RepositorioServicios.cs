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
    public class RepositorioServicios : GestorConexion
    {
        public void Agregar(ServiciosEscritura servicio)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Servicios (Vinculo,Nombre,Valor,Duracion,Regreso)" +
                " values (@Vinculo,@Nombre,@Valor,@Duracion,@Regreso)";
                Command.Parameters.Add("Vinculo", SqlDbType.Int).Value = servicio.Vinculo;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = servicio.Nombre;
                Command.Parameters.Add("Valor", SqlDbType.Int).Value = servicio.Valor;
                Command.Parameters.Add("Duracion", SqlDbType.Int).Value = servicio.Duracion;
                Command.Parameters.Add("Regreso", SqlDbType.DateTime).Value = servicio.Regreso;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(int id)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Servicios where Id = {id}";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Actualizar(ServiciosEscritura servicio)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Update Servicios Set Nombre = '{servicio.Nombre}', Valor = '{servicio.Valor}', Duracion = '{servicio.Duracion}', Regreso = '{servicio.Regreso}'";                
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public List<ServiciosLectura> Filtrar(string nombre, int vinculo)
        {        
            List<ServiciosLectura> servicios = new List<ServiciosLectura>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"select Id,Nombre,Valor,Duracion,Regreso from Servicios where Nombre like '%{nombre}%' and Vinculo = '{vinculo}'";
                Open();
                SqlDataReader lector = command.ExecuteReader();
                while (lector.Read())
                {
                    servicios.Add(Mapeador(lector));
                }
                Close();
            }                        
            return servicios;
        }

        public List<ServiciosLectura> Consultar(int vinculo)
        {
            List<ServiciosLectura> servicios = new List<ServiciosLectura>();
            var command = connection.CreateCommand();
            command.CommandText = $"select Id,Nombre,Valor,Duracion,Regreso from Servicios where Vinculo like '%{vinculo}%'";
            Open();
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                servicios.Add(Mapeador(lector));
            }
            Close();
            return servicios;
        }

        public ServiciosLectura Mapeador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            ServiciosLectura servicio = new ServiciosLectura();
            servicio.Id = dataReader.GetInt32(0).ToString();
            servicio.Nombre = dataReader.GetString(1);
            servicio.Valor = dataReader.GetInt32(2).ToString();
            servicio.Duracion = dataReader.GetInt32(3).ToString();
            servicio.Regreso = dataReader.GetDateTime(4).ToShortDateString();

            return servicio;
        }
    }
}
