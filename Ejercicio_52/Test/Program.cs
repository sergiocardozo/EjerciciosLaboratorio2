﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleColor colorOriginal = Console.ForegroundColor;
            IAcciones miLapiz = new Lapiz(10); //Tipo de la interfaz
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);

            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            Console.ReadKey();
        }
    }
}
