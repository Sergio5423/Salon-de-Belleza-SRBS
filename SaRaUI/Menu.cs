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
        GestorFuentes gestorFuentes = new GestorFuentes();

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        System.Drawing.Font font;

        public Menu()
        {
            InitializeComponent();

            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            //font = new Font(privateFonts.Families[0], 35);
            lblHora.Font = new Font(privateFonts.Families[0], 35); ;
            lblFecha.Font = new Font(privateFonts.Families[0], 14); ;
        }

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
