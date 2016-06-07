using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Program
    {
        static void Main(string[] args)
        {


            Alumno alumnoUno = new Alumno("Ramirez", 2331, "Julio");
            Alumno alumnoDos = new Alumno("Gonzalez", 2330, "Pedro");
            Alumno alumnoTres = new Alumno("Perez", 2299, "Santiago");

            alumnoUno.Estudiar(4, 4);
            alumnoDos.Estudiar(5, 6);
            alumnoTres.Estudiar(7, 8);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            alumnoUno.Mostrar();
            alumnoDos.Mostrar();
            alumnoTres.Mostrar();

            Console.ReadLine();
        }
    }
}
