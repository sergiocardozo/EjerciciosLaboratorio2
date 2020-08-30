using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
			try
			{
				MiClase miClase = new MiClase(2);
			}
			catch (DivideByZeroException b)
			{
				throw new MiException("Mensaje2", b);
			}
        }
    }
}
