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

        public Empleados(int id, 
                         string ced, 
                         string nombre, 
                         int generado, 
                         int comision)
        {
            Id = id;
            Ced = ced;
            Nombre = nombre;
            Generado = generado;
            Comision = comision;
        }

        public int Id { get; set; }
        public string Ced { get; set; }
        public string Nombre { get; set; }
        public int Generado { get; set; }
        public int Comision { get; set; }
    }
}
