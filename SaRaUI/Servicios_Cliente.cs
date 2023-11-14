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
    public partial class Servicios_Cliente : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        GestionServicios gestionServicios = new GestionServicios();
        GestionEmpleados gestionEmpleados = new GestionEmpleados();
        GestionServicios_Clientes gestionServicios_Clientes = new GestionServicios_Clientes();
        string Codigo;
        public string Cedula;
        List<Entidades.Servicios> Servicios = null;
        List<Entidades.Empleados> Empleados = null;

        public Servicios_Cliente()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbServicios_del_Cliente.Font = new Font(privateFonts.Families[0], 35);                        
            Servicios = gestionServicios.Consultar();
            foreach (Entidades.Servicios servicio in Servicios)
            {
                cbServicios.Items.Add(servicio.Nombre);
            }
            Empleados = gestionEmpleados.Consultar();
            foreach (Entidades.Empleados empleado in Empleados)
            {
                cbEmpleados.Items.Add(empleado.Nombre);
            }      
        }

        public void LlenarGridView(string ced)
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionServicios_Clientes.ConsultarServicios(ced);
            dgvServicios_Cliente.DataSource = bin;
        }

        public void Agregar()
        {
            var cliente_servicio = new Entidades.Clientes_Servicios
            {
                Cedula_Cliente = Cedula,                
                Codigo_Servicio = Servicios[cbServicios.SelectedIndex].Codigo,
                Empleado_Cedula = Empleados[cbEmpleados.SelectedIndex].Cedula
            };
            gestionServicios_Clientes.Agregar(cliente_servicio);           
        }

        public void Borrar()
        {
           gestionServicios_Clientes.BorrarServicio(Codigo, Cedula);
        }

        private void btnAtrasSC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarSC_Click(object sender, EventArgs e)
        {
            Agregar();
            LlenarGridView(Cedula);
        }

        private void btnBorrarSC_Click(object sender, EventArgs e)
        {
            Borrar();
            LlenarGridView(Cedula);
        }

        private void dgvServicios_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo = dgvServicios_Cliente.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
