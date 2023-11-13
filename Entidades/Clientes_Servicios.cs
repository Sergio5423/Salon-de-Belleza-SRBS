using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes_Servicios
    {
        public Clientes_Servicios()
        {
            
        }

        public Clientes_Servicios(string cedula_cliente,
                                  string codigo_servicio,
                                  string empleado_cedula)
        {
            Cedula_Cliente = cedula_cliente;
            Codigo_Servicio = codigo_servicio;
            Empleado_Cedula = empleado_cedula;
        }

        public string Cedula_Cliente { get; set; }
        public string Codigo_Servicio { get; set; }
        public string Empleado_Cedula { get; set; }

        public override string ToString()
        {
            return $"{Cedula_Cliente};{Codigo_Servicio};{Empleado_Cedula}";
        }
    }
}
