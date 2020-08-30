using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            foreach (Jugador item in equipo.jugadores)
            {
                if(!equipo.jugadores.Contains(item) && equipo.jugadores.Count <= equipo.cantidadDeJugadores )
                {
                    equipo.jugadores.Add(item);
                    return true;
                }
            }
            return false;
        }
    }
}
