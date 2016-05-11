using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Empleado:SerHumano
    {
        private Single _sueldo;

        public Empleado(Single sueldo, string nombre, string sexo)
            : base(nombre, sexo)
        {
            this._sueldo = sueldo;
        }

        public void Trabajar()
        {
            Console.WriteLine("\nEsta trabajando.");
        }

        public void SueldoMayor()
        {
            if (this._sueldo > 500)
                Console.WriteLine("El sueldo es mayor a 500");
            else
                Console.WriteLine("El sueldo es menor a 500");
        }

    }
}
