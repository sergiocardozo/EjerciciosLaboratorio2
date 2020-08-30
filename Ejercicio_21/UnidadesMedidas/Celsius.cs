using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesMedidas
{
    public class Celsius
    {
        private double grados;

        public Celsius(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return this.grados;
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetGrados() - 32) * 5 / 9);
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return (Celsius)((Fahrenheit)k);
        }
    }
}
