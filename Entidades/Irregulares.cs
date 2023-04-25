using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Irregulares : Categoria
    {
        public int tiempoRegreso = 20;

        public Irregulares()
        {
        }
        public Irregulares(string categori,
                           string nombre,
                           long telefono,
                           string correo,
                           DateTime ultimaVisita,
                           DateTime cumpleaños) : base(categori,
                                                       nombre,
                                                       telefono,
                                                       correo,
                                                       ultimaVisita,
                                                       cumpleaños)
        {
            
        }        

        public override DateTime Regreso(DateTime ultimaVisita)
        {
            DateTime regreso = ultimaVisita.AddDays(tiempoRegreso);
            return regreso;
        }

        public override string ToString()
        {
            return $"{Categori};{Nombre};{Telefono};{Correo};{UltimaVisita};{Cumpleaños}";
        }
    }
}
