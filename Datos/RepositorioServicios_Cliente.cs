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
    public class RepositorioServicios_Cliente : GestorConexion
    {
        public RepositorioServicios_Cliente() : base()
        {
                    
        }

        public void Agregar(Clientes_Servicios clientes_servicios)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Clientes_Servicios (Cedula_Cliente,Codigo_Servicio)" +
                " values (@Cedula_Cliente,@Codigo_Servicio)";
                Command.Parameters.Add("Cedula_Cliente", SqlDbType.VarChar).Value = clientes_servicios.Cedula_Cliente;
                Command.Parameters.Add("Codigo_Servicio", SqlDbType.VarChar).Value = clientes_servicios.Codigo_Servicio;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        //public void Borrar(string cedula)
        //{
        //    //BorrarServiciosVinculados(id);
        //    using (var Command = connection.CreateCommand())
        //    {
        //        Command.CommandText = $"Delete Clientes where Cedula = '{cedula}'";
        //        Open();
        //        Command.ExecuteNonQuery();
        //        Close();
        //    }            
        //}

        public void Actualizar(string cedAntigua, string cedNueva)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Update Clientes_Servicios Set " +
                                      "Cedula_Cliente = @Cedula_Cliente," +
                                      "Where Cedula_Cliente = @Ced";
                Command.Parameters.Add("Cedula_Cliente", SqlDbType.VarChar).Value = cedNueva;
                Command.Parameters.Add("Ced", SqlDbType.VarChar).Value = cedAntigua;               
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void BorrarCliente(string cedula)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Clientes_Servicios" +
                                      $" where Cedula_Cliente = {cedula}";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void BorrarServicios(string cod, string ced)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete Clientes_Servicios" +
                                      $" where Cedula_Cliente = '{ced}'" +
                                      $"and Codigo_Servicio = '{cod}'";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        //public List<Clientes> Filtrar(string nombre)
        //{
        //    List<Clientes> clientes = new List<Clientes>();
        //    var command = connection.CreateCommand();
        //    command.CommandText = $"select * from Clientes where Nombre like '%{nombre}%'";
        //    Open();
        //    SqlDataReader lector = command.ExecuteReader();
        //    while (lector.Read())
        //    {
        //        clientes.Add(Mapeador(lector));
        //    }
        //    Close();
        //    return clientes;
        //}

        public List<Clientes> ConsultarServicios_Cliente(string cedula)
        {
            List<Clientes> clientes = new List<Clientes>();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT Nombre,Duracion,Valor " +
                                  "FROM Clientes c INNER JOIN Clientes_Servicios cs " +
                                  "ON c.Cedula = cs.Cedula_Cliente INNER JOIN " +
                                  "Servicios s ON s.Codigo=cs.Codigo_Servicio " +
                                  $"WHERE cs.Cedula_Cliente='{cedula}'";
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

