using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Program
    {
        GestionAlisados gestionAlisados = new GestionAlisados();
        GestionColor gestionColor = new GestionColor();
        int d, m, a, cat;
        int i = 1;        

        static void Main(string[] args)
        {
            //GestionAlisados gestionClientes = new GestionAlisados();
            
            var program = new Program();            
            //gestionClientes.Agregar(new Alisados(1, "Persona1", 3005314328, "Persona1@gmail.com", new DateTime(2023, 1, 29), new DateTime(1993, 2, 24)));
            //gestionClientes.Agregar(new Alisados(2, "Persona2", 3005314328, "Persona1@gmail.com", new DateTime(2023, 1, 29), new DateTime(1993, 2, 24)));
            program.CapturarDatos();
            program.ConsultarDatos();
            Console.ReadKey();
        }

        public void CapturarDatos()
        {
            
            Console.WriteLine("Categoría para Cliente");
            Console.WriteLine("1. Alisados");
            Console.WriteLine("2. Color");
            cat = int.Parse(Console.ReadLine());
            switch (cat)
            {
                case 1:
                    var alisados = new Alisados();

                    Console.Clear();
                    Console.WriteLine("DATOS DE CLIENTES CON ALISADO");
                    alisados.Id = i;
                    Console.WriteLine("Nombre: ");
                    alisados.Nombre = Console.ReadLine();
                    Console.WriteLine("Telefono: ");
                    alisados.Telefono = int.Parse(Console.ReadLine());
                    Console.WriteLine("Correo: ");
                    alisados.Correo = Console.ReadLine();
                    Console.WriteLine("Ultima Visita");
                    Console.WriteLine("Dia: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mes: ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Año: ");
                    a = int.Parse(Console.ReadLine());
                    alisados.UltimaVisita = new DateTime(a, m, d);
                    Console.WriteLine("Fecha de cumpleaños");
                    Console.WriteLine("Dia: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mes: ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Año: ");
                    a = int.Parse(Console.ReadLine());
                    alisados.Cumpleaños = new DateTime(a, m, d);
                    Console.Clear();
                    gestionAlisados.Agregar(alisados);
                    break;

                case 2:
                    var color = new Color();

                    Console.Clear();
                    Console.WriteLine("DATOS DE CLIENTES CON ALISADO");
                    color.Id = i;
                    Console.WriteLine("Nombre: ");
                    color.Nombre = Console.ReadLine();
                    Console.WriteLine("Telefono: ");
                    color.Telefono = int.Parse(Console.ReadLine());
                    Console.WriteLine("Correo: ");
                    color.Correo = Console.ReadLine();
                    Console.WriteLine("Ultima Visita");
                    Console.WriteLine("Dia: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mes: ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Año: ");
                    a = int.Parse(Console.ReadLine());
                    color.UltimaVisita = new DateTime(a, m, d);
                    Console.WriteLine("Fecha de cumpleaños");
                    Console.WriteLine("Dia: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mes: ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Año: ");
                    a = int.Parse(Console.ReadLine());
                    color.Cumpleaños = new DateTime(a, m, d);
                    Console.Clear();                    
                    gestionColor.Agregar(color);
                    break;
            }
            
            i++;            
        }

        public void ConsultarDatos()
        {
            int i = 2;

            Console.Clear();
            Console.SetCursorPosition(20, 9); Console.Write("Lista Total de Clientes");
            foreach (var cliente in gestionAlisados.Consultar())
            {
                Console.SetCursorPosition(20, 9 + i); Console.Write(cliente.Id);
                Console.SetCursorPosition(25, 9 + i); Console.Write(cliente.Nombre);
                Console.SetCursorPosition(40, 9 + i); Console.Write(cliente.Telefono);
                Console.SetCursorPosition(55, 9 + i); Console.Write(cliente.Correo);
                Console.SetCursorPosition(65, 9 + i); Console.Write(cliente.UltimaVisita.ToShortDateString());
                Console.SetCursorPosition(75, 9 + i); Console.Write(cliente.Cumpleaños.ToShortDateString());
                i++;
            }
            foreach (var cliente in gestionColor.Consultar())
            {
                Console.SetCursorPosition(20, 9 + i); Console.Write(cliente.Id);
                Console.SetCursorPosition(25, 9 + i); Console.Write(cliente.Nombre);
                Console.SetCursorPosition(40, 9 + i); Console.Write(cliente.Telefono);
                Console.SetCursorPosition(55, 9 + i); Console.Write(cliente.Correo);
                Console.SetCursorPosition(65, 9 + i); Console.Write(cliente.UltimaVisita.ToShortDateString());
                Console.SetCursorPosition(75, 9 + i); Console.Write(cliente.Cumpleaños.ToShortDateString());
                i++;
            }
        }
    }
}
