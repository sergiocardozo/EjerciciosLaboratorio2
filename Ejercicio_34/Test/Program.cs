using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Rojo, 5, 2);

            Console.WriteLine(moto.ToString());

            Console.ReadKey();
        }
    }
}
