using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class GestionServicios_Clientes
    {
        RepositorioServicios_Cliente repositorioServicios_Cliente = new RepositorioServicios_Cliente();

        public void Agregar(Clientes_Servicios clientes_Servicios)
        {
            repositorioServicios_Cliente.Agregar(clientes_Servicios);
        }

        public List<Clientes> ConsultarClientes(string ced)
        {
            return repositorioServicios_Cliente.ConsultarServicios_Cliente(ced);
        }

        public void BorrarCliente(string ced)
        {
            repositorioServicios_Cliente.BorrarCliente(ced);
        }

        public void BorrarServicio(string cod, string ced)
        {
            repositorioServicios_Cliente.BorrarServicios(cod, ced);
        }
    }
}
