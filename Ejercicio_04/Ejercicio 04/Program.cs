using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";

            int acumulado = 0;
            int primosEncontrados;
            int i;
            int divisor;

            Console.WriteLine("Numeros perfectos");
            for (i = 1, primosEncontrados = 0; primosEncontrados < 4; i++, acumulado = 0)
            {
                for (divisor = 1; divisor < i; divisor++)
                {
                    if (i % divisor == 0)
                        acumulado += divisor;
                }
                if (acumulado == i)
                {
                    Console.WriteLine("{0}", i);
                    primosEncontrados++;
                }
            }
            if (primosEncontrados == 0)
                Console.WriteLine("No encontrados");
            
        }
    }
}
