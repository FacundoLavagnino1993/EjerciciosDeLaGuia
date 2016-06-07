using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();
            factura.nombreCliente = "Juan Perez";
            factura.telefono = 43332300;
            factura.direccion = "Pilcomayo 342";
            factura.provincia = "Buenos Aires";
            factura.cuil = "30-2221134-5";
            factura.cuit = "";
            factura.codigoPostal = 1300;
            factura.iva = 0.21;
            factura.cantidad = 30;
            factura.descripcion = "Lamparas";
            factura.precioUnitario = 12;

            factura.CalculaImporte();
            factura.CalculaTotal();
            Factura.Mostrar(factura);
            Console.ReadKey();
            
        }
    }
}
