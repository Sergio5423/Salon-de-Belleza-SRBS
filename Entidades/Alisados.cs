using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alisados : Categoria
    {
        public int tiempoRegreso = 3;

        public Alisados()
        {
        }
        public Alisados(string categori,
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
            DateTime regreso = ultimaVisita.AddMonths(tiempoRegreso);
            return regreso;
        }

        public override string ToString()
        {
            return $"{Categori};{Nombre};{Telefono};{Correo};{UltimaVisita};{Cumpleaños}";
        }
    }
}
