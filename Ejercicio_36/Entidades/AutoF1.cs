using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza 
        { 
            get { return caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }
        public AutoF1(short numero, string escuderia) 
            : base(numero,escuderia)
        {

        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) 
            :this(numero,escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.ToString()}"));
            sb.AppendLine(string.Format($"Caballos de fuerza: {this.CaballosDeFuerza}"));
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return string.Equals(a1,a2) && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
