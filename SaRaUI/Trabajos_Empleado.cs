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
    public partial class Trabajos_Empleado : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        GestionTrabajos gestionTrabajos = new GestionTrabajos();
        GestionServicios gestionServicios = new GestionServicios();
        List<string> NombreServicios = null;
        string codigo;
        Entidades.Empleados empleado;

        public Trabajos_Empleado()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbTrabajos.Font = new Font(privateFonts.Families[0], 35);
            lbNombreEmpleado.Font = new Font(privateFonts.Families[0], 16);            
        }

        public void LlenarGridView(string ced)
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionTrabajos.ConsultarPorEmpleado(ced);
            dgvTrabajos_Empleado.DataSource = bin;
        }

        //public void Agregar()
        //{
        //    foreach (var servicio in Servicios)
        //    {
        //        if (servicio.Nombre == cbServicios.Text)
        //        {
        //            var trabajo = new Entidades.Trabajos
        //            {
        //                Fecha = DateTime.Now,
        //                Servicio_Codigo = servicio.Codigo,
        //                Empleado_Cedula = empleado.Cedula
        //            };
        //            gestionTrabajos.Agregar(trabajo);
        //        }
        //    }
        //}

        public void Borrar(string codigo)
        {
            gestionTrabajos.Borrar(codigo);
        }

        private void btnAtrasSC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarSC_Click(object sender, EventArgs e)
        {
            //Agregar();
        }

        private void btnBorrarSC_Click(object sender, EventArgs e)
        {
            Borrar(codigo);
        }

        private void dgvTrabajos_Empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgvTrabajos_Empleado.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
