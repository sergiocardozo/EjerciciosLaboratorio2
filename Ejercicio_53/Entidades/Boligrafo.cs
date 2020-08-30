using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color 
        {
            get { return colorTinta; }
            set { this.colorTinta = value; }
        }
        public float UnidadesDeEscritura 
        { 
            get { return this.tinta; }
            set { this.tinta = value; }
        }
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Boligrafo"));
            sb.AppendLine(string.Format($"Color de Tinta: {this.Color}"));
            sb.AppendLine(string.Format($"Nivel de tinta: {this.UnidadesDeEscritura:0.##}"));
            return sb.ToString();
        }
        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= (float)(0.3 * texto.Length);
            return new EscrituraWrapper(texto, this.Color);
        }
        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }
    }
}
