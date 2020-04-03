using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public ValidarRespuesta()
        {
        }

        public static bool ValidaS_N(char c)
        {
            bool retorno = false;
            if(c == 's' || c == 'S')
            {
                retorno = true;
            }
            else if(c != 'n' || c != 'N')
            {
                Console.WriteLine("Opcion no valida");
                
            }
            return retorno;
        }
    }
}
