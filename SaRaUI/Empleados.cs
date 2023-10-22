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
    public partial class Empleados : Form
    {
        private Form activeForm = null;
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();

        public Empleados()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbEmpleados.Font = new Font(privateFonts.Families[0], 35);
            cbOrdenarEmpleados.Font = new Font(privateFonts.Families[0], 14);
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

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new AgregarEmpleado());
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new EditarEmpleado());
        }
    }
}
