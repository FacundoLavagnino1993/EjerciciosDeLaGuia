using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diecisiete
{
    class Cuenta
    {
       private string _nombre;
       private long _nroCuenta;
       private double _saldo;
       private Enumerado.ETipoInteres _tipoInteres;

       public string getNombre()
       {
           return this._nombre;
       }
    
        public long getCuenta()
       {
           return this._nroCuenta;
       }

        public double getSaldo()
        {
            return this._saldo;
        }

        public Enumerado.ETipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }

        public void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public void setCuenta(long cuenta)
        {
            this._nroCuenta = cuenta;
        }

        public void setSaldo(double saldo)
        {
            this._saldo = saldo;
        }

        public void setImpuesto(Enumerado.ETipoInteres interes)
        {
            this._tipoInteres = interes;
        }
    }
}
namespace Enumerado
{
    enum ETipoInteres
    {
        TIN, TAE, TIR
    }
}