using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados { get { return partidosJugados; } }
        public float PromedioGoles
        {
            get
            {
                if (partidosJugados == 0)
                    return 0;
                else
                    return TotalGoles / PartidosJugados;
            }
        }
        public int TotalGoles { get { return totalGoles; } }

        public Jugador(int dni, string nombre)
            : base(dni, nombre)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.ToString()}"));
            sb.AppendLine(string.Format($"Partidos jugados {this.partidosJugados}"));
            sb.AppendLine(string.Format($"Total goles {this.totalGoles}"));
            sb.AppendLine(string.Format($"Promedio goles {(float)this.PromedioGoles}"));
            return sb.ToString();
        }
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.Dni == jugador2.Dni;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
