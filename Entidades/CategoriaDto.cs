using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriaDto
    {
        public CategoriaDto()
        {
            
        }

        public CategoriaDto(string categoria,
                            string nombre,
                            string telefono,
                            string correo,
                            string ultimaVisita,
                            string cumpleaños)
        {
            Categoria = categoria;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            UltimaVisita = ultimaVisita;
            Cumpleaños = cumpleaños;
        }

        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string UltimaVisita { get; set; }
        public string Cumpleaños { get; set; }
    }
}
