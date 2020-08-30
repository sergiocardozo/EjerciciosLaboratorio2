using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;
        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }
        
    }
}
