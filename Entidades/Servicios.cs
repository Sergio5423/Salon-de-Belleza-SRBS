using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicios
    {

        public Servicios()
        {

        }

        public Servicios(string codigo,
                         string nombre,
                         int duracion,
                         int valor)
        {
            Codigo = codigo;
            Nombre = nombre;
            Duracion = duracion;
            Valor = valor;
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public int Valor { get; set; }

        public override string ToString()
        {
            return $"{Codigo};{Nombre};{Duracion};{Valor}";
        }
    }
}
