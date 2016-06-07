using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioQuince
{
    class Calculadora
    {
        public static float calcular(int numUno, int numDos, string operacion)
        {
            float resultado = 0;

            if(operacion == "+")
            {
                resultado = numUno + numDos;
            }
            else if( operacion == "-")
            {
                resultado = numUno - numDos;
            }
            else if( operacion == "*")
            {
                resultado = numUno + numDos;
            }else if( operacion == "/")
            {
                if (Validar(numDos) == false)
                {
                    Console.WriteLine("No se puede dividir por 0");
                }else
                {
                    resultado = numUno / numDos;
                }
            }
            return resultado;
        }

        private static bool Validar(int num)
        {
            bool valido = false;
            if( num != 0)
            {
                valido = true;
            }
            return valido;
        }

        public static void Mostrar(float resultado)
        {
            Console.WriteLine("El resultado es: "+resultado);
        }
    }
}
