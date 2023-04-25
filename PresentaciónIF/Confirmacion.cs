using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónIF
{
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
        }

        public void SetCategoria(string categoria)
        {
            lbCategoria.Text = categoria;            
        }

        public string GetCategoria()
        {
            return lbCategoria.Text;
        }

        public void SetNombre(string nombre)
        {
            lbNombre.Text = nombre;
        }

        public void SetTelefono(string telefono)
        {
            lbTelefono.Text = telefono;
        }

        public void SetCorreo(string correo)
        {
            lbCorreo.Text = correo;
        }

        public void SetUltimaVisita(string ultimaVisita)
        {
            lbUltimaVisita.Text = ultimaVisita;
        }

        public void SetCumpleaños(string cumpleaños)
        {
            lbCumpleaños.Text = cumpleaños;
        }

        public void SetVolver(string volver)
        {
            lbVolver.Text = volver;
        }
    }
}
