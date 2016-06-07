using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int num;
            int modulo=0;
            bool primo;

            Console.WriteLine("Ingrese un numero:");
            dato = Console.ReadLine();
            while(int.TryParse(dato, out num)==false)
            {
                Console.WriteLine("ERROR Ingrese un numero:");
                dato = Console.ReadLine();
            }

            for(int i = 3;i <= num; i++)
            {
                primo = true;   
                for (int j = 2; j < i ; j++)
                {
                    modulo = i % j;
                    if (modulo == 0)
                    {
                        primo = false;
                    }

                }

               if(primo == true)

                    Console.WriteLine(i + ", ");                
               
            }

            Console.ReadLine();


        }
    }
}
