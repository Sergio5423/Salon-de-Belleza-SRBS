using System.Windows.Forms;

namespace PresentaciónIF
{
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
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

        public void SetEstilista(string estilista)
        {
            lbEstilista.Text = estilista;
        }
    }
}
