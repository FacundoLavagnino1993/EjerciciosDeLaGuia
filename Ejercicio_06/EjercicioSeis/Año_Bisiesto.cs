using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSeis
{
    class Año_Bisiesto
    {
        public void AñoBiciesto(int num)
        {
            bool MultiploCuatro = false;
            bool MultiploCien = false;
            bool MultiploCuatrociento = false;
            int Modulo;

            Modulo = num % 4;

            if(Modulo == 0)
            {
                MultiploCuatro = true;
            }
            
            Modulo = num % 100;
            
            if(Modulo == 0)
            {
                MultiploCien = true;
            }

            Modulo = num % 400;

            if(Modulo == 0)
            {
                MultiploCuatrociento = true;
            }
            
            if(MultiploCuatro == true && MultiploCien == true && MultiploCuatrociento == true)
            {
                Console.WriteLine("El año "+num+" es biciesto.");
                
            }
        }
    }
}
