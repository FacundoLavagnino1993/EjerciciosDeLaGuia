using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diecisiete
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta MiCuenta = new Cuenta();

            MiCuenta.setNombre("Facundo");
            MiCuenta.setCuenta(5504);
            MiCuenta.setSaldo(400.50);
            MiCuenta.setImpuesto(Enumerado.ETipoInteres.TAE);

            Console.WriteLine("Datos de la cuenta");
            Console.WriteLine("Nombre : " + MiCuenta.getNombre());
            Console.WriteLine("Nro de Cuenta : " + MiCuenta.getCuenta());
            Console.WriteLine("Saldo : " + MiCuenta.getSaldo());
            Console.WriteLine("Tipo de Impuesto : " + MiCuenta.getTipoInteres());
            Console.ReadKey();
        }
    }
            
}
