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
    public partial class Empleados : Form
    {
        private Form activeForm = null;
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        EditarEmpleado editarEmpleado = new EditarEmpleado();
        Trabajos_Empleado trabajos_Empleado = new Trabajos_Empleado();
        GestionEmpleados gestionEmpleados = new GestionEmpleados();
        Entidades.Empleados empleado = new Entidades.Empleados();
        string cedula;

        public Empleados()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbEmpleados.Font = new Font(privateFonts.Families[0], 35);
            cbOrdenarEmpleados.Font = new Font(privateFonts.Families[0], 14);
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
            bin.DataSource = gestionEmpleados.Consultar();
            dgvEmpleados.DataSource = bin;
        }

        public void EnviarEmpleadoEditar()
        {
            editarEmpleado.GetCedula(cedula);
            editarEmpleado.GetEmpleado(empleado);
        }

        public void EnviarEmpleadoTrabajo()
        {
            trabajos_Empleado.GetEmpleado(empleado);
        }

        public Entidades.Empleados CrearEmpleado(string ced, string nomb, string tel)
        {
            var empleado = new Entidades.Empleados
            {
                Cedula = ced,
                Nombre = nomb,
                Telefono = tel
            };
            return empleado;
        }

        public void Borrar()
        {
            gestionEmpleados.Borrar(cedula);
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new AgregarEmpleado());
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            EnviarEmpleadoEditar();
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new EditarEmpleado());
        }

        private void btnTrabajosEmpleados_Click(object sender, EventArgs e)
        {
            EnviarEmpleadoTrabajo();
            panelBottom.Dock = DockStyle.None;
            OpenChildForm(new Trabajos_Empleado());
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cedula = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
            empleado = CrearEmpleado(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                     dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                     dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            Borrar();
        }
    }
}
