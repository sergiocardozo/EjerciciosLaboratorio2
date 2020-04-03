using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        //propiedades
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        //constructores
        public Alumno (string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //metodos

        /// <summary>
        /// Cargo notas de los alumnos
        /// </summary>
        /// <param name="notaUno"></param>
        /// <param name="notaDos"></param>
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random buffer = new Random();
                this.notaFinal = buffer.Next(1, 11);
            }
            else
                this.notaFinal = -1;
        }

        public void Mostrar ()
        {
            Console.WriteLine("Nombre y apellido del alumno: {0} {1} | Legajo: {2}", this.nombre, this.apellido, this.legajo);
            Console.WriteLine("Nota 1: {0} | Nota 2: {1}", this.nota1, this.nota2);
            if (this.notaFinal != -1)
            {
                Console.WriteLine("Nota final: {0}", this.notaFinal);
            }
            else
                Console.WriteLine("Alumno desaprobado");
        }
    }
}
