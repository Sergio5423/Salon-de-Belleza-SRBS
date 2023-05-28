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
        GestionClientes gestionClientes = new GestionClientes();
        GestionServicios gestionServicios = new GestionServicios();
        Confirmacion confirmacion;
        ServiciosForm serviciosForm;
        int idCliente;
        int posicion;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            confirmacion = new Confirmacion();
            serviciosForm = new ServiciosForm();
            LlenarGridView();
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
            gestionClientes.Actualizar(CrearClienteActualizado());
            Limpiar();
            LlenarGridView();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            serviciosForm.SetCliente(gestionClientes.ConsultarUno(idCliente));
            serviciosForm.ShowDialog();
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
                Clientes cliente = CrearCliente();
                gestionClientes.Agregar(cliente);
                Confirmacion(cliente);
                confirmacion.ShowDialog();
            }
        }

        public Clientes CrearCliente()
        {
            var cliente = new Clientes
            {                
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                Correo = tbCorreo.Text,
                UltimaVisita = dtUltimaVisita.Value,
                Cumpleaños = dtFechaCumpleaños.Value
            };
            return cliente;
        }

        public void Confirmacion(dynamic cliente)
        {
            confirmacion.SetNombre(cliente.Nombre);
            confirmacion.SetTelefono(cliente.Telefono.ToString());
            confirmacion.SetCorreo(cliente.Correo);
            confirmacion.SetUltimaVisita(cliente.UltimaVisita.ToShortDateString());
            confirmacion.SetCumpleaños(cliente.Cumpleaños.Date.ToShortDateString());
        }

        public Clientes CrearClienteActualizado()
        {
            var cliente = new Clientes
            {
                Id = idCliente,                
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                Correo = tbCorreo.Text,
                UltimaVisita = dtUltimaVisita.Value,
                Cumpleaños = dtFechaCumpleaños.Value
            };
            return cliente;
        }

        public void LlenarGridView()
        {         
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionClientes.ConsultarTodos();
            dgvClientes.DataSource = bin;
        }

        public void Eliminar()
        {
            if (lbId.Text == String.Empty)
            {

            } else
            {
                gestionClientes.Borrar(idCliente);
            }
        }        

        public void Filtrar()
        {
            var listaFiltrada = gestionClientes.Filtrar(tbBuscarClientes.Text);
            BindingSource bin = new BindingSource();
            bin.DataSource = listaFiltrada;
            dgvClientes.DataSource = bin;
        }

        public void CargarDatos()
        {
            tbNombre.Text = dgvClientes[1,posicion].Value.ToString();
            tbTelefono.Text = dgvClientes[2,posicion].Value.ToString();
            tbCorreo.Text = dgvClientes[3, posicion].Value.ToString();
            dtFechaCumpleaños.Value = DateTime.Parse(dgvClientes[4, posicion].Value.ToString());
            dtUltimaVisita.Value = DateTime.Parse(dgvClientes[5, posicion].Value.ToString());
            tbNombre.Focus();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());            
            CargarDatos();
        }

        private void tbBuscarClientes_TextChanged_1(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            posicion = dgvClientes.CurrentRow.Index;
        }
    }
}