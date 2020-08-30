using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesMedidas
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return this.grados;
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetGrados() * (9 / 5) + 32);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.GetGrados() * 9 / 5 - 459.67);
        }
    }
}
