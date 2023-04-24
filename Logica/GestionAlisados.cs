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

        public Alisados Buscar(string dato)
        {
            foreach (var item in Consultar())
            {
                if (item.Id.ToString() == dato)
                {
                    return item;
                }
                else
                {
                    if (item.Nombre == dato)
                    {
                        return item;
                    }
                    else
                    {
                        if (item.Telefono.ToString() == dato)
                        {
                            return item;
                        }
                        else
                        {
                            if (item.Correo == dato)
                            {
                                return item;
                            }
                        }
                    }
                }
            }
            return null;
        }

        public void Borrar(string dato)
        {
            var Cliente = Buscar(dato);
            listaAlisados.Remove(Cliente);
        }                
    }
}
