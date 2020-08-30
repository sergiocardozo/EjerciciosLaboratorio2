using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);
            Thread hiloAsignar = new Thread(new ThreadStart(negocio.AsignarCaja));
            Thread hiloAtenderCaja1 = new Thread(new ThreadStart(negocio.Caja1.AtenderClientes));
            hiloAtenderCaja1.Name = "Caja 1";
            Thread hiloAtenderCaja2 = new Thread(new ThreadStart(negocio.Caja2.AtenderClientes));
            hiloAtenderCaja2.Name = "Caja 2";

            negocio.Clientes.Add("a");
            negocio.Clientes.Add("b");
            negocio.Clientes.Add("c");
            negocio.Clientes.Add("d");
            negocio.Clientes.Add("e");

            hiloAsignar.Start();
            hiloAsignar.Join();
            hiloAtenderCaja1.Start();
            hiloAtenderCaja2.Start();

            Console.ReadKey();
        }
    }
}
