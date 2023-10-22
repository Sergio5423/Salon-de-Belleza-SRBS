using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        public Empleados()
        {
            
        }

        public Empleados(string cedula,                           
                         string nombre, 
                         string telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
        }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"{Cedula};{Nombre};{Telefono}";
        }
    }
}
