using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private long dni;
        private string nombre;

        public long Dni 
        { 
            get { return dni; }
            set { this.dni = value; }
        }
        public string Nombre 
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre)
            :this(nombre)
        {
            this.dni = dni;
        }
        public string MostrarDatos()
        {

        }
    }
}
