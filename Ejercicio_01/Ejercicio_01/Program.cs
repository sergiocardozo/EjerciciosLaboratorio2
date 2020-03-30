using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int numero;
            double acumulador = 0;
            double promedio = 0;
            int maximo = 0;
            int minimo = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + numero;

                if (i == 0 || numero > maximo)
                {
                    maximo = numero;
                }

                if (i == 0 || numero < minimo)
                {
                    minimo = numero;
                }

                promedio = acumulador / 5;

                Console.WriteLine("El numero minimo es {0}", minimo);
                Console.WriteLine("El numero maximo es {0}", maximo);
                Console.WriteLine("El promedio es {0}", promedio);

            }
        }
    }
}