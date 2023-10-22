﻿using System;
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
    public partial class Servicios_Cliente : Form
    {

        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();

        public Servicios_Cliente()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lbServicios_del_Cliente.Font = new Font(privateFonts.Families[0], 35);
            lbNombreCliente.Font = new Font(privateFonts.Families[0], 20);
        }

        private void btnAtrasSC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}