﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTrece
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string binario="";
            string aux="";
             double modulo;
             int division;
             int flag = 0;

             do
             {
                 modulo = num % 2;
                 division = (int)num / 2;
                 binario = binario + modulo;


                 if (division == 1 || division == 0)
                 {
                     Convert.ToString(division);
                     binario = binario + division;
                     flag = 1;

                 }

                 num = division;

             } while (flag == 0);


             
             for (int i = 0; i > binario.Length; i++)
             {
                 Console.WriteLine("char: "+binario[i]);
             
             }


                 return binario;


        }

        public static double BinarioDecimal(string binario)
        {
            double Decimal=0;
            int x;

            x = binario.Length -1;

            for (int i = 0; i < binario.Length; i++)
            {
                if ((binario.Substring(i, 1)) == "1")
                {
                    Decimal = Decimal + (Math.Pow(2, x));
                }
                x--;
            }

            return Decimal;
        
        }

    }
}
