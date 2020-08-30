using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejericicio 18";

            Geometria.Punto punto1 = new Geometria.Punto(1, 4);
            Geometria.Punto punto2 = new Geometria.Punto(3, 5);

            Geometria.Rectangulo prueba = new Geometria.Rectangulo(punto1, punto2);
            Console.WriteLine("Area del rectangulo es: {0}", prueba.Area());
            Console.WriteLine("El perimetro es: {0}", prueba.Perimetro());
        }
    }
}
//En el espacio de nombres PruebaGeometria es donde se escribirá
//una clase con el método Main.
//f.Probar las funcionalidades de las clases Punto y Rectangulo.
//i.Generar un nuevo Rectangulo.
//ii.Imprimir por pantalla los valores de área y perímetro.
//g.Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como
//parámetro.