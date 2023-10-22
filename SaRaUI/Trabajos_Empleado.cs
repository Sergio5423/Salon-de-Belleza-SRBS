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

        public Trabajos_Empleado()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbTrabajos.Font = new Font(privateFonts.Families[0], 35);
            lbNombreEmpleado.Font = new Font(privateFonts.Families[0], 16);
        }

        private void btnAtrasSC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
