using System;
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
            AutoF1 a1 = new AutoF1(54, "Ford");
            AutoF1 a2 = new AutoF1(100, "Renault");

            Competencia competencia = new Competencia(50, 2);

            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
