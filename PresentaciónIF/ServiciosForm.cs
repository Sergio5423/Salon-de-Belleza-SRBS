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
using System.Windows.Forms;

namespace PresentaciónIF
{
    public partial class ServiciosForm : Form
    {
        GestionServicios gestionServicios = new GestionServicios();
        Clientes clienteServicio = null;

        public ServiciosForm()
        {
            InitializeComponent();
        }

        private void ServiciosForm_Load(object sender, EventArgs e)
        {            
            Presentar();
            LlenarGridView();
            Limpiar();
        }

        public void SetCliente(Clientes cliente)
        {
            clienteServicio = cliente;
        }

        public void Presentar()
        {
            lbIdServicio.Text = clienteServicio.Id.ToString();
            lbNombre.Text = clienteServicio.Nombre;
            lbTelefono.Text = clienteServicio.Telefono;
            lbCorreo.Text = clienteServicio.Correo;
        }

        public void CrearServicioAlisado(dynamic Cliente)
        {
            if (cbServicio.SelectedIndex == 0)
            {
                var Servicio = new Servicios
                {
                    Id = Cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = 0,
                    Duracion = 3,
                };

                lbValor.Text = $"${Servicio.Valor}";

                Servicio.Regreso = Cliente.UltimaVisita.AddMonths(Servicio.Duracion);
                lbRegreso.Text = Servicio.Regreso.ToString();
                gestionServicios.Agregar(Servicio);
            }
        }

        public void CrearServicioColor(dynamic Cliente)
        {
            if (cbServicio.SelectedIndex == 1)
            {
                var Servicio = new Servicios
                {
                    Id = Cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = 0,
                    Duracion = 4,
                };
                lbValor.Text = $"${Servicio.Valor}";

                Servicio.Regreso = Cliente.UltimaVisita.AddMonths(Servicio.Duracion);
                lbRegreso.Text = Servicio.Regreso.ToString();
                gestionServicios.Agregar(Servicio);
            }
        }

        public void CrearServicioMantenimiento(dynamic Cliente)
        {
            if (cbServicio.SelectedIndex == 2)
            {
                var Servicio = new Servicios
                {
                    Id = Cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = 0,
                    Duracion = 15,
                };
                lbValor.Text = $"${Servicio.Valor}";

                Servicio.Regreso = Cliente.UltimaVisita.AddMonths(Servicio.Duracion);
                lbRegreso.Text = Servicio.Regreso.ToString();
                gestionServicios.Agregar(Servicio);
            }
        }

        public void CrearServicioIrregular(dynamic Cliente)
        {
            if (cbServicio.SelectedIndex == 3)
            {
                var Servicio = new Servicios
                {
                    Id = Cliente.Id,
                    Nombre = cbServicio.SelectedItem.ToString(),
                    Valor = 0,
                    Duracion = 20,
                };
                lbValor.Text = $"{Servicio.Valor}";

                Servicio.Regreso = Cliente.UltimaVisita.AddMonths(Servicio.Duracion);
                lbRegreso.Text = Servicio.Regreso.ToString();
                gestionServicios.Agregar(Servicio);
            }
        }

        public void LlenarGridView()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionServicios.Consultar();
            dgvServicios.DataSource = bin;
        }

        public void Filtrar()
        {        
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionServicios.Filtrar(cbBusqueda.Text);
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
            gestionServicios.Borrar(dgvServicios.CurrentRow.Index);
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            CrearServicioAlisado(clienteServicio);
            CrearServicioColor(clienteServicio);
            CrearServicioMantenimiento(clienteServicio);
            CrearServicioIrregular(clienteServicio);
            LlenarGridView();
        }

        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServicio.SelectedIndex == 0)
            {
                lbDuracion.Text = "3 Meses";
            }
            if (cbServicio.SelectedIndex == 1)
            {
                lbDuracion.Text = "4 Meses";
            }
            if (cbServicio.SelectedIndex == 2)
            {
                lbDuracion.Text = "15 Dias";
            }
            if (cbServicio.SelectedIndex == 3)
            {
                lbDuracion.Text = "20 Dias";
            }
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
    }
}
