using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class ServicioXcliente
    {
        List<Clientes> listaClientes = null;
        List<Servicios> listaServicios = null;

        Servicios servicios = new Servicios();
        Clientes clientes = new Clientes();

        public ServicioXcliente()
        {
            listaClientes = new List<Clientes>();
            listaServicios = new List<Servicios>();
        }

        public void AgregarCliente(Clientes cliente)
        {
            listaClientes.Add(cliente);
        }

        public void AgregarServicio(Servicios servicios)
        {
            listaServicios.Add(servicios);
        }

        public List<Clientes> ConsultarClientes()
        {
            return listaClientes;
        }

        public List<Servicios> ConsultarServicios()
        {
            if (listaServicios.Count == 0)
            {
                return null;
            }
            else
            {
                return listaServicios;
            }
        }

        public Clientes BuscarCliente(string dato)
        {

            foreach (var item in ConsultarClientes())
            {
                try
                {
                    if (item.Id == int.Parse(dato))
                    {
                        return item;
                    }
                }
                catch (Exception ex)
                {
                    
                }

                if (item.Nombre == dato)
                {
                    return item;
                }
                else
                {
                    if (item.Telefono == dato)
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
            return null;
        }

    //public DataTable ConvertirListaClientesAdataTable(List<Clientes> lista)
    //{
    //    DataTable table = new DataTable();

    //    int columns = 0;
    //    foreach (var item in lista)
    //    {
    //        if (lista.Count > columns)
    //        {
    //            columns = lista.Count;
    //        }
    //    }

    //    for (int i = 0; i < columns; i++)
    //    {
    //        table.Columns.Add();
    //    }

    //    foreach (var item2 in lista)
    //    {
    //        table.Rows.Add(item2);
    //    }                            
    //    return table;
    //}

    public Servicios BuscarServicio(string dato)
    {
        foreach (var item in ConsultarServicios())
        {
            if (item.Id == int.Parse(dato))
            {
                return item;
            }
            else
            {
                if (item.Nombre == dato)
                {
                    return item;
                }
            }
        }
        return null;
    }

    public void BorrarCliente(string dato)
    {
        var Cliente = BuscarCliente(dato);
        listaClientes.Remove(Cliente);
    }

    public void BorrarServicio(string dato)
    {
        var Cliente = BuscarServicio(dato);
        listaServicios.Remove(Cliente);
    }

    public DateTime FechaRegresoDias(int duracion)
    {
        DateTime regreso = clientes.UltimaVisita.AddDays(duracion);
        return regreso;
    }

    public DateTime FechaRegresoMeses(int duracion)
    {
        DateTime regreso = clientes.UltimaVisita.AddMonths(duracion);
        return regreso;
    }

    public int UltimoIdClientes()
    {
        int Id;
        Id = ConsultarClientes().Count;
        Id++;
        return Id;
    }
}
}
