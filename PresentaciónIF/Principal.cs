using Entidades;
using Logica;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PresentaciónIF
{
    public partial class Principal : Form
    {
        ServicioXcliente servicioXcliente = new ServicioXcliente();
        Confirmacion confirmacion;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            confirmacion = new Confirmacion();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Capturar();
            Limpiar();
            LlenarGridView();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Limpiar();
            LlenarGridView();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Actualizar();
            Limpiar();
            LlenarGridView();
        }

        public void Limpiar()
        {
            tbNombre.Text = string.Empty;
            tbCorreo.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            cbServicio.SelectedIndex = -1;
            dtUltimaVisita.Value = DateTime.Now;
            dtFechaCumpleaños.Value = DateTime.Now;
            tbNombre.Focus();
        }

        public void Capturar()
        {
            if ((tbNombre.Text == string.Empty) ||
                (tbTelefono.Text == string.Empty) ||
                (tbCorreo.Text == string.Empty))
            {

            }
            else
            {
                CrearCliente();
            }
        }

        public void CrearCliente()
        {
            var Cliente = new Clientes
            {
                Id = servicioXcliente.UltimoIdClientes(),
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                Correo = tbCorreo.Text,
                UltimaVisita = dtUltimaVisita.Value,
                Cumpleaños = dtFechaCumpleaños.Value
            };

            servicioXcliente.AgregarCliente(Cliente);

            Confirmacion(Cliente);
            confirmacion.ShowDialog();

        }        

        public void Confirmacion(dynamic cliente)
        {
            confirmacion.SetNombre(cliente.Nombre);
            confirmacion.SetTelefono(cliente.Telefono.ToString());
            confirmacion.SetCorreo(cliente.Correo);
            confirmacion.SetUltimaVisita(cliente.UltimaVisita.ToString());
            confirmacion.SetCumpleaños(cliente.Cumpleaños.ToString());
        }

        public void LlenarGridView()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = servicioXcliente.ConsultarClientes();
            dgvClientes.DataSource = bin;
        }

        public void Eliminar()
        {
            if (lbId.Text == String.Empty)
            {

            } else
            {
                servicioXcliente.BorrarCliente(lbId.Text);
            }
        }

        public void Actualizar()
        {
            if (lbId.Text == String.Empty)
            {

            } else
            {
                var ClienteA = new Clientes
                {
                    Id = int.Parse(lbId.Text),
                    Nombre = tbNombre.Text,
                    Telefono = tbTelefono.Text,
                    Correo = tbCorreo.Text,
                    UltimaVisita = dtUltimaVisita.Value,
                    Cumpleaños = dtFechaCumpleaños.Value
                };

                servicioXcliente.AgregarCliente(ClienteA);

                Confirmacion(ClienteA);
                confirmacion.ShowDialog();
            }
        }

        public void Filtrar()
        {
            var cliente = servicioXcliente.BuscarCliente(tbBuscarClientes.Text);
            if (tbBuscarClientes.Text == string.Empty)
            {
                cliente = null;
            }

            if (cliente == null)
            {
                LlenarGridView();
            }
            else
            {
                BindingSource bin = new BindingSource();
                bin.DataSource = cliente;
                dgvClientes.DataSource = bin;
            }
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
                Servicio.Regreso = servicioXcliente.FechaRegresoMeses(Servicio.Duracion);
                servicioXcliente.AgregarServicio(Servicio);
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

                Servicio.Regreso = servicioXcliente.FechaRegresoMeses(Servicio.Duracion);
                servicioXcliente.AgregarServicio(Servicio);
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

                Servicio.Regreso = servicioXcliente.FechaRegresoDias(Servicio.Duracion);
                servicioXcliente.AgregarServicio(Servicio);
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

                Servicio.Regreso = servicioXcliente.FechaRegresoDias(Servicio.Duracion);
                servicioXcliente.AgregarServicio(Servicio);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            var Cliente = servicioXcliente.ConsultarClientes()[i];
            lbId.Text = Cliente.Id.ToString();
            tbNombre.Text = Cliente.Nombre;
            tbTelefono.Text = Cliente.Telefono;
            tbCorreo.Text = Cliente.Correo;
            dtFechaCumpleaños.Value = Cliente.Cumpleaños;
            dtUltimaVisita.Value = Cliente.UltimaVisita;
        }

        private void tbBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void tbBuscarClientes_ControlRemoved(object sender, ControlEventArgs e)
        {
            LlenarGridView();
        }
        
    }
}