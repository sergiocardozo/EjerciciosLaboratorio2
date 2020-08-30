using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTodas { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return listaDeLlamadas; } }
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulado = 0;
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is Local)
                        acumulado += ((Local)llamada).CostoLlamada;
                }
                if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is Provincial)
                        acumulado += ((Provincial)llamada).CostoLlamada;
                }
            }
            return acumulado;
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Razon Social: {this.razonSocial}"));
            sb.AppendLine(string.Format($"Ganancia Total: {this.GananciasPorTodas:C2}"));
            sb.AppendLine(string.Format($"Ganancia Local: {this.GananciasPorLocal:C2}"));
            sb.AppendLine(string.Format($"Ganancia Provincial: {this.GananciasPorProvincial:C2}"));
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                    sb.AppendLine(((Local)llamada).Mostrar());
                else if (llamada is Provincial)
                    sb.AppendLine(((Provincial)llamada).Mostrar());
            }
            return sb.ToString();
        }
    }
}