using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Test
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> Filaclientes { get { return filaClientes; }  }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }
        public void AtenderClientes()
        {
            foreach (String cliente in this.Filaclientes)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} {cliente}");
                Thread.Sleep(2000);
            }
        }
    }
}
