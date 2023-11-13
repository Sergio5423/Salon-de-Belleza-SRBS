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
        Entidades.Clientes cliente;
        Entidades.Clientes_Servicios clientes_servicios;
        GestionServicios gestionServicios = new GestionServicios();
        GestionServicios_Clientes gestionServicios_Clientes = new GestionServicios_Clientes();
        string Codigo, Cedula;
        List<string> NombreServicios = null;
        List<Entidades.Servicios> Servicios = null;

        public Servicios_Cliente()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbServicios_del_Cliente.Font = new Font(privateFonts.Families[0], 35);
            lbNombreCliente.Font = new Font(privateFonts.Families[0], 16);
            if (cliente == null)
            {
                
            } else
            {
                lbNombreCliente.Text = cliente.Nombre;
             //   Servicios = gestionServicios.Consultar();
            }
            if (Servicios == null)
            {

            } else
            {
                foreach (var servicio in Servicios)
                {
                    NombreServicios.Add(servicio.Nombre);
                }
                cbServicios.Items.Add(NombreServicios);
            }
            LlenarGridView();
        }

        public void LlenarGridView()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionServicios_Clientes.ConsultarServicios(Cedula);
            dgvServicios_Cliente.DataSource = bin;
        }

        public void Agregar()
        {
            foreach (var servicio in Servicios)
            {
                if (servicio.Nombre==cbServicios.Text)
                {
                    var clientes_servicios = new Entidades.Clientes_Servicios
                    {
                        Codigo_Servicio = servicio.Codigo,
                        Cedula_Cliente = cliente.Cedula
                    };
                    gestionServicios_Clientes.Agregar(clientes_servicios);
                }
            }            
        }

        public void Borrar()
        {
           gestionServicios_Clientes.BorrarServicio(Codigo, Cedula);
        }

        public void GetCliente(Entidades.Clientes client)
        {
            cliente = client;
        }

        private void btnAtrasSC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarSC_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnBorrarSC_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void dgvServicios_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo = dgvServicios_Cliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            Cedula = dgvServicios_Cliente.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
