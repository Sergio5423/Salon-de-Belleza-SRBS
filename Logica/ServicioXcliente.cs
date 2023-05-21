using Entidades;
using Datos;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class ServicioXcliente
    {
        List<Servicios> listaFiltrada = null;
        List<Servicios> listaBuscada = null;
        List<Clientes> listaClientes = null;
        List<Servicios> listaServicios = null;
        
        Clientes clientes = new Clientes();

        public ServicioXcliente()
        {
            listaClientes = new List<Clientes>();
            listaServicios = new List<Servicios>();
            listaFiltrada = new List<Servicios>();
            listaBuscada = new List<Servicios>();
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

        public List<Servicios> BuscarServicio(string dato)
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

        public List<Servicios> FiltrarServicio(string dato)
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
