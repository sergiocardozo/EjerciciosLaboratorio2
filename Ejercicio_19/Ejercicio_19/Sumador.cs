using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        //constructor
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador()
        {
            new Sumador(0);
        }

        //metodos con sobrecarga
        //        El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
        //siguiente lógica:
        //i.En el caso de Sumar(long, long) sumará los valores numéricos
        //ii.En el de Sumar(string, string) concatenará las cadenas de texto.
        public long Sumar (long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar (string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        //Conversion explicita
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long suma = s1.cantidadSumas + s2.cantidadSumas;
            return suma;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
                return true;
            else
                return false;
        }
    }
}
