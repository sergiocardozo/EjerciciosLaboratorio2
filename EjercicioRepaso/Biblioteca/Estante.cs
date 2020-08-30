using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;            
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("Estante ubicacion {0}",e.ubicacionEstante));
            stringBuilder.AppendLine("Productos del estante: ");

            for (int i = 0; i < e.productos.Length; i++)
            {
                stringBuilder.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }
            return stringBuilder.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            return 
        }
        public static bool operator !=(Estante e, Producto p)
        {

        }
        public static Estante operator +(Estante e, Producto p)
        {

        }
        public static Estante operator -(Estante e, Producto p)
        {

        }
    }
}
