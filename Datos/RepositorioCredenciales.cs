using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class RepositorioCredenciales : GestorConexion
    {
        public RepositorioCredenciales() : base()
        {
            
        }

        public void Agregar(Credenciales credencial)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into Credenciales (Usuario, Contraseña)" +
                " values (@Usuario,@Contraseña)";
                Command.Parameters.Add("Usuario", SqlDbType.VarChar).Value = credencial.Usuario;
                Command.Parameters.Add("Contraseña", SqlDbType.VarChar).Value = credencial.Contraseña;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Actualizar(Credenciales credencial)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Update Clientes Set Usuario = @Usuario, Contraseña = @Contraseña Where Id = @Id";
                Command.Parameters.Add("Usuario", SqlDbType.VarChar).Value = credencial.Usuario;
                Command.Parameters.Add("Contraseña", SqlDbType.VarChar).Value = credencial.Contraseña;
                
                Command.Parameters.Add("Id", SqlDbType.Int).Value = credencial.Id;                
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public List<Credenciales> Consultar()
        {
            List<Credenciales> credenciales = new List<Credenciales>();
            var command = connection.CreateCommand();
            command.CommandText = "select * from Credenciales";
            Open();
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                credenciales.Add(Mapeador(lector));
            }
            Close();
            return credenciales;
        }

        public Credenciales Mapeador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            Credenciales credencial = new Credenciales();
            credencial.Usuario = dataReader.GetString(1);
            credencial.Contraseña = dataReader.GetString(2);

            return credencial;
        }
    }
}
