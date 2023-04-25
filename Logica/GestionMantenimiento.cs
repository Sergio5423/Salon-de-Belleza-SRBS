using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionMantenimiento : ICliente<Mantenimiento>
    {
        List<Mantenimiento> listaMantenimiento = null;
        public GestionMantenimiento()
        {
            listaMantenimiento = new List<Mantenimiento>();
        }

        public void Agregar(Mantenimiento cliente)
        {
            listaMantenimiento.Add(cliente);
        }

        public List<Mantenimiento> Consultar()
        {
            if (listaMantenimiento.Count == 0)
            {
                return null;
            }
            else
            {
                return listaMantenimiento;
            }
        }

        public Mantenimiento Buscar(string dato)
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
            listaMantenimiento.Remove(Cliente);
        }                
    }
}
