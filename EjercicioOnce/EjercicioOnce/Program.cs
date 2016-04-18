using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOnce
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int num;
            int max = 0;
            int min = 0;
            int suma = 0;
            int flag = 0;
            float promedio;
            
            for (int i = 0; i < 10; i++)
			{
			    Console.WriteLine("Ingrese un numero: ");
                dato = Console.ReadLine();
                if (int.TryParse(dato, out num) == false)
                {
                    Console.WriteLine("No se pudo convertir string.");
                }

                 while(Validacion.Validar(100, -100, num) == false)
                 {
                     Console.WriteLine("El numero ingresado esta fuera de parametro,  reingrese: ");
                     dato = Console.ReadLine();
                     if(int.TryParse(dato, out num) == false)
                     {
                         Console.WriteLine("No se pudo convertir string.");
                     }
                 }

                 suma = suma + num;
                    
                if(flag == 0 || num > max)
                    {
                        max = num;
                    }
                if(flag == 0 || num < min)
                    {
                        min = num;
                        flag = 1;
                    }
			}

            promedio = (float)suma / 10;

            Console.WriteLine("El numero maximo ingresado es : " + max + " el minimo ingresado es : " + min + " y el promedio es : " + promedio);
            Console.ReadKey();
        }
    }
}
