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

namespace SaRaUI
{
    public partial class Clientes : Form
    {
        private Form activeForm = null;
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();                
        GestionClientes gestionClientes = new GestionClientes();
        GestionServicios_Clientes gestionServicios_Clientes = new GestionServicios_Clientes();
        string cedula, Nombre;
        Entidades.Clientes cliente = new Entidades.Clientes();
        //System.Drawing.Font font;

        public Clientes()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lblClientes.Font = new Font(privateFonts.Families[0], 35);
            cbOrdenarClientes.Font = new Font(privateFonts.Families[0], 14);
            LlenarGridView();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFondo.Controls.Add(childForm);
            panelFondo.Tag = childForm;
            childForm.BringToFront();            
            childForm.Show();
        }

        public void LlenarGridView()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionClientes.Consultar();
            dgvClientes.DataSource = bin;
        }

        public Entidades.Clientes CrearCliente(string cedula,
                                               string nombre,
                                               string telefono,
                                               string correo,
                                               DateTime cumpleaños,
                                               DateTime ultimaVisita,
                                               string empleado_cedula)
        {
            var cliente = new Entidades.Clientes
            {
                Cedula = cedula,
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo,
                Cumpleaños = cumpleaños,
                UltimaVisita = ultimaVisita,
                Empleado_Cedula = empleado_cedula
            };
            return cliente;
        }

        public void Borrar()
        {
            gestionClientes.Borrar(cedula);
        }

        //public void EnviarClienteEditar()
        //{
        //    EditarCliente editarCliente = new EditarCliente();
        //    editarCliente.GetCedula(cedula);
        //    editarCliente.GetCliente(cliente);            
        //}

        public void EnviarNombreServicios()
        {
            Servicios_Cliente servicios_cliente = new Servicios_Cliente();
            AddOwnedForm(servicios_cliente);
            servicios_cliente.Cedula = cedula;
            servicios_cliente.lbNombreCliente.Text = Nombre;
            servicios_cliente.lbNombreCliente.Font = new Font(privateFonts.Families[0], 16);            
            servicios_cliente.LlenarGridView(cedula);            
            servicios_cliente.Show();
        }

        public void EnviarClienteEditar()
        {
            EditarCliente editarCliente = new EditarCliente();
            AddOwnedForm(editarCliente);
            editarCliente.tbCedEC.Text = cliente.Cedula;
            editarCliente.tbNomEC.Text = cliente.Nombre;
            editarCliente.tbTelEC.Text = cliente.Telefono;
            editarCliente.tbCorreoEC.Text = cliente.Correo;
            editarCliente.dtpCumpleañosEC.Value = cliente.Cumpleaños;
            editarCliente.cedula = cedula;
            editarCliente.Show();
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new AgregarCliente());
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            EnviarClienteEditar();
            //panelBottom.Dock = DockStyle.None;
            //OpenChildForm(new EditarCliente());
        }

        private void btnServiciosClientes_Click(object sender, EventArgs e)
        {            
            //panelBottom.Dock = DockStyle.None;
            //OpenChildForm(new Servicios_Cliente());
            EnviarNombreServicios();
        }

        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cedula = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            cliente = CrearCliente(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                   dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                   dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString(),
                                   dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString(),
                                   DateTime.Parse(dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString()),
                                   DateTime.Parse(dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                   dgvClientes.Rows[e.RowIndex].Cells[6].Value.ToString());
            Nombre = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
