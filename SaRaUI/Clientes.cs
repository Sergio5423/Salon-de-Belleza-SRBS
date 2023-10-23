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
        EditarCliente editarCliente = new EditarCliente();
        Servicios_Cliente servicios_Cliente = new Servicios_Cliente();
        string cedula;
        Entidades.Clientes cliente = new Entidades.Clientes();
        //System.Drawing.Font font;

        public Clientes()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lblClientes.Font = new Font(privateFonts.Families[0], 35);
            cbOrdenarClientes.Font = new Font(privateFonts.Families[0], 14);

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

        public Entidades.Clientes CrearCliente(string cedula,
                                               string nombre,
                                               string telefono,
                                               string correo,
                                               DateTime cumpleaños,
                                               DateTime ultimaVisita)
        {
            var cliente = new Entidades.Clientes
            {
                Cedula = cedula,
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo,
                Cumpleaños = cumpleaños,
                UltimaVisita = ultimaVisita
            };
            return cliente;
        }

        public void EnviarClienteEditar()
        {
            editarCliente.GetCedula(cedula);
            editarCliente.GetCliente(cliente);
        }

        public void EnviarClienteServicio()
        {
            servicios_Cliente.GetCliente(cliente);
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new AgregarCliente());
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            EnviarClienteEditar();
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new EditarCliente());
        }

        private void btnServiciosClientes_Click(object sender, EventArgs e)
        {
            EnviarClienteServicio();
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new Servicios_Cliente());
        }

        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {
            gestionClientes.Borrar(cedula);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cedula = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            cliente = CrearCliente(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                                  dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                                  dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString(),
                                                  dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString(),
                                                  DateTime.Parse(dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString()),
                                                  DateTime.Parse(dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString()));
        }
    }
}
