using Entidades;
using Logica;
using PresentaciónIF.Properties;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentaciónIF
{
    public partial class Clientes : Form
    {
        GestionClientes gestionClientes = new GestionClientes();
        GestionServicios gestionServicios = new GestionServicios();
        GestionEmpleados gestionEmpleados = new GestionEmpleados();
        Confirmacion confirmacion;
        ServiciosCliente serviciosForm;
        int idEmpleado = -1;
        int idCliente;
        int posicion;
        int precAlis = 200000;
        int precDis = 300000;
        int precQuim = 70000;
        int precRes = 80000;
        int precBlow = 30000;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            confirmacion = new Confirmacion();
            serviciosForm = new ServiciosCliente();
            LlenarGridViewClientes();
            LlenarGridViewEmpleados();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
            LimpiarCliente();
            LlenarGridViewClientes();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
            LimpiarCliente();
            LlenarGridViewClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
            LimpiarCliente();
            LlenarGridViewClientes();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Entidades.Clientes cliente = gestionClientes.Buscar(idCliente);
            if (cliente == null)
            {
                MessageBox.Show("Seleccione un Cliente");
            } else
            {
                serviciosForm.SetCliente(cliente);
                serviciosForm.ShowDialog();
            }            
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
            LlenarGridViewEmpleados();
        }

        private void btnActualizarE_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
            LimpiarEmpleado();
            LlenarGridViewEmpleados();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            gestionClientes.CrearPdfClientes("Clientes");
            Process.Start("Clientes.pdf");
        }

        private void btnPdfE_Click(object sender, EventArgs e)
        {
            gestionEmpleados.CrearPdfEmpleados("Empleados");
            Process.Start("Empleados.pdf");
        }

        private void btnSalirC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarCliente()
        {
            tbNombre.Text = string.Empty;
            tbCorreo.Text = string.Empty;
            tbTelefono.Text = string.Empty;            
            dtUltimaVisita.Value = DateTime.Now;
            dtFechaCumpleaños.Value = DateTime.Now;
            tbEstilista.Text = string.Empty;
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
                Entidades.Clientes cliente = CrearCliente();
                gestionClientes.Agregar(cliente);
                ConfirmacionCliente(cliente);
                confirmacion.ShowDialog();              
            }
        }

        public void ActualizarCliente()
        {
            if ((tbNombre.Text == string.Empty) ||
                (tbTelefono.Text == string.Empty) ||
                (tbCorreo.Text == string.Empty))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                gestionClientes.Actualizar(CrearClienteActualizado());
            }
        }

        public Entidades.Clientes CrearCliente()
        {
            var cliente = new Entidades.Clientes
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

        public void ConfirmacionCliente(dynamic cliente)
        {
            confirmacion.SetNombre(cliente.Nombre);
            confirmacion.SetTelefono(cliente.Telefono.ToString());
            confirmacion.SetCorreo(cliente.Correo);
            confirmacion.SetUltimaVisita(cliente.UltimaVisita.ToShortDateString());
            confirmacion.SetCumpleaños(cliente.Cumpleaños.Date.ToShortDateString());
            confirmacion.SetEstilista(cliente.EstilistaFavorito);
        }

        public Entidades.Clientes CrearClienteActualizado()
        {
            var cliente = new Entidades.Clientes
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

        public void LlenarGridViewClientes()
        {         
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionClientes.Consultar();
            dgvClientes.DataSource = bin;
        }

        public void EliminarCliente()
        {
            if (lbId.Text == String.Empty)
            {

            } else
            {
                gestionClientes.Borrar(idCliente);
            }
        }        

        public void FiltrarCliente()
        {
            var listaFiltrada = gestionClientes.Filtrar(tbBuscarClientes.Text);
            BindingSource bin = new BindingSource();
            bin.DataSource = listaFiltrada;
            dgvClientes.DataSource = bin;
        }

        public void CargarDatosCliente()
        {
            tbNombre.Text = dgvClientes[1,posicion].Value?.ToString()?? "";
            tbTelefono.Text = dgvClientes[2,posicion].Value?.ToString()?? "";
            tbCorreo.Text = dgvClientes[3, posicion].Value?.ToString() ?? "";
            try
            {

            }
            catch (ArgumentOutOfRangeException)
            {
                dtFechaCumpleaños.Value = DateTime.Parse(dgvClientes[4, posicion].Value.ToString());
                dtUltimaVisita.Value = DateTime.Parse(dgvClientes[5, posicion].Value.ToString());
            }                             
            tbEstilista.Text = dgvClientes[6, posicion].Value?.ToString() ?? "";
        }

        public void PresentarTrabajo()
        {
            if (cbTrabajoE.SelectedIndex == 0)
            {
                lbValorE.Text = $"${precAlis}";
                lbComisionE.Text = $"${gestionEmpleados.CalcularComision(precAlis)}";
            }
            if (cbTrabajoE.SelectedIndex == 1)
            {
                lbValorE.Text = $"${precDis}";
                lbComisionE.Text = $"${gestionEmpleados.CalcularComision(precDis)}";
            }
            if (cbTrabajoE.SelectedIndex == 2)
            {
                lbValorE.Text = $"${precQuim}";
                lbComisionE.Text = $"${gestionEmpleados.CalcularComision(precQuim)}";
            }
            if (cbTrabajoE.SelectedIndex == 3)
            {
                lbValorE.Text = $"${precRes}";
                lbComisionE.Text = $"${gestionEmpleados.CalcularComision(precRes)}";
            }
            if (cbTrabajoE.SelectedIndex == 4)
            {
                lbValorE.Text = $"${precBlow}";
                lbComisionE.Text = $"${gestionEmpleados.CalcularComision(precBlow)}";
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
                if (tbCedulaE.Text.All(char.IsDigit))
                {
                    Empleados empleado = CrearEmpleado();
                    gestionEmpleados.Agregar(empleado);
                } else
                {
                    MessageBox.Show("Ingrese solo números");
                }                    
            }
        }

        public void ActualizarEmpleado()
        {
            if ((tbCedulaE.Text == string.Empty) ||
                (tbNombreE.Text == string.Empty))
            {
                MessageBox.Show("Ingrese todos los datos");
            } else
            {
                gestionEmpleados.Actualizar(CrearEmpleadoActualizado());
            }            
        }

        public Empleados CrearEmpleadoActualizado()
        {
            var empleado = new Empleados
            {
                Id = idEmpleado,
                Ced = tbCedulaE.Text,
                Nombre = tbNombreE.Text,
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
            tbCedulaE.Text = dgvEmpleados[1, posicion].Value.ToString();
            tbNombreE.Text = dgvEmpleados[2, posicion].Value.ToString();                   
        }

        public void AgregarTrabajo()
        {
            if (idEmpleado == -1)
            {
                MessageBox.Show("Seleccione un empleado");
            }
            else
            {
                if (cbTrabajoE.SelectedIndex == 0)
                {
                    gestionEmpleados.AgregarTrabajo(idEmpleado, precAlis);
                }
                if (cbTrabajoE.SelectedIndex == 1)
                {
                    gestionEmpleados.AgregarTrabajo(idEmpleado, precDis);
                }
                if (cbTrabajoE.SelectedIndex == 2)
                {
                    gestionEmpleados.AgregarTrabajo(idEmpleado, precQuim);
                }
                if (cbTrabajoE.SelectedIndex == 3)
                {
                    gestionEmpleados.AgregarTrabajo(idEmpleado, precRes);
                }
                if (cbTrabajoE.SelectedIndex == 4)
                {
                    gestionEmpleados.AgregarTrabajo(idEmpleado, precBlow);
                }
            }            
        }

        private void cbTrabajoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            PresentarTrabajo();
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idCliente = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                posicion = dgvClientes.CurrentRow.Index;
            } catch (ArgumentOutOfRangeException)
            {

            }                        
        }

        private void dgvClientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idCliente = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                posicion = dgvClientes.CurrentRow.Index;
                
            } catch (ArgumentOutOfRangeException)
            {

            }
            CargarDatosCliente();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idEmpleado = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());
                posicion = dgvEmpleados.CurrentRow.Index;
            } catch (ArgumentOutOfRangeException)
            {

            }            
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmpleado = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());
            posicion = dgvEmpleados.CurrentRow.Index;
            CargarDatosEmpleados();
        }

        private void tbBuscarEmpleados_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleado();
        }

        private void tbBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            FiltrarCliente();
        }
    }
}