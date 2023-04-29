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

        public Clientes(int id,
                       string nombre, 
                       string telefono, 
                       string correo,
                       DateTime cumpleaños,
                       DateTime ultimaVisita)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Cumpleaños = cumpleaños;
            UltimaVisita = ultimaVisita;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime Cumpleaños { get; set; }
        public DateTime UltimaVisita { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{Correo};{Cumpleaños};{UltimaVisita}";
        }
    }
}
