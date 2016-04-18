using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOnce
{
    class Validacion
    {
        public static bool Validar(int max, int min, int num)
        { 
            bool valido = false;

            if (num > min && num < max)
            {
                valido = true;
            }

            return valido;
        }
    }
}
