﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class validacion
    {

        public static bool Validar(int valor, int min, int max)
        {
            bool ret = false;

            if(valor < max && valor > min)
            {
                ret = true;
            }

            return ret;
        }
    }
}
