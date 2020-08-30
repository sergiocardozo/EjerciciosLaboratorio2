using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente client)
        {
            Thread.Sleep(1000);
            return true;
        }
        public int NumeroActual
        {
            get { return ++numeroActual; }
        }
        public enum Puesto
        {
            caja1, caja2
        }


    }
}
