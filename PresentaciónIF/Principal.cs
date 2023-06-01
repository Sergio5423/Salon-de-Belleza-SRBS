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
        GestionEmpleados gestionEmpleados = new GestionEmpleados();
        Confirmacion confirmacion;
        ServiciosForm serviciosForm;
        int idEmpleado = -1;
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
            LlenarGridViewEmpleados();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
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

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            AgregarEmpleado();
            LimpiarEmpleado();
            LlenarGridViewEmpleados();
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
            LimpiarEmpleado();
            LlenarGridViewEmpleados();
        }

        private void btnAgregarTrabajo_Click(object sender, EventArgs e)
        {
            AgregarTrabajo();
        }

        private void btnActualizarE_Click(object sender, EventArgs e)
        {
            gestionEmpleados.Actualizar(CrearEmpleadoActualizado());
            LimpiarEmpleado();
            LlenarGridViewEmpleados();
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

        public void AgregarCliente()
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
                Cumpleaños = dtFechaCumpleaños.Value,
                EstilistaFavorito = tbEstilista.Text
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
            confirmacion.SetEstilista(cliente.EstilistaFavorito);
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
                Cumpleaños = dtFechaCumpleaños.Value,
                EstilistaFavorito = tbEstilista.Text
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
            tbEstilista.Text = dgvClientes[6,posicion].Value.ToString();
        }

        public void PresentarEmpleado()
        {
            if (cbTrabajoE.SelectedIndex == 0)
            {
                lbValorE.Text = "0";
                lbComisionE.Text = gestionEmpleados.CalcularComision(int.Parse(lbValorE.Text)).ToString();
            }
            if (cbTrabajoE.SelectedIndex == 1)
            {
                lbValorE.Text = "0";
                lbComisionE.Text = gestionEmpleados.CalcularComision(int.Parse(lbValorE.Text)).ToString();
            }
            if (cbTrabajoE.SelectedIndex == 2)
            {
                lbValorE.Text = "0";
                lbComisionE.Text = gestionEmpleados.CalcularComision(int.Parse(lbValorE.Text)).ToString();
            }
            if (cbTrabajoE.SelectedIndex == 3)
            {
                lbValorE.Text = "0";
                lbComisionE.Text = gestionEmpleados.CalcularComision(int.Parse(lbValorE.Text)).ToString();
            }
        }

        public void LlenarGridViewEmpleados()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionEmpleados.Consultar();
            dgvEmpleados.DataSource = bin;
        }

        public void LimpiarEmpleado()
        {
            tbCedulaE.Text = string.Empty;
            tbNombreE.Text = string.Empty;
            cbTrabajoE.SelectedIndex = -1;
            lbValorE.Text = ".";
            lbComisionE.Text = ".";
            tbNombre.Focus();
        }

        public Empleados CrearEmpleado()
        {
            var empleado = new Empleados
            {
                Ced = tbCedulaE.Text,
                Nombre = tbNombreE.Text,
                Generado = 0,
                Comision = 0
            };
            return empleado;
        }

        public void AgregarEmpleado()
        {
            if ((tbCedulaE.Text == string.Empty) ||
                (tbNombreE.Text == string.Empty))          
            {

            }
            else
            {
                Empleados empleado = CrearEmpleado();
                gestionEmpleados.Agregar(empleado);
            }
        }

        public Empleados CrearEmpleadoActualizado()
        {
            var empleado = new Empleados
            {
                Ced = tbCedulaE.Text,
                Nombre = tbNombreE.Text,
                Generado = int.Parse(lbValorE.Text),
                Comision = int.Parse(lbComisionE.Text)
            };
            return empleado;
        }

        public void EliminarEmpleado()
        {
            if (idEmpleado == -1)
            {

            }
            else
            {
                gestionEmpleados.Borrar(idEmpleado);
            }
        }

        public void FiltrarEmpleado()
        {
            var listaFiltrada = gestionEmpleados.Filtrar(tbBuscarEmpleados.Text);
            BindingSource bin = new BindingSource();
            bin.DataSource = listaFiltrada;
            dgvEmpleados.DataSource = bin;
        }

        public void CargarDatosEmpleados()
        {
            tbCedulaE.Text = dgvClientes[1, posicion].Value.ToString();
            tbNombre.Text = dgvClientes[2, posicion].Value.ToString();                   
        }

        public void AgregarTrabajo()
        {
            gestionEmpleados.AgregarTrabajo(idEmpleado,int.Parse(lbValorE.Text));
        }

        private void tbBuscarClientes_TextChanged_1(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void cbTrabajoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            PresentarEmpleado();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());            
            CargarDatos();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            posicion = dgvClientes.CurrentRow.Index;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmpleado = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());
            posicion = dgvClientes.CurrentRow.Index;
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmpleado = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());
            CargarDatosEmpleados();
        }

        private void tbBuscarEmpleados_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleado();
        }
    }
}