using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10] { 34, 23, 1, 5, 7, 8, 53, 44, 4, 75 };
            int[] B = new int[10] { 22, 1, 2, 23, 4, 64, 44, 57, 7, 97 };

            int[] C = new int[10];
            int aux = 0;
            for (int i = 0; i < 10; i++)
            {
                if (A[i] < B[i])
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i];
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i+1 ; j < 10; j++)
                {
                    if(C[i] >= C[j])
                    {
                        aux = C[i];
                        C[i] = C[j];
                        C[j] = aux;
                    }
                }
            }
            Console.WriteLine("Vector C acreciente : ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(C[i]);
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (C[i] <= C[j])
                    {
                        aux = C[i];
                        C[i] = C[j];
                        C[j] = aux;
                    }
                }
            }
            Console.WriteLine("\nVector C decreciente : ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(C[i]);
            }

            Console.ReadKey();
        }
    }
}
