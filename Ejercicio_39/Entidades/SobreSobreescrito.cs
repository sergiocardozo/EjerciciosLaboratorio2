﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SobreSobreescrito : Sobreescrito
    {
        public override string MiPropiedad
        {
            get { return base.miAtributo; }
        }
        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
        public override string ToString()
        {
            return "Este es mi metodo sobreescrito";
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
