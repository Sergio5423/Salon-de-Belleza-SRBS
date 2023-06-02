using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionCredenciales
    {
        RepositorioCredenciales repositorioCredenciales = new RepositorioCredenciales();

        public void Agregar(Credenciales credencial)
        {
            repositorioCredenciales.Agregar(credencial);
        }

        public void Actualizar(Credenciales credencial)
        {
            repositorioCredenciales.Actualizar(credencial);
        }

        public bool Validar(string usuario, string contraseña)
        {
            foreach (Credenciales credencial in Consultar())
            {
                if ((credencial.Usuario + credencial.Contraseña) == (usuario + contraseña))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Credenciales> Consultar()
        {
            return repositorioCredenciales.Consultar();
        }
    }
}
