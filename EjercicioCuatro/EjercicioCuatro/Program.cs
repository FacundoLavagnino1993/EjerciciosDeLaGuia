using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int limite=7;
            int modulo;

            for(int i=2; i<limite ; i ++ )
            {
                for(int j=1; j<i ; j++)
                {
                    modulo = i % j;
                    if(modulo==0)
                    {
                        acumulador = acumulador + j;
                    }
                }

                if(acumulador == i)
                {
                    Console.WriteLine(i + ", ");
                }
            }

            Console.ReadLine();
        }
    }
}
