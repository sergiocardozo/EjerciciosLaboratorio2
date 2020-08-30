using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
		public static void MetodoEstatico()
		{

			throw new DivideByZeroException("MiClase_DivideByZeroException");
		}
        public MiClase()
        {
			try
			{
				MiClase.MetodoEstatico();
			}
			catch (Exception b)
			{

				throw b;
			}
        }
		public MiClase(int i)
		{
			try
			{
				MiClase miClase = new MiClase();
			}
			catch (Exception b)
			{
				throw new UnaException("mensaje",b);
			}
		}
    }
}
