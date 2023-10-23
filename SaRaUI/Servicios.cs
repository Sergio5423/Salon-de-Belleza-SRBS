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
    public partial class Servicios : Form
    {

        private Form activeForm = null;
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();

        public Servicios()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbServicios.Font = new Font(privateFonts.Families[0], 35);
            cbOrdenarServicios.Font = new Font(privateFonts.Families[0], 14);
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
            bin.DataSource = gestionServicios.Consultar();
            dgvServicios.DataSource = bin;
        }

        private void btnAgregarServicios_Click(object sender, EventArgs e)
        {
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new AgregarServicio());
        }
    }
}
