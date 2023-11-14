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
    public partial class EditarEmpleado : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        GestionEmpleados gestionEmpleados = new GestionEmpleados();
        Entidades.Empleados empleado;
        string cedula;

        public EditarEmpleado()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbEditarEmpleado.Font = new Font(privateFonts.Families[0], 35);
            lbIngreseDatosEm.Font = new Font(privateFonts.Families[0], 20);
        }

        public void Editar()
        {
            var empleado = new Entidades.Empleados
            {
                Cedula = tbCedulaEm.Text,
                Nombre = tbNombreEm.Text,
                Telefono = tbTelefonoEm.Text,
            };
            gestionEmpleados.Actualizar(cedula, empleado);
            Empleados empleados = new Empleados();
            empleados.LlenarGridView();
            this.Close();
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
