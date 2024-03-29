﻿using Logica;
using Entidades;
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
        GestionClientes gestionClientes = new GestionClientes();
        GestionEmpleados gestionEmpleados = new GestionEmpleados();
        List<Entidades.Empleados> empleados = null;
        Clientes clientes = new Clientes();

        public AgregarCliente()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\starr\Source\Repos\Sergio5423\Salon-de-Belleza-SRBS\SaRaUI\Fonts\Playlist Script.ttf");
            lblNC.Font = new Font(privateFonts.Families[0], 35);
            lblIngresaDatosNC.Font = new Font(privateFonts.Families[0], 20);
            empleados = gestionEmpleados.Consultar();
            foreach (Entidades.Empleados empleado in empleados)
            {
                cbCed_Empleado.Items.Add(empleado.Nombre);
            }
        }

        public void Agregar()
        {
            var cliente = new Entidades.Clientes
            {
                Cedula = tbCedulaNC.Text,
                Nombre = tbNombreNC.Text,
                Telefono = tbTelefonoNC.Text,
                Correo = tbCorreoNC.Text,
                UltimaVisita = DateTime.Now,
                Cumpleaños = dtpCumpleaños.Value,
                Empleado_Cedula = empleados[cbCed_Empleado.SelectedIndex].Cedula
            };            
            gestionClientes.Agregar(cliente);
        }

        private void btnAtrasNC_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnGuardarNC_Click(object sender, EventArgs e)
        {            
            Agregar();
            clientes.LlenarGridView();
            this.Close();
        }
    }
}
