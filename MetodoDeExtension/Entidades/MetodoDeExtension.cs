using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoDeExtension
    {
        public enum Estaciones { Verano, Otoño, Invierno, Primavera }
        public static string ObtenerPlacaCronica(this DateTime fecha, Estaciones estacion)
        {
            string str;
            TimeSpan timeSpan = new TimeSpan();
            DateTime dateTime;
            switch (estacion)
            {
                case Estaciones.Verano:
                    dateTime = new DateTime(2020, 12, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
                case Estaciones.Otoño:
                    dateTime = new DateTime(2021, 3, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
                case Estaciones.Invierno:
                    dateTime = new DateTime(2020, 6, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
                case Estaciones.Primavera:
                    dateTime = new DateTime(2020, 9, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
                
            }
            str = string.Format($"Faltan {timeSpan.TotalDays} dias para el {estacion}");
            return str;
        }
    }
}
