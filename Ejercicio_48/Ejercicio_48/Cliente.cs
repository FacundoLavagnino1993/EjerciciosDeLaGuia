using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_48
{
    public class Cliente
    {
        private string _apellido;
        private string _cuentaBancaria;
        private string _cuit;
        private int _edad;
        private string _nombre;



        public Cliente()
        { }

        public Cliente(string cuentaBancaria)
            : this()
        {
            this._cuentaBancaria = cuentaBancaria;
        }
        public Cliente(string cuit, string cuentaBancaria)
            : this(cuentaBancaria)
        {
            this._cuit = cuit;

        }

        public string Apellido
        {
            set { this._apellido = value; }
            get { return this._apellido; }
        }

        public string CuentaBancaria
        {
            get { return this._cuentaBancaria; }
        }

        public string Cuit
        {
            set { this._cuit = value; }
            get { return this._cuit; }
        }

        public int Edad
        {
            set { this._edad = value; }
            get { return this._edad; }
        }

        public string Nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }
        public virtual void guardarEnDisco()
        {
            Console.WriteLine("Guardando informacion en disco...\n\n");
            StreamWriter se = new StreamWriter("C:\\Users\\Facundo\\Desktop\\ejercicios\\EjerciciosDeLaGuia\\Ejercicio_42\\Ejercicio_42\\Ejercicio_42\\CuentaBancaria.txt");
            se.WriteLine("Nombre :" + this.Nombre + "\tApellido :" + this.Apellido);
            se.WriteLine("Cuit :" + this.Cuit + "\tEdad :" + this.Edad);
            se.WriteLine("Cuenta Bancaria :" + this.CuentaBancaria);
            se.Close();
            Console.WriteLine("Guardado Exitoso.");
        }

        public bool ValidarCuit(string cuit)
        {
            bool rta = false;
            if (cuit.Length <= 13) //&& cuit.Substring(2,3) != "-" && cuit.Substring(10,11) != "-")
            {
                rta = true;
            }

            return rta;

        }




    }
}
