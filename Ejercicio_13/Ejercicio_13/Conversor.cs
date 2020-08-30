using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesNumericas
{
    public class Conversor
    {
        static public string DecimalBinario(int inputDecimal)
        {
            string resto = "";
            
            while ((inputDecimal >= 2))
            {
                resto = inputDecimal % 2 + resto;
                inputDecimal /= 2;
            }
            return resto;
        }

        static public int BinarioDecimal(string inputBinario)
        {
            char[] array = inputBinario.ToCharArray();
            //invierte los valores van incrementadose de derecha a izquierda
            Array.Reverse(array);
            int suma = 0;

            for(int i=0;i<array.Length;i++)
            {
               if(array[i] == '1')
                {
                    //Usamos la potencia de 2, segun la posicion
                    suma += (int)Math.Pow(2, i);
                }
            }
            return suma;
        }
    }
}
