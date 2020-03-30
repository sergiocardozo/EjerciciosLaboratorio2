using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";

            int inicioAño;
            int finAño;

            Console.Write("Ingrese inicio de año: ");
            inicioAño = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese año en el que finalizara: ");
            finAño = Convert.ToInt32(Console.ReadLine());

            for(int i = inicioAño;i <= finAño;i++)
            {
                if(i % 4 == 0)
                {
                    if(i % 100 != 0)
                    {
                        Console.WriteLine("El año {0} es bisiesto", i);
                    }
                    else
                    {
                        if(i % 400 == 0)
                        {
                            Console.WriteLine("El año {0} es bisiesto", i);
                        }
                    } 
                }    
            }
        }
    }
}
