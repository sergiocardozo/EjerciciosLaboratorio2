using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get; }
        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Duracion de la llamada: {this.Duracion}"));
            sb.AppendLine(string.Format($"Numero de Origen: {this.NroOrigen}"));
            sb.AppendLine(string.Format($"Numero de Destino: {this.NroDestino}"));
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.duracion)
                return 1;
            if (llamada1.Duracion == llamada2.duracion)
                return 0;
            else
                return -1;
        }
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
    }
}
