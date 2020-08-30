using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private string nombre;
        private string fotoAlumno;
        private int dni;

        public string Apellido 
        {
            get { return apellido; }
            set { apellido = value; } 
        }
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string RutaDeLaFoto 
        {
            get { return fotoAlumno; }
            set { fotoAlumno = value; }
        }
        public int Dni 
        {
            get { return dni; }
            set { dni = value; }
        }
        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.fotoAlumno = ruta;
        }
    }
}
