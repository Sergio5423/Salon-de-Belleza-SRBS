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
        ServiciosForm serviciosForm;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            confirmacion = new Confirmacion();
            serviciosForm = new ServiciosForm();
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

        public void Limpiar()
        {
            tbNombre.Text = string.Empty;
            tbCorreo.Text = string.Empty;
            tbTelefono.Text = string.Empty;            
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

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            var cliente = servicioXcliente.ConsultarClientes()[i];
            serviciosForm.SetCliente(cliente);
            serviciosForm.ShowDialog();
        }

        private void tbBuscarClientes_TextChanged_1(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}