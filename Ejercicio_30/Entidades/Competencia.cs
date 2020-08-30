using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Cantidad Competidores {this.cantidadCompetidores}"));
            sb.AppendLine(string.Format($"Cantidad Vueltas: {this.cantidadVueltas}"));
            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(string.Format(item.MostrarDatos()));
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count() < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                Random vueltas = new Random();
                a.CantidadCombustible = (short)vueltas.Next(15, 100);
                return true;
            }
            else
                return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            return c.competidores.Remove(a);
        }
    }
}
