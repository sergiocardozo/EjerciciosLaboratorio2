using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";

            int altura;
            int incremento = 0;

            Console.Write("Ingrese la altura que desea de la piramide: ");
            altura = Convert.ToInt32(Console.ReadLine());

            while(incremento <= altura)
            {
                incremento++;
                for(int i = 1; i < incremento; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
