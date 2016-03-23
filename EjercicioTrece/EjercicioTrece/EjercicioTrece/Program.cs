using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTrece
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario;
            binario=Conversor.DecimalBinario(16);
            Console.WriteLine(binario);
            Console.ReadLine();
        }
    }
}
