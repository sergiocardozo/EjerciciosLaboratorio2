using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            #region
            //En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
            //de 100 y otro de tinta roja(ConsoleColor.Red) y 50 de tinta.
            #endregion
            Boligrafo boligrafoVerde = new Boligrafo(ConsoleColor.Green, 100);
            Boligrafo boligrafoAmarillo = new Boligrafo(ConsoleColor.Yellow, 60);

            string dibujo = "";
            short tinta;

            Console.ForegroundColor = boligrafoVerde.GetColor();
            Console.WriteLine("Boligrado Verde");

            boligrafoVerde.Pintar(101, out dibujo);
            Console.WriteLine(dibujo);

            boligrafoVerde.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);

            tinta = boligrafoVerde.GetTinta();
            Console.WriteLine("El nivel de tinta es: {0}", tinta);

            boligrafoVerde.Recargar();
            tinta = boligrafoVerde.GetTinta();
            Console.WriteLine("Nivel de tinta ahora es: {0}", tinta);

            Console.ForegroundColor = boligrafoAmarillo.GetColor();
            Console.WriteLine("Boligrafo Amarillo");

            boligrafoAmarillo.Pintar(101, out dibujo);
            Console.WriteLine(dibujo);

            boligrafoAmarillo.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);

            tinta = boligrafoAmarillo.GetTinta();
            Console.WriteLine("El nivel de tinta es: {0}", tinta);

            boligrafoAmarillo.Recargar();
            tinta = boligrafoAmarillo.GetTinta();
            Console.WriteLine("Nivel de tinta ahora es: {0}", tinta);
        }
    }
}
