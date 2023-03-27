using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Irregulares : Categoria
    {
        public Irregulares()
        {
        }
        public Irregulares(int id, string nombre, long telefono, string correo, DateTime ultimaVisita, DateTime cumpleaños) : base(id, nombre, telefono, correo, ultimaVisita, cumpleaños)
        {

        }
        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{Correo};{UltimaVisita};{Cumpleaños}";
        }
    }
}
