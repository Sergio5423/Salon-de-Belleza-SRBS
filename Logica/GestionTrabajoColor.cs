using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionTrabajoColor : ICliente<TrabajoColor>
    {
        List<TrabajoColor> listaColor = null;

        public GestionTrabajoColor() 
        {
            listaColor = new List<TrabajoColor>();
        }

        public void Agregar(TrabajoColor cliente)
        {
            listaColor.Add(cliente);
        }
        public List<TrabajoColor> Consultar()
        {
            if (listaColor.Count == 0)
            {
                return null;
            }
            else
            {
                return listaColor;
            }
        }

        public TrabajoColor Buscar(string dato)
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
            listaColor.Remove(Cliente);
        }              
    }
}
