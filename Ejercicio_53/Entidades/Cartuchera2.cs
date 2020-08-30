using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public Cartuchera2()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }
        public bool ProbarElementos()
        {
            foreach (Lapiz item in lapices)
            {
                ((IAcciones)item).Escribir("1");
            }
            foreach (Boligrafo item in boligrafos)
            {
                item.Escribir("1");
                if(item.UnidadesDeEscritura <= 0)
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
