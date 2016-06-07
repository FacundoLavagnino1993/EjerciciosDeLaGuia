using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Factura:DatosFactura
    {
        public int cantidad;
        public string descripcion;
        public double precioUnitario;
        private double _importe;
       
        private double _total;


        public void CalculaImporte()
        {
            this._importe = this.precioUnitario * this.cantidad;
        }
        public void CalculaTotal()
        {
                this._total = this._importe + (this._importe*iva);   
        }
        public double Importe
        {
            get { return this._importe; }
        }

        public double Iva
        {
            get { return iva; }
        }

        public double Total
        {
            get { return this._total; }
        }

        public static void Mostrar(Factura factura)
        {
            Console.WriteLine("Nombre: " + factura.nombreCliente + "\tCuil : " + factura.cuil + "\nDireccion : " + factura.direccion + "\tTelefono : " + factura.telefono + "\nCodigo Postal : " + factura.codigoPostal + "\tProvincia : " + factura.provincia + "\n\n\nDescripcion : " + factura.descripcion + "\nCantidad : " + factura.cantidad + "\nPrecio Unitario : " + factura.precioUnitario + "\nPrecio bruto : "+factura.Importe+"\nIVA : " + factura.Iva*100 + "%\nTotal : " + factura.Total);
        }

    }
}
