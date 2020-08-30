using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
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

        public int Dni
        {
            get { return dni; }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        //public float GetPromedioGoles()
        //{
        //    return promedioGoles = (float)totalGoles / (float)partidosJugados;
        //}
        private Jugador()
        {
            //this.partidosJugados = 0;
            //PromedioGoles = 0;
            //this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
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
            sb.AppendLine(string.Format($"{this.nombre}"));
            sb.AppendLine(string.Format($"{this.dni}"));
            sb.AppendLine(string.Format($"Partidos jugados {this.partidosJugados}"));
            sb.AppendLine(string.Format($"Total goles {this.totalGoles}"));
            sb.AppendLine(string.Format($"Promedio goles {(float)this.PromedioGoles}"));
            return sb.ToString();
        }
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.dni == jugador2.dni;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
