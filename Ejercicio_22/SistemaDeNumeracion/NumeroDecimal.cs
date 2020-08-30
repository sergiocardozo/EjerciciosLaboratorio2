using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNumeracion
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public double GetNumero()
        {
            return this.numero;
        }

        public static double operator +(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return numDecimal + numBinario;
        }
        public static double operator -(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return numDecimal - numBinario;
        }
        public static bool operator ==(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return numDecimal == numBinario;
        }
        public static bool operator !=(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return !(numDecimal == numBinario);
        }
        public static explicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }
        public static implicit operator NumeroDecimal(double d)
        {
            NumeroDecimal retorno = new NumeroDecimal(d);
            return retorno;
        }
    }
}
