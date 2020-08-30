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
            int numero;
            string str = DateTime.Now.ObtenerPlacaCronica(MetodoDeExtension.Estaciones.Verano);
           
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
