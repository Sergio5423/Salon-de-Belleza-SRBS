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
    public partial class AgregarServicio : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        GestionServicios gestionServicios = new GestionServicios();

        public AgregarServicio()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbNuevoServicio.Font = new Font(privateFonts.Families[0], 35);
            lbIngreseElServicio.Font = new Font(privateFonts.Families[0], 20);
        }

        public void Agregar()
        {
            var servicio = new Entidades.Servicios
            {
                Nombre = tbNombreServ.Text,
                Duracion = int.Parse(tbRegresoServ.Text),
                Valor = int.Parse(tbValorServ.Text),
            };
            gestionServicios.Agregar(servicio);
            Servicios servicios = new Servicios();
            servicios.LlenarGridView();
            this.Close();
        }

        private void btnAtrasServ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarServ_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}
