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
    public class RepositorioServicios : GestorConexion, IOperacionesBD<Servicios>
    {
        public void Agregar(Servicios servicio)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Servicios (Id,Nombre,Valor,Duracion,Regreso)" +
                " values (@Id,@Nombre,@Valor,@Duracion,@Regreso)";
                Command.Parameters.Add("Id", SqlDbType.Int).Value = servicio.Id;
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
                Command.CommandText = "Delete Servicios" +
                 $"where Id = {id}";      /*No puede eliminar por id, 
                                           * todos son iguales*/
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public List<Servicios> Filtrar(string dato)
        {
            {
                //foreach (var item in Consultar())
                //{
                //    try
                //    {
                //        if (item.Id == int.Parse(dato))
                //        {
                //            return item;
                //        }
                //    }
                //    catch (Exception)
                //    {

                //    }

                //    if (item.Nombre == dato)
                //    {
                //        return item;
                //    }                                          
                //}
                //return null;
            }
            List<Servicios> servicios = new List<Servicios>();
            var command = connection.CreateCommand();
            command.CommandText = $"select Nombre,Valor,Duracion,Regreso from Servicios where Nombre like '%{dato}%'";
            Open();
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                servicios.Add(Mapeador(lector));
            }
            Close();
            return servicios;
        }

        public List<Servicios> Consultar()
        {
            /*Id en la tabla servicios queda en 0, (debe desaparecer)*/
            List<Servicios> servicios = new List<Servicios>();
            var command = connection.CreateCommand();
            command.CommandText = "select Nombre,Valor,Duracion,Regreso from Servicios";
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
            /*servicio.Id borrado aquí*/
            servicio.Nombre = dataReader.GetString(0);
            servicio.Valor = dataReader.GetInt32(1);
            servicio.Duracion = dataReader.GetInt32(2);
            servicio.Regreso = dataReader.GetDateTime(3);

            return servicio;
        }
    }
}
