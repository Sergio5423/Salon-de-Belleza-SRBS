using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data.SqlClient;

namespace Logica
{
    public class GestionServicios
    {        
        RepositorioServicios repositorioServicios = new RepositorioServicios();
        List<Servicios> listaServicios = null;

        public GestionServicios()
        {
            listaServicios = new List<Servicios>();
        }

        public void Agregar(Servicios servicio)
        {
            repositorioServicios.Agregar(servicio);
        }

        public void Borrar(int id)
        {
            repositorioServicios.Borrar(id);
        }

        public List<Servicios> Filtrar(string dato)
        {            
            return repositorioServicios.Filtrar(dato);
        }

        public List<Servicios> Consultar()
        {
            return listaServicios = repositorioServicios.Consultar();
        }
    }
}
