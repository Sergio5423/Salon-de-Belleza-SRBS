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
            //if (gestionAlisados.Consultar() == null)
            //{

            //}
            //else
            //{
            //    foreach (var item in gestionAlisados.Consultar())
            //    {
            //        gridViewClientes.Rows.Add(item.Categori,
            //                                  item.Nombre,
            //                                  item.Telefono,
            //                                  item.Correo,
            //                                  item.UltimaVisita,
            //                                  item.Cumpleaños,
            //                                  item.Regreso(item.UltimaVisita));
            //    }
            //}
            //if (gestionIrregulares.Consultar() == null)
            //{

            //}
            //else
            //{
            //    foreach (var item in gestionIrregulares.Consultar())
            //    {
            //        gridViewClientes.Rows.Add(item.Categori,
            //                                  item.Nombre,
            //                                  item.Telefono,
            //                                  item.Correo,
            //                                  item.UltimaVisita,
            //                                  item.Cumpleaños,
            //                                  item.Regreso(item.UltimaVisita));
            //    }
            //}
            //if (gestionMantenimiento.Consultar() == null)
            //{

            //}
            //else
            //{
            //    foreach (var item in gestionMantenimiento.Consultar())
            //    {
            //        gridViewClientes.Rows.Add(item.Categori,
            //                                  item.Nombre,
            //                                  item.Telefono,
            //                                  item.Correo,
            //                                  item.UltimaVisita,
            //                                  item.Cumpleaños,
            //                                  item.Regreso(item.UltimaVisita));
            //    }
            //}
            //if (gestionTrabajoColor.Consultar() == null)
            //{

            //}
            //else
            //{
            //    foreach (var item in gestionTrabajoColor.Consultar())
            //    {
            //        gridViewClientes.Rows.Add(item.Categori,
            //                                  item.Nombre,
            //                                  item.Telefono,
            //                                  item.Correo,
            //                                  item.UltimaVisita,
            //                                  item.Cumpleaños,
            //                                  item.Regreso(item.UltimaVisita));
            //    }
            //}
            var listaGrid = (from alisado in gestionAlisados.Consultar()
                             select new
                             {
                                 Categoria = alisado.Categori,
                                 Nombre = alisado.Nombre,
                                 Telefono = alisado.Telefono.ToString(),
                                 Correo = alisado.Correo,
                                 UltimaVisita = alisado.UltimaVisita.ToString(),
                                 Cumpleaños = alisado.Cumpleaños.ToString(),
                                 Regreso = alisado.Regreso(alisado.UltimaVisita)
                             })
                             .Concat(from irregulares in gestionIrregulares.Consultar()
                                     select new
                                     {
                                         Categoria = irregulares.Categori,
                                         Nombre = irregulares.Nombre,
                                         Telefono = irregulares.Telefono.ToString(),
                                         Correo = irregulares.Correo,
                                         UltimaVisita = irregulares.UltimaVisita.ToString(),
                                         Cumpleaños = irregulares.Cumpleaños.ToString(),
                                         Regreso = irregulares.Regreso(irregulares.UltimaVisita)
                                     })
                                     .Concat(from mantenimiento in gestionMantenimiento.Consultar()
                                             select new
                                             {
                                                 Categoria = mantenimiento.Categori,
                                                 Nombre = mantenimiento.Nombre,
                                                 Telefono = mantenimiento.Telefono.ToString(),
                                                 Correo = mantenimiento.Correo,
                                                 UltimaVisita = mantenimiento.UltimaVisita.ToString(),
                                                 Cumpleaños = mantenimiento.Cumpleaños.ToString(),
                                                 Regreso = mantenimiento.Regreso(mantenimiento.UltimaVisita)
                                             })
                                             .Concat(from color in gestionTrabajoColor.Consultar()
                                                     select new
                                                     {
                                                         Categoria = color.Categori,
                                                         Nombre = color.Nombre,
                                                         Telefono = color.Telefono.ToString(),
                                                         Correo = color.Correo,
                                                         UltimaVisita = color.UltimaVisita.ToString(),
                                                         Cumpleaños = color.Cumpleaños.ToString(),
                                                         Regreso = color.Regreso(color.UltimaVisita)
                                                     });
            BindingSource bin = new BindingSource();
            bin.DataSource = listaGrid;
            gridViewClientes.DataSource = bin;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LlenarGridView();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {

        }
    }
}