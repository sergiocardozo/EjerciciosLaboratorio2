using BasesNumericas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            int entradaDecimal;
            string entradaBinario = "";


            Console.Write("Ingrese el numero decimal a convertir: ");
            int.TryParse(Console.ReadLine(), out entradaDecimal);

            Console.Write("Ingrese el numero binario a convertir: ");
            entradaBinario = Console.ReadLine();

            Console.WriteLine("Numero en binario: " + Conversor.DecimalBinario(entradaDecimal));
            Console.WriteLine("Numero en decimal: " + Conversor.BinarioDecimal(entradaBinario));
        }
    }
}