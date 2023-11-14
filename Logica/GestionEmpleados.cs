using DatosOracle;
using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionEmpleados : GestorFuentes, IOperaciones<Empleados>
    {
        RepositorioEnpleados repositorioEmpleados = new RepositorioEnpleados();
        List<Empleados> listaEmpleados = null;

        public GestionEmpleados()
        {
            listaEmpleados = new List<Empleados>();
        }

        public void Agregar(Empleados empleado)
        {
            repositorioEmpleados.Agregar(empleado);
        }

        public void Borrar(string cedula)
        {
            repositorioEmpleados.Borrar(cedula);
        }

        public void Actualizar(string ced, Empleados empleado)
        {
            repositorioEmpleados.Actualizar(ced, empleado);
        }

        //public List<Empleados> Filtrar(string nombre)
        //{
        //    return repositorioEmpleados.Filtrar(nombre);
        //}

        public List<Empleados> Consultar()
        {
            return repositorioEmpleados.Consultar();
        }

        //public int CalcularComision(int generado)
        //{
        //    return generado / 2;
        //}

        //public Empleados Buscar(int id)
        //{
        //    foreach (var empleado in repositorioEmpleados.Consultar())
        //    {
        //        if (empleado.Id == id)
        //        {
        //            return empleado;
        //        }
        //    }
        //    return null;
        //}

        //public void AgregarTrabajo(int id, int generado)
        //{
        //    Empleados empleado = Buscar(id);
        //    empleado.Generado = empleado.Generado + generado;
        //    empleado.Comision = empleado.Comision + CalcularComision(generado);
        //    repositorioEmpleados.AgregarTrabajo(empleado.Id,empleado.Generado,empleado.Comision);
        //}

        //public void CrearPdfEmpleados(string nombrePDF)
        //{
        //    Font font = new iTextSharp.text.Font(0);
        //    Document document = new Document();

        //    PdfWriter.GetInstance(document,
        //    new FileStream(nombrePDF + ".pdf",
        //    FileMode.OpenOrCreate));

        //    Chunk chunkTitulo = new Chunk("Lista de Empleados" + "\n" + "\n",
        //        FontFactory.GetFont(GetTimes(), 14,
        //        5));

        //    Chunk chunkFecha = new Chunk("\nFecha del Reporte: " + DateTime.Now.ToShortDateString() + "\n",
        //        FontFactory.GetFont(GetTimes(), 10,
        //        iTextSharp.text.Font.BOLD));

        //    var parafTitulo = new Paragraph(chunkTitulo);
        //    parafTitulo.Alignment = 1;

        //    var paraFecha = new Paragraph(chunkFecha);
        //    paraFecha.Alignment = 0;

        //    PdfPTable tabla = new PdfPTable(4);
        //    tabla.WidthPercentage = 90;
        //    tabla.SetWidths(new int[] { 12, 12, 12, 15});

        //    tabla.AddCell(new Phrase("Cédula", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));
        //    tabla.AddCell(new Phrase("Nombre", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));
        //    tabla.AddCell(new Phrase("Generado", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));
        //    tabla.AddCell(new Phrase("Comisión", FontFactory.GetFont("Cambria", 10,
        //        iTextSharp.text.Font.BOLD)));

        //    foreach (var empleado in Consultar())
        //    {
        //        tabla.AddCell(new Phrase(empleado.Ced, font));
        //        tabla.AddCell(new Phrase(empleado.Nombre, font));
        //        tabla.AddCell(new Phrase(empleado.Generado.ToString(), font));
        //        tabla.AddCell(new Phrase(empleado.Comision.ToString(), font));
        //    }

        //    document.Open();
        //    document.Add(parafTitulo);
        //    document.Add(tabla);
        //    document.Add(paraFecha);
        //    document.Close();
        //}
    }
}
