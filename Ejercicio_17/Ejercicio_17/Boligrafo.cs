using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        //La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
        //en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
        //propiedades
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        #region
        //Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo
        //retornarán el valor del mismo).
        #endregion
        public ConsoleColor GetColor()
        {
            ConsoleColor retorno;
            retorno = this.color;
            return retorno;
        }
        public short GetTinta ()
        {
            short retorno;
            retorno = this.tinta;
            return retorno;
        }
        #region 
        //Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
        //i.tinta será el valor a agregar de tinta, pudiendo ser positivo(cargar tinta) o negativo(gastar tinta)
        //ii.Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
        //0 y menor o igual a cantidadTintaMaxima.
        #endregion
        private void SetTinta(short tinta)
        {
            if (tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
            else
                Console.WriteLine("El valor de la tinta supera el maximo permitido");
        }
        #region
        //Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
        #endregion
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }
        #region
        //El método Pintar(short, out string) restará la tinta gastada (reutilizar código SetTinta), sin
        //poder quedar el nivel en negativo, avisando si pudo pintar(nivel de tinta mayor a 0).
        //También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
        //tinta.O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***".
        #endregion
        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            float porcentaje = 0;

            if(gasto <= this.tinta)
            {
                porcentaje = ((float)gasto / this.tinta) * 10;
                this.tinta -= (short)gasto;
                retorno = true;
            }
            else
            {
                Console.WriteLine("Gasto mayor al porcentaje de tinta disponible");
            }
            dibujo = new string('*', (short)porcentaje);

            return retorno;
        }
        //constructor
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
    }
}
