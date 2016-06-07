using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vector = new int[20] { -2, 3, 5, -4, 10, -7, 14, 23, 12, -3, -13, 25, 22, -5, -6, 16, 17, 18, -19, 20 };
            int aux;


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Vector[i]);
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = i+1; j < 20; j++)
                {
                    if(Vector[i]>Vector[j])
                    {
                        aux = Vector[i];
                        Vector[i] = Vector[j];
                        Vector[j] = aux;
                    }
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Vector[i]);
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    if (Vector[i] < Vector[j])
                    {
                        aux = Vector[i];
                        Vector[i] = Vector[j];
                        Vector[j] = aux;
                    }
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Vector[i]);
            }

            Console.ReadKey();
        }
    }
}
