using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoCarrera
    {
        private short Cilindrada;

        public short CaballosDeFuerza 
        { 
            get { return Cilindrada; }
            set { this.Cilindrada = value; }
        }
        public MotoCross(short numero, string escuderia) 
            : base(numero,escuderia)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada) 
            :this(numero,escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.ToString()}"));
            sb.AppendLine(string.Format($"Caballos de fuerza: {this.Cilindrada}"));
            return sb.ToString();
        }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return string.Equals(a1,a2) && a1.Cilindrada == a2.Cilindrada;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
