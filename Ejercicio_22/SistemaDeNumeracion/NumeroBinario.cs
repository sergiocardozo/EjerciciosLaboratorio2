using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNumeracion
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public string GetNumero()
        {
            return this.numero;
        }
        public static bool Validar(string b)
        {
            string caracteresPermitidos = "01";
            foreach (char caracter in b)
            {
                if (!caracteresPermitidos.Contains(caracter))
                    return false;
            }
            return true;
        }
        public static string operator +(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return numBinario + numDecimal;
        }
        public static string operator -(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return numBinario - numDecimal;
        }
        public static bool operator ==(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return numBinario == numDecimal;
        }
        public static bool operator !=(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return !(numBinario == numDecimal);
        }
        #region Conversiones
        public static explicit operator string(NumeroBinario b)
        {
            return b.numero;
        }
        public static implicit operator NumeroBinario(string b)
        {
            NumeroBinario retorno = new NumeroBinario(b);
            return retorno;
        }

        #endregion
    }
}
