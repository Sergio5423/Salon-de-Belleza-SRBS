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
        //VARIABLES
        //System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        //System.Drawing.Font font;

        public Menu()
        {
            InitializeComponent();
            //privateFonts.AddFontFile(@".\Fonts\Mistress Benedict.ttf");
            //font = new Font(privateFonts.Families[0], 12);
            //lblHora.Font = new Font("Mistress Benedict", 36);
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
