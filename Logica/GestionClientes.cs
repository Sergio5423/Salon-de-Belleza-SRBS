using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Datos;
using Entidades;
using System.IO;

namespace Logica
{
    public class GestionClientes : IOperaciones<Clientes>
    {        
        RepositorioClientes repositorioClientes = new RepositorioClientes();
        List<Clientes> listaClientes = null;

        public GestionClientes()
        {
            listaClientes = new List<Clientes>();
        }

        public void Agregar(Clientes cliente)
        {
            repositorioClientes.Agregar(cliente);
        }

        public void Borrar(int id)
        {
            repositorioClientes.Borrar(id);
        }

        public void Actualizar(Clientes cliente)
        {
            repositorioClientes.Actualizar(cliente);
        }

        public List<Clientes> Filtrar(string nombre)
        {
            return repositorioClientes.Filtrar(nombre);
        }

        public Clientes ConsultarUno(int id)
        {
            foreach (var cliente in repositorioClientes.Consultar())
            {
                if (cliente.Id == id)
                {
                    return cliente;
                }
            }
            return null;
        }

        public List<Clientes> ConsultarTodos()
        {
            return repositorioClientes.Consultar();
        }

        public void CrearPdfListaClientes(string nombrePDF)
        {
            Font font = new iTextSharp.text.Font(0);
            Document document = new Document();

            PdfWriter.GetInstance(document,
            new FileStream(nombrePDF + ".pdf",
            FileMode.OpenOrCreate));

            Chunk chunkTitulo = new Chunk("Lista de Clientes" + "\n" + "\n",
                FontFactory.GetFont("CAMBRIA", 12,
                iTextSharp.text.Font.BOLD));

            Chunk chunkFecha = new Chunk("\nFecha del Reporte: " + DateTime.Now.ToShortDateString() + "\n",
                FontFactory.GetFont("CAMBRIA", 9,
                iTextSharp.text.Font.BOLD));

            var parafTitulo = new Paragraph(chunkTitulo);
            parafTitulo.Alignment = 1;

            var paraFecha = new Paragraph(chunkFecha);
            paraFecha.Alignment = 0;

            PdfPTable tabla = new PdfPTable(5);
            tabla.WidthPercentage = 90;
            tabla.SetWidths(new int[] { 12, 12, 12, 15, 10 });

            tabla.AddCell(new Phrase("Nombre", FontFactory.GetFont("CAMBRIA", 10,
                iTextSharp.text.Font.BOLD)));
            tabla.AddCell(new Phrase("Telefono", FontFactory.GetFont("CAMBRIA", 10,
                iTextSharp.text.Font.BOLD)));
            tabla.AddCell(new Phrase("Cumpleaños", FontFactory.GetFont("CAMBRIA", 10,
                iTextSharp.text.Font.BOLD)));
            tabla.AddCell(new Phrase("Ultima Visita", FontFactory.GetFont("CAMBRIA", 10,
                iTextSharp.text.Font.BOLD)));
            tabla.AddCell(new Phrase("Estilista", FontFactory.GetFont("CAMBRIA", 10,
                iTextSharp.text.Font.BOLD)));

            foreach (var cliente in ConsultarTodos())
            {
                tabla.AddCell(new Phrase(cliente.Nombre, font));
                tabla.AddCell(new Phrase(cliente.Telefono, font));
                tabla.AddCell(new Phrase(cliente.Cumpleaños.ToShortDateString(), font));
                tabla.AddCell(new Phrase(cliente.UltimaVisita.ToShortDateString(), font));
                tabla.AddCell(new Phrase(cliente.EstilistaFavorito, font));
            }

            document.Open();
            document.Add(parafTitulo);
            document.Add(tabla);
            document.Add(paraFecha);
            document.Close();

        }
    }
}
