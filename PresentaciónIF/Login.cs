using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using Entidades;
using Logica;

namespace PresentaciónIF
{
    public partial class Login : Form
    {
        GestionCredenciales gestionCredenciales = new GestionCredenciales();
        Principal principal = new Principal();

        public Login()
        {
            InitializeComponent();
        }
        
        public string GetUsuario()
        {
            return tbUsuario.Text;
        }

        public string GetContraseña()
        {
            return tbContraseña.Text;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool check = gestionCredenciales.Validar(GetUsuario(), GetContraseña());
            if (check == true)
            {                
                principal.Show();
            } else
            {
                MessageBox.Show("Incorrecto");
            }
        }
    }
}
