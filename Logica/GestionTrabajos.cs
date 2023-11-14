using DatosOracle;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionTrabajos
    {
        RepositorioTrabajos repositorioTrabajos = new RepositorioTrabajos();

        //public void Agregar(Trabajos trabajo)
        //{
        //    repositorioTrabajos.(trabajo);
        //}

        public void Borrar(string codigo)
        {
            repositorioTrabajos.Borrar(codigo);
        }

        public List<Trabajos> Consultar()
        {
            return repositorioTrabajos.Consultar();
        }

        public List<Trabajos> ConsultarPorEmpleado(string ced)
        {
            return repositorioTrabajos.ConsultarPorEmpleado(ced);
        }
    }
}
