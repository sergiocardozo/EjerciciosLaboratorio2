using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador(35840245,"Sergio",0,1);
            Jugador jugador1 = new Jugador(35804304, "Jose", 10, 2);
            Jugador jugador2 = new Jugador(32803304, "Jorge", 10, 5);

            Console.WriteLine(jugador.MostrarDatos());
            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());

            Console.ReadKey();
        }
    }
}
