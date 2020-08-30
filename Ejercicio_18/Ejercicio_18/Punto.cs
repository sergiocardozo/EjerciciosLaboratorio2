using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        #region
        //La clase Punto ha de tener dos atributos privados con acceso de sólo lectura (sólo con
        //getters), que serán las coordenadas del punto.También un constructor que reciba los parámetros x e y.
        #endregion
        private int x;
        private int y;

        //getters para acceder a los atributos privados 
        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
        //Constructor que recibe los parametro x e y
        public Punto (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

