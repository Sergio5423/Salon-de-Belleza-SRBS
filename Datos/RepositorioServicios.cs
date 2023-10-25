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
        public RepositorioServicios() : base()
        {
            
        }

        public void Agregar(Servicios servicio)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Servicios (Codigo,Nombre,Duracion,Valor)" +
                " values (@Codigo,@Nombre,@Duracion,@Valor)";
                Command.Parameters.Add("Codigo", SqlDbType.VarChar).Value = servicio.Codigo;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = servicio.Nombre;
                Command.Parameters.Add("Duracion", SqlDbType.Int).Value = servicio.Duracion;
                Command.Parameters.Add("Valor", SqlDbType.Int).Value = servicio.Valor;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(string codigo)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Servicios where Codigo = '{codigo}'";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Actualizar(string cod, Servicios servicio)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Update Servicios " +
                                      $"Set Nombre = '{servicio.Nombre}', " +
                                      $"Duracion = '{servicio.Duracion}', " +
                                      $"Valor = '{servicio.Valor}'" +
                                      $"WHERE codigo = '{cod}'";                
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public List<Servicios> Filtrar(string nombre, int vinculo)
        {        
            List<Servicios> servicios = new List<Servicios>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"select Nombre,Duracion,Valor " +
                                      $"from Servicios where Nombre " +
                                      $"like '%{nombre}%'";
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

        public List<Servicios> Consultar()
        {
            List<Servicios> servicios = new List<Servicios>();
            var command = connection.CreateCommand();
            command.CommandText = $"select Codigo,Nombre,Duracion,Valor " +
                                  $"from Servicios";
            Open();
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                servicios.Add(Mapeador(lector));
            }
            Close();
            return servicios;
        }

        public Servicios Mapeador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            Servicios servicio = new Servicios();
            servicio.Codigo = dataReader.GetString(0);
            servicio.Nombre = dataReader.GetString(1);
            servicio.Duracion = dataReader.GetInt32(2);
            servicio.Valor = dataReader.GetInt32(3);

            return servicio;
        }
    }
}
