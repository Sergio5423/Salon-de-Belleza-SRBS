using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PresentaciónIF
{
    public partial class ServiciosForm : Form
    {
        GestionServicios gestionServicios = new GestionServicios();
        Clientes clienteServicio = null;

        int idSeleccionado;

        public ServiciosForm()
        {
            InitializeComponent();
        }

        private void ServiciosForm_Load(object sender, EventArgs e)
        {
            gestionServicios.SetCliente(clienteServicio);
            PresentarCliente();
            LlenarGridView();
            Limpiar();
        }

        public void SetCliente(Clientes cliente)
        {
            clienteServicio = cliente;
        }

        public void PresentarCliente()
        {
            lbVinculo.Text = clienteServicio.Id.ToString();
            lbNombre.Text = clienteServicio.Nombre;
            lbTelefono.Text = clienteServicio.Telefono;
            lbCorreo.Text = clienteServicio.Correo;
        }

        public void PresentarServicio()
        {
            if (cbServicio.SelectedIndex == 0)
            {
                lbValor.Text = "0";
                lbDuracion.Text = "3 Meses";
                lbRegreso.Text = gestionServicios.CalcularRegresoMeses(3).ToShortDateString();
            }
            if (cbServicio.SelectedIndex == 1)
            {
                lbValor.Text = "0";
                lbDuracion.Text = "4 Meses";
                lbRegreso.Text = gestionServicios.CalcularRegresoMeses(4).ToShortDateString();
            }
            if (cbServicio.SelectedIndex == 2)
            {
                lbValor.Text = "0";
                lbDuracion.Text = "15 Dias";
                lbRegreso.Text = gestionServicios.CalcularRegresoDias(15).ToShortDateString();
            }
            if (cbServicio.SelectedIndex == 3)
            {
                lbValor.Text = "0";
                lbDuracion.Text = "20 Dias";
                lbRegreso.Text = gestionServicios.CalcularRegresoDias(20).ToShortDateString();
            }
        }

        public void CrearServicioAlisado(dynamic cliente)
        {           
            var servicio = new Servicios
            {
                Vinculo = cliente.Id,
                Nombre = cbServicio.SelectedItem.ToString(),
                Valor = 0,
                Duracion = 3,                    
            };

            gestionServicios.Agregar(servicio);                    
        }

        public void CrearServicioColor(dynamic cliente)
        {
            var servicio = new Servicios
            {
                Vinculo = cliente.Id,
                Nombre = cbServicio.SelectedItem.ToString(),
                Valor = 0,
                Duracion = 4,
            };

            gestionServicios.Agregar(servicio);            
        }

        public void CrearServicioMantenimiento(dynamic cliente)
        {        
                var servicio = new Servicios
                {
                    Vinculo = cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = 0,
                    Duracion = 15,
                };

            gestionServicios.Agregar(servicio);            
        }

        public void CrearServicioIrregular(dynamic cliente)
        {         
                var servicio = new Servicios
                {
                    Vinculo = cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = 0,
                    Duracion = 20,
                };

            gestionServicios.Agregar(servicio);            
        }

        public void LlenarGridView()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionServicios.Consultar(clienteServicio.Id);
            dgvServicios.DataSource = bin;
        }

        public void Filtrar()
        {        
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionServicios.Filtrar(cbBusqueda.Text,clienteServicio.Id);
            dgvServicios.DataSource = bin;
        }

        public void Limpiar()
        {
            cbServicio.SelectedIndex = -1;
            lbValor.Text = string.Empty;
            lbDuracion.Text = string.Empty;
            lbRegreso.Text = string.Empty;
        }

        public void Eliminar()
        {
            gestionServicios.Borrar(idSeleccionado);
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            gestionServicios.SetCliente(clienteServicio);
            if(cbServicio.SelectedIndex==0)
                CrearServicioAlisado(clienteServicio);
            if(cbServicio.SelectedIndex==1)
                CrearServicioColor(clienteServicio);
            if(cbServicio.SelectedIndex==2)
                CrearServicioMantenimiento(clienteServicio);
            if(cbServicio.SelectedIndex==3)
                CrearServicioIrregular(clienteServicio);
            LlenarGridView();
        }

        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            PresentarServicio();
        }

        private void btnEliminarServicios_Click(object sender, EventArgs e)
        {
            Eliminar();
            LlenarGridView();
        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = int.Parse(dgvServicios.Rows[e.RowIndex].Cells[0].Value.ToString());                        
        }
    }
}
