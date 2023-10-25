﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Logica
{
    public class GestionServicios : GestorFuentes, IOperaciones<Servicios>
    {        
        RepositorioServicios repositorioServicios = new RepositorioServicios();
        Clientes clienteServicio;
        int Vinculo;

        public GestionServicios()
        {
            clienteServicio = new Clientes();
        }

        public void SetCliente(Clientes cliente)
        {
            clienteServicio = cliente;
        }

        public void Agregar(Servicios servicio)
        {
            //if (servicio.Nombre == "Alisado Permanente")
            //    servicio.Regreso = CalcularRegresoMeses(servicio.Duracion);
            //if (servicio.Nombre == "Diseño de Color")
            //    servicio.Regreso = CalcularRegresoMeses(servicio.Duracion);
            //if (servicio.Nombre == "Mantenimiento de Químicos")
            //    servicio.Regreso = CalcularRegresoDias(servicio.Duracion);
            //if (servicio.Nombre == "Restauración Capilar")
            //    servicio.Regreso = CalcularRegresoDias(servicio.Duracion);
            //if (servicio.Nombre == "Blower")
            //    servicio.Regreso = CalcularRegresoDias(servicio.Duracion);
            repositorioServicios.Agregar(servicio);
        }

        public void Borrar(string id)
        {
            repositorioServicios.Borrar(id);
        }

        public void Actualizar(string cod, Servicios servicio)
        {
            repositorioServicios.Actualizar(cod, servicio);
        }

        //public List<Servicios> Filtrar(string nombre, int vinculo)
        //{
        //    return repositorioServicios.Filtrar(nombre, vinculo);
        //}

        public List<Servicios> Consultar()
        {
            return repositorioServicios.Consultar();
        }

        //public DateTime CalcularRegresoMeses(int Duracion)
        //{            
        //    DateTime Regreso = clienteServicio.UltimaVisita.AddMonths(Duracion);            
        //    return Regreso;
        //}

        //public DateTime CalcularRegresoDias(int Duracion)
        //{
        //    DateTime Regreso = clienteServicio.UltimaVisita.AddDays(Duracion);
        //    return Regreso;
        //}

        //public void CrearPdfEmpleados(string nombreCliente,string nombrePDF)
        //{
        //    Font font = new iTextSharp.text.Font(0);
        //    Document document = new Document();

        //    PdfWriter.GetInstance(document,
        //    new FileStream(nombrePDF + ".pdf",
        //    FileMode.OpenOrCreate));

        //    Chunk chunkTitulo = new Chunk("Lista de Servicios" + "\n" + "\n",
        //        FontFactory.GetFont(GetTimes(), 14,
        //        5));

        //    Chunk chunkNombre = new Chunk($"Cliente: {nombreCliente}" + "\n" + "\n",
        //        FontFactory.GetFont(GetTimes(), 12));

        //    Chunk chunkFecha = new Chunk("\nFecha del Reporte: " + DateTime.Now.ToShortDateString() + "\n",
        //        FontFactory.GetFont(GetTimes(), 10,
        //        iTextSharp.text.Font.BOLD));

        //    var parafTitulo = new Paragraph(chunkTitulo);
        //    parafTitulo.Alignment = 1;

        //    var parafNombre = new Paragraph(chunkNombre);
        //    parafTitulo.Alignment = 0;

        //    var paraFecha = new Paragraph(chunkFecha);
        //    paraFecha.Alignment = 0;

        //    PdfPTable tabla = new PdfPTable(4);
        //    tabla.WidthPercentage = 90;
        //    tabla.SetWidths(new int[] { 12, 12, 12, 15});

        //    tabla.AddCell(new Phrase("Nombre", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));
        //    tabla.AddCell(new Phrase("Valor", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));
        //    tabla.AddCell(new Phrase("Duración", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));
        //    tabla.AddCell(new Phrase("Regreso", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));

        //    foreach (var empleado in Consultar(Vinculo))
        //    {
        //        tabla.AddCell(new Phrase(empleado.Nombre, font));
        //        tabla.AddCell(new Phrase(empleado.Valor.ToString(), font));
        //        tabla.AddCell(new Phrase(empleado.Duracion.ToString(), font));
        //        tabla.AddCell(new Phrase(empleado.Regreso.ToString(), font));
        //    }

        //    document.Open();
        //    document.Add(parafTitulo);
        //    document.Add(parafNombre);
        //    document.Add(tabla);
        //    document.Add(paraFecha);
        //    document.Close();
        //}
    }
}
