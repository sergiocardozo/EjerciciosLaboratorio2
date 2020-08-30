using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        public List<IAcciones> cartuchera;

        public Cartuchera1()
        {
            cartuchera = new List<IAcciones>();
        }
        public bool ProbarElementos()
        {
            foreach (IAcciones item in cartuchera)
            {
                item.Escribir("1");
                if(item.UnidadesDeEscritura <= 0 && item.GetType() == typeof(Boligrafo))
                {
                    if (item.UnidadesDeEscritura < 0)
                        return false;
                    item.Recargar(1);
                }
            }
            return true;
        }
    }
}
