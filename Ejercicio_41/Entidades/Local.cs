using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada { get { return CalcularCosto(); } }
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.Mostrar()}"));
            sb.AppendLine(string.Format($"Costo de la llamada: {this.CostoLlamada:C}"));
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;
            return false;
        }
    }
}
