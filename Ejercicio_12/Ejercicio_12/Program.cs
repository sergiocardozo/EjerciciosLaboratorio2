using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            char respuesta = 'S';
            int input;

            do
            {
                Console.WriteLine("Numero a sumar: ");
                input = Convert.ToInt32(Console.ReadLine());

                acumulador += input;
                Console.WriteLine("¿Desea continuar? S/N : ");
                respuesta = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine("La suma es {0}", acumulador);
        }
    }
}
