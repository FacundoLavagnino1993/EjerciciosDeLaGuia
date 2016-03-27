using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int num;

            Console.WriteLine("Ingrese un numero:");
            dato = Console.ReadLine();
            while(int.TryParse(dato, out num)==false)
            {
                Console.WriteLine("ERROR Ingrese un numero:");
                dato = Console.ReadLine();
            }

            




        }
    }
}
