using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class GestionClientes
    {        
        RepositorioClientes repositorioClientes = new RepositorioClientes();
        List<Clientes> listaClientes = null;

        public GestionClientes()
        {
            listaClientes = new List<Clientes>();
        }

        public void Agregar(Clientes cliente)
        {
            repositorioClientes.Agregar(cliente);
        }

        public void Borrar(int id)
        {
            repositorioClientes.Borrar(id);
        }

        public List<Clientes> Filtrar(string dato)
        {
            return repositorioClientes.Filtrar(dato);
        }

        public List<Clientes> Consultar()
        {
            return listaClientes = repositorioClientes.Consultar();
        }
    }
}
