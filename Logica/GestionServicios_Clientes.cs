using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosOracle;
using Entidades;

namespace Logica
{
    public class GestionServicios_Clientes
    {
        RepositorioClientesServicios repositorioClientesServicios = new RepositorioClientesServicios();
        string cl_nombre;

        public void Agregar(Clientes_Servicios clientes_Servicios)
        {
            repositorioClientesServicios.Agregar(clientes_Servicios);
        }

        /*Retorna los servicios del cliente*/
        public List<Servicios> ConsultarServicios(string ced)
        {
            return repositorioClientesServicios.Consultar(ced);
        }

        public void BorrarCliente(string ced)
        {
            repositorioClientesServicios.BorrarCliente(ced);
        }

        public void BorrarServicio(string cod, string ced)
        {
            repositorioClientesServicios.BorrarServicio(cod, ced);
        }
    }
}
