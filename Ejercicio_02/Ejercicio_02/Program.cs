using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";

            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while(numero < 0)
            {
                Console.WriteLine("Error, vuelva a ingresar el numero");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El cuadrado del numero ingresado es : {0}", Math.Pow(numero, 2));
            Console.WriteLine("El cubo del numero ingresado es : {0}", Math.Pow(numero, 3));
        }
    }
}
