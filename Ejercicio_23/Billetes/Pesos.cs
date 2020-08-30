using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 64.62f;
        }
        
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static void SetCotizacion(double cotizacion)
        {
            cotizRespectoDolar = cotizacion;
        }
        //conversiones
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }
        //OPERACIONES
        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).cantidad);
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).cantidad);
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).cantidad);
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).cantidad);
        }
        //COMPARACIONES
        public static bool operator !=(Pesos p, Dolar d)
        {
            return p != d;
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == d;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return p != e;
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p == e;
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return p1 != p2;
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }
    }
}
