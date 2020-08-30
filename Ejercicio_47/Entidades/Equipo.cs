using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.fechaCreacion = DateTime.Today;
        }
        public static bool operator == (Equipo equipo1, Equipo equipo2)
        {
            return equipo1.nombre == equipo2.nombre && DateTime.Equals(equipo1.fechaCreacion, equipo2.fechaCreacion);
        }
        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{this.nombre} Fundado el {this.fechaCreacion:dd/MM/yy}"));
            return sb.ToString();
        }

    }
}
