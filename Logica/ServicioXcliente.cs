using Entidades;
using Datos;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class ServicioXcliente
    {
        List<ServiciosEscritura> listaFiltrada = null;
        List<ServiciosEscritura> listaBuscada = null;
        List<Clientes> listaClientes = null;
        List<ServiciosEscritura> listaServicios = null;
        
        Clientes clientes = new Clientes();

        public ServicioXcliente()
        {
            listaClientes = new List<Clientes>();
            listaServicios = new List<ServiciosEscritura>();
            listaFiltrada = new List<ServiciosEscritura>();
            listaBuscada = new List<ServiciosEscritura>();
        }

        public void AgregarCliente(Clientes cliente)
        {
            listaClientes.Add(cliente);
        }

        public void AgregarServicio(ServiciosEscritura servicios)
        {
            listaServicios.Add(servicios);
        }

        public List<Clientes> ConsultarClientes()
        {
            return listaClientes;
        }

        public List<ServiciosEscritura> ConsultarServicios()
        {
            return listaServicios;
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
                catch (Exception)
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

        public List<ServiciosEscritura> BuscarServicio(string dato)
        {
            
            foreach (var item in ConsultarServicios())
            {
                try
                {
                    if (item.Nombre == dato)
                    {
                        listaBuscada.Add(item);
                    }
                }
                catch (Exception)
                {

                }
            }
            return listaBuscada;
        }

        public List<ServiciosEscritura> FiltrarServicio(string dato)
        {
            foreach (var item in ConsultarServicios())
            {
                try
                {
                    if (item.Id == int.Parse(dato))
                    {
                        listaFiltrada.Add(item);
                    }
                }
                catch (Exception)
                {

                }
            }
            return listaFiltrada;
        }

        public void BorrarCliente(string dato)
        {
            var Cliente = BuscarCliente(dato);
            listaClientes.Remove(Cliente);
        }

        public void BorrarServicio(int i)
        {
            var servicio = listaServicios[i];
            listaServicios.Remove(servicio);
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
