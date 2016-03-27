using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUno

{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar 5 números por consola, guardándolos en una variable
                escalar. Luego calcular y mostrar: el valor máximo, el valor
              mínimo y el promedio.*/
            
            int numeros=0;
            int maximo=0;
            int minimo=0;
            int flag = 0;
            int suma = 0;
            string dato;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero:");
                dato=Console.ReadLine();
                while(int.TryParse(dato, out numeros)==false)
                {
                    Console.WriteLine("ERROR.Ingrese numero:");
                    dato = Console.ReadLine();

                }

                if (flag == 0 || numeros > maximo)
                {
                    maximo = numeros;                
                }
                if (flag == 0 || numeros < minimo)
                {
                    minimo = numeros;
                    flag = 1;
                }

                suma = suma + numeros;
            }



            Console.WriteLine("El maximo numero ingresado es: " + maximo);
            Console.WriteLine("El minimo numoero ingresado es: " + minimo);
            promedio = (float)suma / 5;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
            Console.ReadLine();

        }
    }
}
