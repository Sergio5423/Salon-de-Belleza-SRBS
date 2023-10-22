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
    public partial class Menu : Form
    {
        private Form activeForm = null;

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        //System.Drawing.Font font;

        public Menu()
        {
            InitializeComponent();

            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            //font = new Font(privateFonts.Families[0], 35);
            lblHora.Font = new Font(privateFonts.Families[0], 35);
            lblFecha.Font = new Font(privateFonts.Families[0], 14);
        }

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFondo.Controls.Add(childForm);
            panelFondo.Tag = childForm;
            childForm.BringToFront();
            panelHora.Visible = false;
            panelBottom.Visible = false;
            childForm.Show();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panelHora.Visible = true;
            panelBottom.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clientes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Empleados());
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Trabajos());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Servicios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
