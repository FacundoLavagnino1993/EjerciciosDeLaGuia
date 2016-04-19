using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDieciseis
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno AlumnoUno = new Alumno("Fernando", "Chavez", 550);
            Alumno AlumnoDos = new Alumno("Julian", "Olivos", 620);
            Alumno AlumnoTres = new Alumno("Fabian", "Perez", 350);

            AlumnoUno.Estudiar(4, 5);
            AlumnoDos.Estudiar(7, 8);
            AlumnoTres.Estudiar(9, 4);

            Alumno.Mostrar(AlumnoUno);
            Alumno.Mostrar(AlumnoDos);
            Alumno.Mostrar(AlumnoTres);

            Console.ReadKey();
        }
    }
}
