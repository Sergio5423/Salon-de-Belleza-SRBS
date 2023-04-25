using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace PresentaciónIF
{
    public partial class Principal : Form
    {
        GestionAlisados gestionAlisados = new GestionAlisados();
        GestionTrabajoColor gestionTrabajoColor = new GestionTrabajoColor();
        GestionMantenimiento gestionMantenimiento = new GestionMantenimiento();
        GestionIrregulares gestionIrregulares = new GestionIrregulares();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Capturar();
            Limpiar();
            /*Aqui va cargar lista con el llenar grid view 3 para
            usar el bin.Filter()*/
        }

        public void Limpiar()
        {

            dtUltimaVisita.Value = DateTime.Now;
            dtFechaCumpleaños.Value = DateTime.Now;
            tbNombre.Focus();
        }

        public void Capturar()
        {
            if ((tbNombre.Text == string.Empty) || 
                (tbTelefono.Text == string.Empty) || 
                (tbCorreo.Text == string.Empty) || 
                (cbCategoria.SelectedItem == null))
            {

            } else
            {
                if (cbCategoria.SelectedIndex == 1)
                {
                    var Alisado = new Alisados();

                    Alisado.Nombre = tbNombre.Text;
                    Alisado.Telefono = long.Parse(tbTelefono.Text);
                    Alisado.Correo = tbCorreo.Text;
                    Alisado.UltimaVisita = dtUltimaVisita.Value;
                    Alisado.Cumpleaños = dtFechaCumpleaños.Value;
                    gestionAlisados.Agregar(Alisado);                    

                } else
                {
                    if (cbCategoria.SelectedIndex == 2)
                    {
                        var Color = new TrabajoColor();

                        Color.Nombre = tbNombre.Text;
                        Color.Telefono = long.Parse(tbTelefono.Text);
                        Color.Correo = tbCorreo.Text;
                        Color.UltimaVisita = dtUltimaVisita.Value;
                        Color.Cumpleaños = dtFechaCumpleaños.Value;
                        gestionTrabajoColor.Agregar(Color);
                    }
                    //Terminar Agregar con las otras entidades
                }
            }
        }
    }
}
