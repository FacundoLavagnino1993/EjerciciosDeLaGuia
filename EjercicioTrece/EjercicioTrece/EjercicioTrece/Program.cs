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
            //string bin = ("16");
            
            double numero;
            binario=Conversor.DecimalBinario(16);

            numero=Conversor.BinarioDecimal("16");

            Console.WriteLine(binario);
            Console.WriteLine(numero);
            Console.ReadLine();
        }
    }
}
