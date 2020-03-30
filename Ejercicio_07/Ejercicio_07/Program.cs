using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";

            DateTime fecha = new DateTime();
            TimeSpan dias;

            Console.WriteLine("Ingresar fecha de nacimiento");
            fecha = DateTime.Parse(Console.ReadLine());
            dias = DateTime.Now - fecha;

            Console.WriteLine("Dias vividos desde {0:dd/mm/yy}: {1} dias", fecha, dias.Days);

        }
    }
}
