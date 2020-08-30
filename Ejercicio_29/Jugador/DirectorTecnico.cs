using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento 
        {
            get { return fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        private DirectorTecnico(string nombre)
            : base(nombre)
        {
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.MostrarDatos()}"));
            sb.AppendLine(string.Format($"Fecha de nacimiento: {this.FechaNacimiento}"));
            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
