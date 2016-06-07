using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDoce
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            string resp;
            bool rta = false;

            Console.WriteLine("Desea continuar:");
            resp=Console.ReadLine();

            while(resp != "s" && resp != "n")
                {
                    Console.WriteLine("Respuesta incorrecta. Desea continuar:");
                    resp = Console.ReadLine();
                }

            if(resp == "s")
            {
                rta = true;
            }
            else if(resp == "n")
            {
                rta = false;
            }

            return rta;
        }

    }
}
