using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Cuenta
    {
        private string _nombre;
        private Int64 _nroCuenta;
        private double _saldo;
        private Single _tipoInteres;
        

        public string Nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }

        public Int64 NroCuenta
        {
            set { this._nroCuenta = value; }
            get { return this._nroCuenta; }
        }

        public double Saldo
        {
            get { return this._saldo; }
        }

        public Single TipoInteres
        {
            set { this._tipoInteres = value; }
            get { return this._tipoInteres; }
        }

        public void Depositar(Int64 deposito)
        {
            this._saldo = deposito;
        }

        public static void Mostrar(Cuenta cuenta)
        {
            Console.WriteLine("Nombre: " + cuenta._nombre + "\nCuenta : " + cuenta._nroCuenta + "\nSaldo : " + cuenta._saldo + "\nInteres : " + cuenta._tipoInteres);
        }

        
    }
}
