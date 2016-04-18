using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuatro
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;//Cambia el color de fondo de las letras
            Console.ForegroundColor = ConsoleColor.Red;//Cambia el color de las letras
            NumeroPerfecto Num = new NumeroPerfecto();
            int resultado = 0;
            Console.WriteLine("Los primeros 4 numeros perfectos son: ");
            Num.NumeroEsPerfecto();
            Console.WriteLine("Listo");

            Console.ReadLine();







               
                
                
        }
    }
}
