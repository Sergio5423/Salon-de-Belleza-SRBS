using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace PresentaciónIF
{
    public partial class Principal : Form
    {
        GestionAlisados gestionAlisados = new GestionAlisados();
        GestionTrabajoColor gestionTrabajoColor = new GestionTrabajoColor();
        GestionMantenimiento gestionMantenimiento = new GestionMantenimiento();
        GestionIrregulares gestionIrregulares = new GestionIrregulares();
        GestionListasDto gestionListasDto = new GestionListasDto();
        Confirmacion confirmacion;

        public Principal()
        {
            InitializeComponent();            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            confirmacion = new Confirmacion();            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Capturar();
            Limpiar();
            LlenarGridView();
            /*Aqui va cargar lista con el llenar grid view 3 para
            usar el bin.Filter()*/
        }

        public void Limpiar()
        {
            tbNombre.Text = string.Empty;
            tbCorreo.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            cbCategoria.SelectedIndex = -1;
            dtUltimaVisita.Value = DateTime.Now;
            dtFechaCumpleaños.Value = DateTime.Now;
            gridViewClientes.Rows.Clear();
            tbNombre.Focus();
        }

        public void Capturar()
        {
            if ((tbNombre.Text == string.Empty) || 
                (tbTelefono.Text == string.Empty) || 
                (tbCorreo.Text == string.Empty) || 
                (cbCategoria.SelectedIndex == -1))
            {

            } else
            {
                if (cbCategoria.SelectedIndex == 0)
                {
                    var Alisado = new Alisados
                    {
                        Categori = cbCategoria.SelectedItem.ToString(),
                        Nombre = tbNombre.Text,
                        Telefono = long.Parse(tbTelefono.Text),
                        Correo = tbCorreo.Text,
                        UltimaVisita = dtUltimaVisita.Value,
                        Cumpleaños = dtFechaCumpleaños.Value                        
                    };
                    gestionAlisados.Agregar(Alisado);                    
                    Confirmacion(Alisado);
                    confirmacion.ShowDialog();

                } else
                {
                    if (cbCategoria.SelectedIndex == 1)
                    {
                        var Color = new TrabajoColor
                        {
                            Categori = cbCategoria.SelectedItem.ToString(),
                            Nombre = tbNombre.Text,
                            Telefono = long.Parse(tbTelefono.Text),
                            Correo = tbCorreo.Text,
                            UltimaVisita = dtUltimaVisita.Value,
                            Cumpleaños = dtFechaCumpleaños.Value
                        };
                        gestionTrabajoColor.Agregar(Color);
                        Confirmacion(Color);
                        confirmacion.ShowDialog();

                    } else
                    {
                        if (cbCategoria.SelectedIndex == 2)
                        {
                            var mantenimiento = new Mantenimiento
                            {
                                Categori = cbCategoria.SelectedItem.ToString(),
                                Nombre = tbNombre.Text,
                                Telefono = long.Parse(tbTelefono.Text),
                                Correo = tbCorreo.Text,
                                UltimaVisita = dtUltimaVisita.Value,
                                Cumpleaños = dtFechaCumpleaños.Value
                            };                            
                            gestionMantenimiento.Agregar(mantenimiento);
                            Confirmacion(mantenimiento);
                            confirmacion.ShowDialog();

                        } else
                        {
                            if (cbCategoria.SelectedIndex == 3)
                            {
                                var Irregular = new Irregulares
                                {
                                    Categori = cbCategoria.SelectedItem.ToString(),
                                    Nombre = tbNombre.Text,
                                    Telefono = long.Parse(tbTelefono.Text),
                                    Correo = tbCorreo.Text,
                                    UltimaVisita = dtUltimaVisita.Value,
                                    Cumpleaños = dtFechaCumpleaños.Value
                                };                                
                                gestionIrregulares.Agregar(Irregular);
                                Confirmacion(Irregular);
                                confirmacion.ShowDialog();
                            }
                        }
                    }                                                            
                }
            }
        }

        public void Confirmacion(dynamic cliente)
        {
            confirmacion.SetCategoria(cbCategoria.SelectedItem.ToString());
            confirmacion.SetNombre(cliente.Nombre);
            confirmacion.SetTelefono(cliente.Telefono.ToString());
            confirmacion.SetCorreo(cliente.Correo);
            confirmacion.SetUltimaVisita(cliente.UltimaVisita.ToString());
            confirmacion.SetCumpleaños(cliente.Cumpleaños.ToString());
            confirmacion.SetVolver(cliente.Regreso(cliente.UltimaVisita).ToString());
        }

        public void LlenarGridView()
        {
            if (gestionAlisados.Consultar() == null)
            {

            } else
            {
                foreach (var item in gestionAlisados.Consultar())
                {
                    gridViewClientes.Rows.Add(item.Categori,
                                              item.Nombre,
                                              item.Telefono,
                                              item.Correo,
                                              item.UltimaVisita,
                                              item.Cumpleaños,
                                              item.Regreso(item.UltimaVisita));
                }                
            }
            if (gestionIrregulares.Consultar() == null)
            {

            } else
            {
                foreach (var item in gestionIrregulares.Consultar())
                {
                    gridViewClientes.Rows.Add(item.Categori,
                                              item.Nombre,
                                              item.Telefono,
                                              item.Correo,
                                              item.UltimaVisita,
                                              item.Cumpleaños,
                                              item.Regreso(item.UltimaVisita));
                }
            }
            if (gestionMantenimiento.Consultar() == null)
            {

            } else
            {
                foreach (var item in gestionMantenimiento.Consultar())
                {
                    gridViewClientes.Rows.Add(item.Categori, 
                                              item.Nombre,
                                              item.Telefono,
                                              item.Correo,
                                              item.UltimaVisita,
                                              item.Cumpleaños,
                                              item.Regreso(item.UltimaVisita));
                }
            }
            if (gestionTrabajoColor.Consultar() == null)
            {

            } else
            {
                foreach (var item in gestionTrabajoColor.Consultar())
                {
                    gridViewClientes.Rows.Add(item.Categori, 
                                              item.Nombre,
                                              item.Telefono,
                                              item.Correo,
                                              item.UltimaVisita,
                                              item.Cumpleaños,
                                              item.Regreso(item.UltimaVisita));
                }
            }
        }
    }
}