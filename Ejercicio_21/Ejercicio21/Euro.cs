using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Euro
    {   
        //Atributos
        private double _dolar;
        private double _cantidadEuros;

        //Constructores
        public Euro()
        { 
            
        }

        public Euro(double moneda)
        {
            this._cantidadEuros = moneda;
        }

        //Propiedades.
        public double CantidadEuros
        {
            set { this._cantidadEuros = value; }
            get { return this._cantidadEuros; }
        }
        public double CantidadDolar
        {
            get { return this._dolar; }
        }
        //Sobrecargas.

        public static double operator +(Euro euro, Dolar dolar)
        {
            double rta;
            rta = (euro._cantidadEuros + dolar.CantidadDolares);
            return rta;
        }
        
        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.CantidadDolares*1.3642);
        }
       

       


       





    }
}
