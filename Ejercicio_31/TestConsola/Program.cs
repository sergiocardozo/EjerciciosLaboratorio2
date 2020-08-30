using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtencionAlCliente;
namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(34, "Sergio");
            Negocio negocio = new Negocio("Empresita");
            PuestoAtencion puestoAtencion = new PuestoAtencion(PuestoAtencion.Puesto.caja1);

            Console.WriteLine(puestoAtencion.Atender(cliente));

            Console.ReadKey();
        }
    }
}
