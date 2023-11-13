using Logica;
using Entidades;
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
    public partial class EditarCliente : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();        
        string cedula;
        Entidades.Clientes cliente = null;
        GestionClientes gestionClientes = new GestionClientes();

        public EditarCliente()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lblEC.Font = new Font(privateFonts.Families[0], 35);
            lbIngreseDatosEC.Font = new Font(privateFonts.Families[0], 20);
            
            if (cliente == null)
            {

            }
            else
            {
                tbCedEC.Text = cliente.Cedula;
                tbNomEC.Text = cliente.Nombre;
                tbTelEC.Text = cliente.Telefono;
                tbCorreoEC.Text = cliente.Correo;
                dtpCumpleañosEC.Value = cliente.Cumpleaños;
            }
   
        }

        public void GetCedula(string ced)
        {
            cedula = ced;
        }

        public void GetCliente(Entidades.Clientes client)
        {
            cliente = client;
        }

        public void Editar()
        {
            var cliente = new Entidades.Clientes
            {
                Cedula = tbCedEC.Text,
                Nombre = tbNomEC.Text,
                Telefono = tbTelEC.Text,
                Correo = tbCorreoEC.Text,
                Cumpleaños = dtpCumpleañosEC.Value,
            };
            gestionClientes.Actualizar(cedula,cliente);
        }

        private void btnAtrasEC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEC_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}
