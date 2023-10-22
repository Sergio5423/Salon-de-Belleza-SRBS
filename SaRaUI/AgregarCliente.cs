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
    public partial class AgregarCliente : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();

        public AgregarCliente()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lblNC.Font = new Font(privateFonts.Families[0], 35);
            lblIngresaDatosNC.Font = new Font(privateFonts.Families[0], 20);
        }

        private void btnAtrasNC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
