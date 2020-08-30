using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return nombreClase; }
        }
        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            :base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Excepcion en el metodo {this.NombreMetodo} en la clase {this.NombreClase}"));
            sb.AppendLine(string.Format($"{this.Message}"));
            Exception inner = this.InnerException;
            while (inner != null)
            {
                sb.AppendLine(inner.Message);
                inner = inner.InnerException;
            }
            return base.ToString();
        }
    }
}
