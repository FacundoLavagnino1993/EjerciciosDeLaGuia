using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioQuince
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int numUno;
            int numDos;
            string operacion;
            Console.WriteLine("Ingrese primer numero: ");
            dato = Console.ReadLine();
            if(int.TryParse(dato, out numUno) == false)
            {
                Console.WriteLine("No se pudo convertir string.");
            }
            Console.WriteLine("Ingrese segundo numero: ");
            dato = Console.ReadLine();
            if(int.TryParse(dato, out numDos) == false)
            {
                Console.WriteLine("No se pudo convertir string.");
            }
            Console.WriteLine("Indique la operacion que desea realizar :| + | - | * | / |");
            operacion = Console.ReadLine();
            while(operacion != "+" && operacion != "-" && operacion != "*" && operacion != "/")
            {
                Console.WriteLine("Operacion invalida. Indique nuevamente la operacion ");
                operacion = Console.ReadLine();
            }

            Calculadora.Mostrar(Calculadora.calcular(numUno, numDos, operacion));
            
            Console.ReadLine();
        }
    }
}
