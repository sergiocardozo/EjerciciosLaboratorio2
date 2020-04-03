using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno alumno = new Alumno("Sergio", "Cardozo", 9);
            Alumno alumno1 = new Alumno("Roberto", "Carlos", 6);
            Alumno alumno2 = new Alumno("Lionel", "Messi", 10);

            alumno.Estudiar(10, 9);
            alumno1.Estudiar(3, 7);
            alumno2.Estudiar(2, 10);
            alumno.CalcularFinal();
            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno.Mostrar();
            alumno1.Mostrar();
            alumno2.Mostrar();
        }
    }
}
