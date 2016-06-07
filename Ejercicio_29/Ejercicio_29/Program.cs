using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta CuentaI = new Cuenta();
            CuentaI.Nombre = "Juan Perez";
            CuentaI.NroCuenta = 4552223111;
            CuentaI.TipoInteres = 4;
            Cuenta CuentaII = new Cuenta();
            CuentaII.Nombre = "Julio Roca";
            CuentaII.NroCuenta = 5668312300;
            CuentaII.TipoInteres = 4;
            

            CuentaI.Depositar(2300);
            Cuenta.Mostrar(CuentaI);
            

            

            
            Console.ReadKey();

        }
    }
}
