using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            int opcion = 0;
            double numeroA;
            double numeroB;

            do
            {
                
                Console.WriteLine("1-Calcular el area de un cuadrado");
                Console.WriteLine("2-Calcular el area de un triangulo");
                Console.WriteLine("3-Calcular el area de un circulo");
                Console.WriteLine("INGRESE UNA OPCION: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.Write("Ingrese el lado del cuadrado: ");
                        numeroA = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El area del cuadrado es {0}: ", CalculoDeArea.CalcularCuadrado(numeroA));
                        break;
                    case 2:
                        Console.Write("Ingrese la base del triangulo: ");
                        numeroA = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ingrese la altura del triangulo: ");
                        numeroB = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El area del triangulo es {0}: ", CalculoDeArea.CalcularTriangulo(numeroA, numeroB));
                        break;
                    case 3:
                        Console.Write("Ingrese el radio del circulo: ");
                        numeroA = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El area del circulo es {0}: ", CalculoDeArea.CalcularCirculo(numeroA));
                        break;
                    default:
                        Console.WriteLine("Opcion ingresada incorrecta");
                        break;
                }

            } while (opcion != 4);

        }
    }
}
