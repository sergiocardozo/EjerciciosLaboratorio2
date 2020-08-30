using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        public static int Decreciente(int x, int y)
        {
            if (x > y)
                return -1;
            else if (x < y)
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";
            //Pilas, colas y listas
            Random random = new Random();
            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> cola = new Queue<int>();

            int aleatorio;

            for (int i = 0; i < 20; i++)
            {
                do
                {
                    aleatorio = random.Next(-100, 100);
                } while (aleatorio == 0);
                lista.Add(aleatorio);
                pila.Push(aleatorio);
                cola.Enqueue(aleatorio);
            }
            Console.WriteLine("nListas");
            foreach (int elemento in lista)
            {
                Console.Write("{0}", elemento);
            }

            Console.WriteLine("positivos");
            lista.Sort(Decreciente);
            foreach (int elemento in lista)
            {
                if (elemento < 0)
                    break;
                Console.WriteLine("{0}", elemento);
            }
            Console.WriteLine("\nNegativos");
            lista.Sort();
            foreach (int elemento in lista)
            {
                if (elemento > 0)
                    break;
                Console.WriteLine("{0}", elemento);
            }

            //////////STACK/////////////////////
            Console.WriteLine("STACK");
            foreach (int elemento in pila)
            {
                Console.WriteLine("{0}", elemento);
            }
            List<int> lista2 = new List<int>(pila.ToList());

            Console.WriteLine("\nPositivos");
            lista2.Sort(Decreciente);
            foreach (int elemento in lista2)
            {
                if (elemento < 0)
                    break;
                Console.Write("{0}", elemento);
            }

            Console.WriteLine("\nNegativos");
            lista2.Sort();
            foreach (int elemento in lista2)
            {
                if (elemento > 0)
                    break;
                Console.Write("{0} ", elemento);
            }

            ///////////////////////////////////////////
            Console.WriteLine("\nQueue");
            foreach (int elemento in cola)
            {
                Console.Write("{0} ", elemento);
            }
            lista2 = cola.ToList();
            Console.WriteLine("\nPositivos");
            lista2.Sort(Decreciente);
            foreach (int elemento in lista2)
            {
                if (elemento < 0)
                    break;
                Console.Write("{0} ", elemento);
            }
            Console.WriteLine("\nNegativos");
            lista2.Sort();
            foreach (int elemento in lista2)
            {
                if (elemento > 0)
                    break;
                Console.Write("{0} ", elemento);
            }

            Console.ReadKey();


        }

    }
}
