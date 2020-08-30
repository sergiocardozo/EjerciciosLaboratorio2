using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible 
        {
            get { return cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }
        public short VueltasRestantes 
        {
            get { return vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }
        public bool EnCompetencia 
        {
            get { return enCompetencia; }
            set { this.enCompetencia = value; }
        }
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Escuderia: {this.escuderia}"));
            sb.AppendLine(string.Format($"Numero: {this.numero}"));
            sb.AppendLine(string.Format($"Cantidad Combustible: {this.CantidadCombustible}"));
            sb.AppendLine(string.Format($"Vueltas Restantes: {this.VueltasRestantes}"));
            sb.AppendLine(string.Format($"En Competencia: {this.EnCompetencia}"));
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia && a1.numero == a2.numero;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
