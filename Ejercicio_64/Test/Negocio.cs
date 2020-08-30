using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1 { get { return caja1; } }
        public Caja Caja2 { get { return caja2; } }
        public List<string> Clientes { get { return clientes; } }

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }
        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas...");
            foreach (string cliente in this.clientes)
            {
                if (caja1.Filaclientes.Count < caja2.Filaclientes.Count)
                    this.caja1.Filaclientes.Add(cliente);
                else
                    this.caja2.Filaclientes.Add(cliente);
                Thread.Sleep(1000);
            }
        }

    }
}
