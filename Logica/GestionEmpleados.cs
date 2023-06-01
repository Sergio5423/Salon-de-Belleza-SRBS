using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionEmpleados : IOperaciones<Empleados>
    {
        RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();
        List<Empleados> listaEmpleados = null;

        public GestionEmpleados()
        {
            listaEmpleados = new List<Empleados>();
        }

        public void Actualizar(Empleados empleado)
        {
            repositorioEmpleados.Actualizar(empleado);
        }

        public void Agregar(Empleados empleado)
        {
            repositorioEmpleados.Agregar(empleado);
        }

        public void Borrar(int id)
        {
            repositorioEmpleados.Borrar(id);
        }

        public List<Empleados> Filtrar(string nombre)
        {
            return repositorioEmpleados.Filtrar(nombre);
        }

        public List<Empleados> Consultar()
        {
            return repositorioEmpleados.Consultar();
        }

        public int CalcularComision(int generado)
        {
            return generado / 2;
        }

        public Empleados ConsultarUno(int id)
        {
            foreach (var empleado in repositorioEmpleados.Consultar())
            {
                if (empleado.Id == id)
                {
                    return empleado;
                }
            }
            return null;
        }

        public void AgregarTrabajo(int id, int generado)
        {
            Empleados empleado = ConsultarUno(id);
            empleado.Generado = empleado.Generado + generado;
            empleado.Comision = empleado.Comision + CalcularComision(generado);
            repositorioEmpleados.AgregarTrabajo(empleado.Id,empleado.Generado,empleado.Comision);
        }
    }
}
