using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trabajos
    {
        public Trabajos()
        {
            
        }

        public Trabajos(string codigo,
                        int comision,
                        DateTime fecha,
                        string servicio_codigo,
                        string empleado_cedula)
        {
            Codigo = codigo;
            Comision = comision;
            Fecha = fecha;
            Servicio_Codigo = servicio_codigo;
            Empleado_Cedula = empleado_cedula;
        }

        public string Codigo { get; set; }
        public int Comision { get; set; }
        public DateTime Fecha { get; set; }    
        public string Servicio_Codigo { get; set; }
        public string Empleado_Cedula { get; set; }

        public override string ToString()
        {
            return $"{Codigo};{Comision};{Fecha};{Servicio_Codigo};{Empleado_Cedula}";
        }
    }
}
