﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar monedasDolar = new Dolar();
            Euro monedasEuro = new Euro(monedasDolar);

            monedasEuro.CantidadEuros = 1;
            monedasDolar.CantidadDolares = 1;
            
            Console.WriteLine(monedasEuro.CantidadDolar);

            Console.ReadKey();

        }
    }
}