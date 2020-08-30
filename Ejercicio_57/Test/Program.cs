using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Sergio", "Cardozo");
            Persona.Guardar(persona);
            Console.WriteLine(Persona.Leer().ToString());

            Console.ReadLine();
        }
    }
}
