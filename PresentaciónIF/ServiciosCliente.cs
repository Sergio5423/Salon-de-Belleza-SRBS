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
using System.Diagnostics;
using System.Windows.Forms;

namespace PresentaciónIF
{
    public partial class ServiciosCliente : Form
    {
        GestionServicios gestionServicios = new GestionServicios();
        Entidades.Clientes clienteServicio = null;
        int precAlis = 200000;
        int precDis = 300000;
        int precQuim = 70000;
        int precRes = 80000;
        int precBlow = 30000;

        int idSeleccionado;

        public ServiciosCliente()
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

        public void SetCliente(Entidades.Clientes cliente)
        {
            clienteServicio = cliente;
        }

        public void PresentarCliente()
        {
            lbVinculo.Text = clienteServicio.Id.ToString();
            lbNombre.Text = clienteServicio.Nombre;
            lbTelefono.Text = clienteServicio.Telefono;
            lbCorreo.Text = clienteServicio.Correo;
            lbFavorito.Text = clienteServicio.EstilistaFavorito;
        }

        public void PresentarServicio()
        {
            if (cbServicio.SelectedIndex == 0)
            {
                lbValor.Text = $"${precAlis}";
                lbDuracion.Text = "3 Meses";
                lbRegreso.Text = gestionServicios.CalcularRegresoMeses(3).ToShortDateString();
            }
            if (cbServicio.SelectedIndex == 1)
            {
                lbValor.Text = $"${precDis}";
                lbDuracion.Text = "4 Meses";
                lbRegreso.Text = gestionServicios.CalcularRegresoMeses(4).ToShortDateString();
            }
            if (cbServicio.SelectedIndex == 2)
            {
                lbValor.Text = $"${precQuim}";
                lbDuracion.Text = "15 Dias";
                lbRegreso.Text = gestionServicios.CalcularRegresoDias(15).ToShortDateString();
            }
            if (cbServicio.SelectedIndex == 3)
            {
                lbValor.Text = $"${precRes}";
                lbDuracion.Text = "15 Dias";
                lbRegreso.Text = gestionServicios.CalcularRegresoDias(15).ToShortDateString();
            }
            if (cbServicio.SelectedIndex == 4)
            {
                lbValor.Text = $"${precBlow}";
                lbDuracion.Text = "8 Dias";
                lbRegreso.Text = gestionServicios.CalcularRegresoDias(8).ToShortDateString();
            }
        }

        public void CrearServicioAlisado(dynamic cliente)
        {           
            var servicio = new ServiciosEscritura   
            {
                Vinculo = cliente.Id,
                Nombre = cbServicio.SelectedItem.ToString(),
                Valor = precAlis,
                Duracion = 3,                    
            };

            gestionServicios.Agregar(servicio);                    
        }

        public void CrearServicioDisColor(dynamic cliente)
        {
            var servicio = new ServiciosEscritura
            {
                Vinculo = cliente.Id,
                Nombre = cbServicio.SelectedItem.ToString(),
                Valor = precDis,
                Duracion = 4,
            };

            gestionServicios.Agregar(servicio);            
        }

        public void CrearServicioMantQuimicos(dynamic cliente)
        {        
                var servicio = new ServiciosEscritura
                {
                    Vinculo = cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = precQuim,
                    Duracion = 15,
                };

            gestionServicios.Agregar(servicio);            
        }

        public void CrearServicioRestauracion(dynamic cliente)
        {         
                var servicio = new ServiciosEscritura
                {
                    Vinculo = cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = precRes,
                    Duracion = 15,
                };

            gestionServicios.Agregar(servicio);            
        }

        public void CrearServicioBlower(dynamic cliente)
        {
            var servicio = new ServiciosEscritura
            {
                Vinculo = cliente.Id,
                Nombre = cbServicio.SelectedItem.ToString(),
                Valor = precBlow,
                Duracion = 8,
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
            cbBusqueda.SelectedIndex = -1;
        }

        public void Eliminar()
        {
            gestionServicios.Borrar(idSeleccionado);
        }

        public void GenerarPDF(string nombreCliente)
        {
            gestionServicios.CrearPdfEmpleados(nombreCliente,$"Servicios {nombreCliente}");
            Process.Start($"Servicios {nombreCliente}.pdf");
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            gestionServicios.SetCliente(clienteServicio);
            if (cbServicio.SelectedIndex == 0)
                CrearServicioAlisado(clienteServicio);
            if (cbServicio.SelectedIndex == 1)
                CrearServicioDisColor(clienteServicio);
            if (cbServicio.SelectedIndex == 2)
                CrearServicioMantQuimicos(clienteServicio);
            if (cbServicio.SelectedIndex == 3)
                CrearServicioRestauracion(clienteServicio);
            if (cbServicio.SelectedIndex == 4)
                CrearServicioBlower(clienteServicio);
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
            try
            {
                idSeleccionado = int.Parse(dgvServicios.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbBusqueda.SelectedIndex = -1;
            LlenarGridView();
        }

        private void btnPdfS_Click(object sender, EventArgs e)
        {
            GenerarPDF(clienteServicio.Nombre);
        }

        private void btnSalirS_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }
    }
}
