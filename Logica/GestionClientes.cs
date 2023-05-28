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
    public class GestionClientes : IOperaciones<Clientes>
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

        public void Actualizar(Clientes cliente)
        {
            repositorioClientes.Actualizar(cliente);
        }

        public List<Clientes> Filtrar(string nombre)
        {
            return repositorioClientes.Filtrar(nombre);
        }

        public Clientes ConsultarUno(int id)
        {
            foreach (var cliente in repositorioClientes.Consultar())
            {
                if (cliente.Id == id)
                {
                    return cliente;
                }
            }
            return null;
        }

        public List<Clientes> ConsultarTodos()
        {
            return repositorioClientes.Consultar();
        }
    }
}
