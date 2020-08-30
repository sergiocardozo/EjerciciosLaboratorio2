using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador prueba = new Sumador();
            Console.WriteLine(prueba.Sumar("a", "b"));

            Sumador prueba1 = new Sumador(1);
            Console.WriteLine("{0}", prueba + prueba1);
            Console.WriteLine("{0}", prueba | prueba1);

            Console.WriteLine(prueba.Sumar(1, 2));
            Console.WriteLine("{0}", prueba | prueba1);

            Console.WriteLine("{0}", (int)prueba);

            Console.ReadKey();
        }
    }
}
