using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteUno = new Cliente("22-34872231-7", "0072881992388");
            ClientePlus clienteDos = new ClientePlus("00012342445");

            clienteUno.Nombre = "Federico";
            clienteUno.Apellido = "Lopez";
            clienteUno.Edad = 29;
            clienteUno.ValidarCuit(clienteUno.Cuit);
            clienteUno.guardarEnDisco();

            clienteDos.Nombre = "Julian";
            clienteDos.Apellido = "Garcia";
            clienteDos.Edad = 35;
            clienteDos.Cuit = "21-37822311-9";
            clienteDos.Puntos = 5340;
            clienteDos.ValidarCuit(clienteDos.Cuit);
            clienteDos.guardarEnDisco();
            clienteDos.Mostrar();


            Console.ReadKey();
        }
    }
}
