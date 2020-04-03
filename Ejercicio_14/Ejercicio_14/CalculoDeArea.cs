using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double area)
        {
            double resultado;

            return resultado = area * area;
        }

        public static double CalcularTriangulo(double aBase, double altura)
        {
            double resultado;

            return resultado = aBase * altura/2;
        }

        public static double CalcularCirculo(double area)
        {
            double resultado;

            return resultado = (area * area) * Math.PI;
        }
    }
}
