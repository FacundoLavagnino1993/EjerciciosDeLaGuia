using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {

           LocalDePc.Computadora MiPc = new LocalDePc.Computadora(true, CPU.EMarca.Asus, 475, CPU.EProcesador.Intel_Core_I7);
           int opcion;
           bool rta = true;
           do
           {
               Console.WriteLine("1| Informe de pc.\n2| Apagar pc.\n3| Encender pc\n4| Salir\n Elija opcion.");
               opcion = int.Parse(Console.ReadLine());
               switch (opcion)
               {
                   case 1:
                       Console.Clear();
                       if(MiPc.getEncendido() == false)
                       {
                           Console.WriteLine("Estado : Equipo Apagado");
                       }
                       else
                       {
                           Console.WriteLine("Estado : Equipo Encendido");
                       }
                       Console.WriteLine("Marca : " + MiPc.getMarca());
                       Console.WriteLine("Peso : " + MiPc.getPeso());
                       Console.WriteLine("Procesador : " + MiPc.getProcesador());
                       break;
                   case 2:
                       Console.Clear();
                       MiPc.setEncendido(false);
                       break;
                   case 3:
                       Console.Clear();
                       MiPc.setEncendido(true);
                       break;
                   case 4:
                       rta = false;
                       break;
               }
           } while (rta);


        }
    }
}
