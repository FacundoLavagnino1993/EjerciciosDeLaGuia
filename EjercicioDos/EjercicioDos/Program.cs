using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int numero;
            double cuadrado;
            double cubo;
            Console.WriteLine("Ingrese un numero: ");
            dato = Console.ReadLine();
            while (int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine("ERROR. Ingrese un numero: ");
                dato = Console.ReadLine();
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado de " + numero + " es: " + cuadrado);
            Console.WriteLine("EL cubo de " + numero + " es: " + cubo);
            Console.ReadLine();

        }
    }
}
