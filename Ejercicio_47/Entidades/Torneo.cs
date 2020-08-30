using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;
        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{this.nombre}"));
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T e1, T e2)
        {
            Random random = new Random();
            int resultado1 = random.Next(0, 100);
            int resultado2 = random.Next(0, 100);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"[{e1.nombre}] [{resultado1}] [{resultado2}] [{e2.nombre}]"));
            return sb.ToString();
        }
        public string JugarPartido()
        {
            Random random = new Random();
            T equipo1 = this.equipos[random.Next(this.equipos.Count)];
            T equipo2 = this.equipos[random.Next(this.equipos.Count)];

            return this.CalcularPartido(equipo1, equipo2);
        }
    }
}
