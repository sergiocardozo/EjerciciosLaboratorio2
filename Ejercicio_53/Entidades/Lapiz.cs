using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamañoMina;
        public ConsoleColor Color 
        { 
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }
        public float UnidadesDeEscritura 
        {
            get { return tamañoMina; }
            set { tamañoMina = value; }
        }
        public Lapiz(int unidades)
        {
            this.tamañoMina = unidades;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Lapiz"));
            sb.AppendLine(string.Format($"Color de mina: {this.Color}"));
            sb.AppendLine(string.Format($"Nivel de tinta {this.UnidadesDeEscritura:0.##}"));
            return sb.ToString();
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.UnidadesDeEscritura -= (float)(0.1 * texto.Length);
            return new EscrituraWrapper(texto, this.Color);
        }
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
