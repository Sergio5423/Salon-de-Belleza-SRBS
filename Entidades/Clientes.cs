using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public Clientes()
        {
            
        }

        public Clientes(string cedula,
                       string nombre, 
                       string telefono, 
                       string correo,
                       DateTime cumpleaños,
                       DateTime ultimaVisita,
                       string empleado_cedula)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Cumpleaños = cumpleaños;
            UltimaVisita = ultimaVisita;
            Empleado_Cedula = empleado_cedula;
        }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime Cumpleaños { get; set; }
        public DateTime UltimaVisita { get; set; }
        public string Empleado_Cedula { get; set; }

        public override string ToString()
        {
            return $"{Cedula};{Nombre};{Telefono};{Correo};{Cumpleaños};{UltimaVisita};{Empleado_Cedula}";
        }
    }
}
