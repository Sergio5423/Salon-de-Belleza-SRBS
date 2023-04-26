using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionIrregulares : ICliente<Irregulares>
    {
        public List<Irregulares> listaIrregulares = null;
        public GestionIrregulares()
        {
            listaIrregulares = new List<Irregulares>();
        }

        public void Agregar(Irregulares cliente)
        {
            listaIrregulares.Add(cliente);
        }

        public List<Irregulares> Consultar()
        {
            if (listaIrregulares.Count == 0)
            {
                return null;
            }
            else
            {
                return listaIrregulares;
            }
        }

        public Irregulares Buscar(string dato)
        {
            foreach (var item in Consultar())
            {
                if (item.Categori == dato)
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
            listaIrregulares.Remove(Cliente);
        }                
    }
}
