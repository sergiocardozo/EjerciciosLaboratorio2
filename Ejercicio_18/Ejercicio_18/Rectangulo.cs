using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        #region
        //b.La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4
        //(que corresponden a los cuatro vértices del rectángulo).
        #endregion
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        #region
        //c.La base de todos los rectángulos de esta clase será siempre horizontal.Por lo tanto, debe
        //tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el
        //método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
        //obtener la distancia entre puntos).
        #endregion
        public float Area()
        {
            if(this.area == 0)
            {
                float basE = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.area = basE * altura;
            }
            return this.area;
        }
        //e.Los atributos área(base * altura) y perímetro((base + altura)*2) se deberán calcular sólo
        //una vez, al llamar por primera vez a su correspondiente método getter.Luego se deberá
        //retornar siempre el mismo valor.
        public float Perimetro()
        {
            if(this.perimetro == 0)
            {
                float basE = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.perimetro = (basE + altura) * 2;
            }
            return this.perimetro;
        }
        //d.Realizar los métodos getters para los atributos privados área y perímetro.
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }
    }
}

