using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        #region Conversiones
        public static implicit operator NumeroDecimal()
        #endregion

        #region Sobrecargas

        #endregion
    }
}
