using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "SI";
            double numeroA;
            double numeroB;
            string operacion = "";

            do
            {
                Console.Clear();
                Console.Write("Ingrese el primer numero: ");
                numeroA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo numero: ");
                numeroB = Convert.ToDouble(Console.ReadLine());

                Console.Write("Elija que operacion desea realiza(+ , - , / , * ): ");
                operacion = Console.ReadLine();
                                
                switch (operacion)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma es {0}: ", Calculadora.Calcular(numeroA, numeroB, "+"));
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la resta es {0}: ", Calculadora.Calcular(numeroA, numeroB, "-"));
                        break;
                    case "/":
                        Console.WriteLine("El resultado de la division es {0}: ", Calculadora.Calcular(numeroA, numeroB, "/"));
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la multiplicacion es {0}: ", Calculadora.Calcular(numeroA, numeroB, "*"));
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada es incorrecta");
                        break;
                }
                Console.WriteLine("Desea Continuar S/N: ");
                continuar = Console.ReadLine();
            } while (continuar != "NO");
        }
    }
}
