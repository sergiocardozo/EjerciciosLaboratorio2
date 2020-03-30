using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";

            float valorHora, añosAntiguedad, horaMes, totalHoras, totalAntiguedad, totalBruto, totalDescuento, totalNeto;
            string nombreEmpleado;

            Console.Write("Ingrese el valor de la hora del empleado: ");
            valorHora = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();
            Console.Write("Ingrese la antiguedad del empleado: ");
            añosAntiguedad = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
            horaMes = Convert.ToSingle(Console.ReadLine());

            totalHoras = valorHora * horaMes;
            totalAntiguedad = añosAntiguedad * 30;
            totalBruto = totalHoras + totalAntiguedad;
            totalDescuento = (float)(totalBruto * 1.13) - totalBruto;
            totalNeto = totalBruto - totalDescuento;


            Console.WriteLine("   Recibo de sueldo:" + "\n" +
                            "   -----------------" + "\n" +
                            "             Nombre: " + nombreEmpleado + "\n" +
                            "         Antiguedad: " + añosAntiguedad + "\n" +
                            "     Valor por hora: " + valorHora + "\n" +
                            " Total sueldo bruto: " + totalBruto + "\n" +
                            "         Descuentos: " + totalDescuento + "\n" +
                            "Valor neto a cobrar: " + totalNeto + "\n");
        }
    }
}
