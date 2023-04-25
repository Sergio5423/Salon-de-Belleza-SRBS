using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logica
{
    public class GestionListasDto
    {
        List<CategoriaDto> listaGrid = null;
        GestionAlisados gestionAlisados;        

        public GestionListasDto()
        {
            listaGrid = new List<CategoriaDto>();
            //listaGrid.AddRange();
        }

        public List<CategoriaDto> Consultar()
        {
            return listaGrid;
        }
    }
}
