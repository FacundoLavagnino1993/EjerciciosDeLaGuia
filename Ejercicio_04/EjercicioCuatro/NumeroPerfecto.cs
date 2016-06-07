using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuatro
{
    class NumeroPerfecto
    {
        public void NumeroEsPerfecto()
        {
            int Numero_Perfecto = 0;
            int modulo;
            int suma = 0;
            // int NumeroPerfecto=0;
            int contador = 0;

            for (int j = 6; j < 1000000; j++)
            {
                suma = 0;
                for (int i = 1; i < j; i++)
                {
                    modulo = j % i;

                    if (modulo == 0)
                    {
                        suma = suma + i;
                    }

                    
                }
                if (suma == j)
                {
                    Numero_Perfecto = j;
                    contador++;
                    Console.WriteLine(Numero_Perfecto);

                }
                if (contador == 4)
                {
                    break;
                }
            }

             
        } 
    }
}
