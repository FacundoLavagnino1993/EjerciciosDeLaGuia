using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDoce
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            
            int num;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese numero:");
                dato = Console.ReadLine();
                if (int.TryParse(dato, out num) == false)
                {
                    Console.WriteLine("No se pudo convertir string.");
                }

                suma = suma + num;

                

            } while (ValidarRespuesta.ValidaS_N() != false);

            Console.WriteLine("La suma de los numeros ingresados es :" + suma);
            Console.ReadKey();
        }
    }
}
