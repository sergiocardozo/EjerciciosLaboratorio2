using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
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
        public Persona(long dni, string nombre)
            : this(nombre)
        {
            this.dni = dni;
        }
        public Persona(string nombre) 
        {
            this.nombre = nombre;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Nombre : {this.Nombre}"));
            sb.AppendLine(string.Format($"Dni : {this.Dni}"));
            return sb.ToString();
        }
    }
}
