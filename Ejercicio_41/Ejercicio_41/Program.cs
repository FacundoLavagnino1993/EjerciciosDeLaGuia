using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado empUno = new Empleado("Arturo", 1.78, 87.8, "M");
            Gerente gerUno = new Gerente("Julio",1.85,95.6,"M");

            empUno.Sueldo = 8900;
            empUno.Trabajar();
            
            gerUno.Comer("Ravioles.");
            gerUno.Dormir();
            Console.ReadLine();
            
        }
    }
}
