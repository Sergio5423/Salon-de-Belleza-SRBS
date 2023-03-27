using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionAlisados : ICliente<Alisados>
    {
        List<Alisados> listaAlisados = null;

        public GestionAlisados()
        {
            listaAlisados = new List<Alisados>();
        }

        public void Agregar(Alisados cliente)
        {
            listaAlisados.Add(cliente);
        }

        public List<Alisados> Consultar() 
        {
            return listaAlisados;
        }
    }
}
