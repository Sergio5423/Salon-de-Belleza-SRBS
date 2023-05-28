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
    public class GestionServicios : IOperaciones<Servicios>
    {        
        RepositorioServicios repositorioServicios = new RepositorioServicios();
        List<Servicios> listaServicios;
        Clientes clienteServicio;

        public GestionServicios()
        {
            listaServicios = new List<Servicios>();
            clienteServicio = new Clientes();
        }

        public void SetCliente(Clientes cliente)
        {
            clienteServicio = cliente;
        }

        public void Agregar(Servicios servicio)
        {
            if (servicio.Nombre == "Alisado Profesional")
                servicio.Regreso = CalcularRegresoMeses(servicio.Duracion);
            if (servicio.Nombre == "Trabajo de Color")
                servicio.Regreso = CalcularRegresoMeses(servicio.Duracion);
            if (servicio.Nombre == "Mantenimiento de Químicos")
                servicio.Regreso = CalcularRegresoDias(servicio.Duracion);
            if (servicio.Nombre == "Cliente Irregular")
                servicio.Regreso = CalcularRegresoDias(servicio.Duracion);
            repositorioServicios.Agregar(servicio);
        }

        public DateTime CalcularRegresoMeses(int Duracion)
        {            
            DateTime Regreso = clienteServicio.UltimaVisita.AddMonths(Duracion);            
            return Regreso;
        }

        public DateTime CalcularRegresoDias(int Duracion)
        {
            DateTime Regreso = clienteServicio.UltimaVisita.AddDays(Duracion);
            return Regreso;
        }

        public void Borrar(int id)
        {
            repositorioServicios.Borrar(id);
        }

        public void Actualizar(Servicios servicio)
        {
            repositorioServicios.Actualizar(servicio);
        }

        public List<Servicios> Filtrar(string nombre, int vinculo)
        {            
            return repositorioServicios.Filtrar(nombre,vinculo);
        }

        public List<Servicios> Consultar(int vinculo)
        {
            return listaServicios = repositorioServicios.Consultar(vinculo);
        }
    }
}
