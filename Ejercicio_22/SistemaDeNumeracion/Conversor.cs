using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNumeracion
{
    public class Conversor
    {
        /*static public string DecimalBinario(int inputDecimal)
        {
            string resto = "";
            
            while ((inputDecimal >= 2))
            {
                resto = inputDecimal % 2 + resto;
                inputDecimal /= 2;
            }
            return resto;
        }*/
        static public string DecimalBinario(double inputDecimal)
        {
            string outputBinario = "";
            int resto;
            int cociente = (int)inputDecimal;
            double parteDecimal = inputDecimal - cociente;

            while (cociente >= 2)
            {
                resto = cociente % 2;
                cociente /= 2;
                outputBinario = string.Concat(resto, outputBinario);    //resto.ToString()+binarioOutput;
            }
            outputBinario = string.Concat(cociente, outputBinario);
            for (int i = 0; i < 4 && parteDecimal > 0; i++)
            {
                if (parteDecimal * 2 >= 1)
                    outputBinario = string.Concat(outputBinario, "1");
                else
                    outputBinario = string.Concat(outputBinario, "0");
            }

            return outputBinario;
        }

        /*static public double BinarioDecimal(string inputBinario)
        {
            char[] array = inputBinario.ToCharArray();
            //invierte los valores van incrementadose de derecha a izquierda
            Array.Reverse(array);
            double suma = 0;

            for(int i=0;i<array.Length;i++)
            {
               if(array[i] == '1')
                {
                    //Usamos la potencia de 2, segun la posicion
                    suma += (int)Math.Pow(2, i);
                }
            }
            return suma;
        }*/
        static public double BinarioDecimal(string inputBinario)
        {
            double outputDecimal = 0;
            char[] array = inputBinario.ToCharArray();
            Array.Reverse(array);

            for (int i = 0; i < inputBinario.Length; i++)
            {
                outputDecimal += (char.GetNumericValue(array[i]) * Math.Pow(2, i));
            }

            return outputDecimal;
        }
    }
}
