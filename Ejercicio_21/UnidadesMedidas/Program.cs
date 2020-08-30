using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius(30);
            Fahrenheit f = new Fahrenheit(30);
            Kelvin k = new Kelvin(30);

            Console.WriteLine("son {0} grados celsius", c.GetGrados());
            Console.WriteLine("son {0} grados fahrenheit", f.GetGrados());
            Console.WriteLine("son {0} grados kelvin", k.GetGrados());
        }
    }
}
