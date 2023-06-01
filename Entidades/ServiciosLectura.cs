using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ServiciosLectura
    {
        public ServiciosLectura()
        {

        }

        public ServiciosLectura(string id, string nombre, string valor, string duracion, string regreso)
        {
            Id = id;            
            Nombre = nombre;
            Valor = valor;
            Duracion = duracion;
            Regreso = regreso;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public string Duracion { get; set; }
        public string Regreso { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Valor};{Duracion}";
        }
    }
}
