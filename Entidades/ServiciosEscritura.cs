﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ServiciosEscritura
    {

        public ServiciosEscritura()
        {

        }

        public ServiciosEscritura(int id, int vinculo, string nombre, int valor, int duracion, DateTime regreso)
        {
            Id = id;
            Vinculo = vinculo;
            Nombre = nombre;
            Valor = valor;
            Duracion = duracion; 
            Regreso = regreso;
        }

        public int Id { get; set; }
        public int Vinculo { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public int Duracion { get; set; }
        public DateTime Regreso { get; set; }

        public override string ToString()
        {
            return $"{Id};{Vinculo};{Nombre};{Valor};{Duracion}";
        }
    }
}
