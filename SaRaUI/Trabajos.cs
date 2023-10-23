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
    public partial class Trabajos : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        GestionTrabajos gestionTrabajos = new GestionTrabajos();

        public Trabajos()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbTrabajos.Font = new Font(privateFonts.Families[0], 35);
            cbOrdenarTrabajos.Font = new Font(privateFonts.Families[0], 14);
            LlenarGridView();
        }

        public void LlenarGridView()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = gestionTrabajos.Consultar();
            dgvTrabajos.DataSource = bin;
        }
    }
}
