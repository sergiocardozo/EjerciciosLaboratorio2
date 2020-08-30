using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoTerrestre
    {
        public enum Colores { Rojo, Blanco, Azul, Gris, Negro }

        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas,short cantidadPuertas, Colores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}
