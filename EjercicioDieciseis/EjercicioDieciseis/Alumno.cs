using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDieciseis
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        public string apellido;
        public string nombre;
        public int legajo;

        Random random = new Random();
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
    
        public void Estudiar(byte _nota1, byte _nota2)
        {
            this._nota1 = _nota1;
            this._nota2 = _nota2;
        }

        public void CalcularFinal()
        {
            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = random.Next(4,10);
            }
            else
            {
                this._notaFinal = -1;
            }

            if(_notaFinal != -1)
            {
                Console.WriteLine("Final: " + _notaFinal);
            }
        }

        public static void Mostrar(Alumno UnAlumno)
        {
            Console.WriteLine("Nombre: " + UnAlumno.nombre);
            Console.WriteLine("Apellido: " + UnAlumno.apellido);
            Console.WriteLine("Legajo: " + UnAlumno.legajo);
            Console.WriteLine("Primer Parcial: " + UnAlumno._nota1);
            Console.WriteLine("Segundo Parcial: " + UnAlumno._nota2);
            UnAlumno.CalcularFinal();
        }
    }
}
