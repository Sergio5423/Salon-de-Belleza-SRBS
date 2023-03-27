using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionColor : ICliente<Color>
    {
        List<Color> listaColor = null;

        public GestionColor() 
        {
            listaColor = new List<Color>();
        }

        public void Agregar(Color cliente)
        {
            listaColor.Add(cliente);
        }

        public List<Color> Consultar()
        {
            return listaColor;
        }
    }
}
