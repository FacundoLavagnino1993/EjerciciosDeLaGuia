using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Araña Arañita = new Araña(8);
            Pez UnPez = new Pez(0);
            Gato Gatito = new Gato(4);

            Console.WriteLine("Araña");
            
            Arañita.caminar();
            Arañita.comer();
            Arañita.jugar();

            Console.WriteLine("\nGato");
            Gatito.Nombre = "Pepito";
            Console.WriteLine(Gatito.Nombre);
            Gatito.caminar();
            Gatito.comer();
            Gatito.jugar();

            Console.WriteLine("\nPez");
            UnPez.Nombre = "Pecesito";
            Console.WriteLine(UnPez.Nombre);
            UnPez.caminar();
            UnPez.comer();
            UnPez.jugar();

            Console.ReadKey();
        }

      
    }
}
