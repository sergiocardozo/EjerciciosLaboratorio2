using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        //posee solo un constructor de instancia, sirve para inicializar los datos de la clase
        /// <summary>
        /// Inicializa un producto
        /// </summary>
        /// <param name="marca">Marca del producto</param>
        /// <param name="codigo">Codigo de barras del producto</param>
        /// <param name="precio">Precio del producto</param>
        public Producto(string marca, string codigo, float precio)
        {
            //guardo los 3 datos en los atributos usando this. para hacer referencia a la instancia en la que estamos parados
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        //getters no recibe parametros, devuelven el dato
        /// <summary>
        /// Getter de la marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// Getter del precio
        /// </summary>
        /// <returns></returns>
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Format("Producto marca {0}", p.marca));
            stringBuilder.AppendLine(String.Format("Producto codigo de barra {0}", p.codigoDeBarra));
            stringBuilder.AppendLine(String.Format("Producto precio {0}", p.precio));

            return stringBuilder.ToString();
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

    }
}
