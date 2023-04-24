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
        List<Irregulares> listaIrregulares = null;

        public void Agregar(Irregulares cliente)
        {
            listaIrregulares = new List<Irregulares>();
        }

        public List<Irregulares> Consultar()
        {
            return listaIrregulares;
        }

        public Irregulares Buscar(string dato)
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
            listaIrregulares.Remove(Cliente);
        }                
    }
}
