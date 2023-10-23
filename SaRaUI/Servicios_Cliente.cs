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
        List<string> NombreServicios = null;
        List<Entidades.Servicios> Servicios = null;

        public Servicios_Cliente()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbServicios_del_Cliente.Font = new Font(privateFonts.Families[0], 35);
            lbNombreCliente.Font = new Font(privateFonts.Families[0], 16);
            lbNombreCliente.Text = cliente.Nombre;
            Servicios = gestionServicios.Consultar();
            foreach(var servicio in Servicios) 
            {
                NombreServicios.Add(servicio.Nombre);
            }
            cbServicios.Items.Add(NombreServicios);
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
                }
            }
        }

        public void Borrar()
        {
           
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
    }
}
