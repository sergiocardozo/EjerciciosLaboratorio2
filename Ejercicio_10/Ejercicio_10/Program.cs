using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            //declaracion de variables
            int filas;
            //datos pasados por parametro
            Console.Write("Ingresar numero de filas: ");
            filas = Convert.ToInt32(Console.ReadLine());
            //bucle que itera a traves de cad fila de la piramide
            for(int i = 1; i <= filas; i++)
            {
                //bucle para generar los espacios antes del primer asterisco
                for(int j = i;j<=filas;j++)
                {
                    Console.Write("  ");
                }
                //bucle que genera el numero de asteriscos para cada fila 2*filaActual-1
                for(int k=1;k<=2*i-1;k++)
                {
                    Console.Write("*" + " ");
                }
                //para mover el cursor a la siguiente fila
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
