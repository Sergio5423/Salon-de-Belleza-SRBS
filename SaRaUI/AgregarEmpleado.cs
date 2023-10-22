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
    public partial class AgregarEmpleado : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();

        public AgregarEmpleado()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbNuevoEmpleado.Font = new Font(privateFonts.Families[0], 35);
            lbIngreseSusDatos.Font = new Font(privateFonts.Families[0], 20);
        }

        private void btnAtrasEm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
