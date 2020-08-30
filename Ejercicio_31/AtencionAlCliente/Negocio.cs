using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Cliente cliente
        {
            get { return this.clientes.Dequeue(); }
            set 
            {
                if (this != value)
                    this.clientes.Enqueue(value);
            }
        }
        public int ClientesPendientes
        {
            get { return this.clientes.Count(); }
        }
        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            foreach (Cliente client in negocio.clientes)
            {
                if (client == cliente)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }
        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            if(negocio != cliente)
            {
                negocio.clientes.Enqueue(cliente);
                return true;
            }
            return false;
        }
        public static bool operator ~(Negocio negocio)
        {
            return negocio.caja.Atender(negocio.cliente);
        }
    }
}
