using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorMin = 0;
            int valorMax = 0;
            int acumulador = 0;
            int valor;
            bool flag = false;

            for(int i = 0;i<10;i++)
            {
                Console.Write("Ingrese un numero entre -100 y 100: ");
                Int32.TryParse(Console.ReadLine(), out valor);

                if(validacion.Validar(valor,-100,100))
                {
                    if(!flag)
                    {
                        valorMin = valor;
                        valorMax = valor;
                        flag = true;
                    }
                    else
                    {
                        if(valor > valorMax)
                        {
                            valorMax = valor;
                        }    
                        if(valor < valorMin)
                        {
                            valorMin = valor;
                        }
                    }
                    acumulador += valor;

                }
            }
            Console.WriteLine("Valor minimo {0}, Valor maximo {1}, Promedio {2}", valorMin, valorMax, acumulador);
        }
    }
}
