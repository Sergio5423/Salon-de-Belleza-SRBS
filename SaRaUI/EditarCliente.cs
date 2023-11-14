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
        public string cedula = null;        
        public Entidades.Clientes cliente;
        GestionClientes gestionClientes = new GestionClientes();
        GestionEmpleados gestionEmpleados = new GestionEmpleados();
        List<Entidades.Empleados> empleados = null;

        public EditarCliente()
        {
            InitializeComponent();            
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lblEC.Font = new Font(privateFonts.Families[0], 35);
            lbIngreseDatosEC.Font = new Font(privateFonts.Families[0], 20);
            empleados = gestionEmpleados.Consultar();
            foreach (Entidades.Empleados empleado in empleados)
            {
                cbCed_Empleado.Items.Add(empleado.Nombre);
            }           
        }

        public void GetCedula(string ced)
        {
            tbCedEC.Text = ced;            
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
                Empleado_Cedula = empleados[cbCed_Empleado.SelectedIndex].Cedula
            };
            gestionClientes.Actualizar(cedula,cliente);
        }

        private void btnAtrasEC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEC_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            Editar();
            clientes.LlenarGridView();
            this.Close();
        }
    }
}
