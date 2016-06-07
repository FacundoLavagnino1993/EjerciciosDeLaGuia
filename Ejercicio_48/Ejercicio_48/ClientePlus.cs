﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_48
{
    public class ClientePlus : Cliente , Imostrar
    {
        private int _puntos;
        public int Puntos
        {
            set { this._puntos = value; }
            get { return this._puntos; }
        }

        public ClientePlus(string cuentaBancaria)
            : base(cuentaBancaria)
        { }
        public override void guardarEnDisco()
        {
            Console.WriteLine("Guardando informacion en disco...\n\n");
            StreamWriter se = new StreamWriter("C:\\Users\\Facundo\\Desktop\\ejercicios\\EjerciciosDeLaGuia\\Ejercicio_48\\Ejercicio_48\\Ejercicio_48\\CuentaBancariaPlus.txt");
            se.WriteLine("Nombre :" + this.Nombre + "\tApellido :" + this.Apellido);
            se.WriteLine("Cuit :" + this.Cuit + "\tEdad :" + this.Edad);
            se.WriteLine("Cuenta Bancaria :" + this.CuentaBancaria + "\tPuntos :" + this.Puntos);
            se.Close();
            Console.WriteLine("Guardado Exitoso.");
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre :" + this.Nombre + "\tApellido :" + this.Apellido);
            Console.WriteLine("Cuit :" + this.Cuit + "\tEdad :" + this.Edad);
            Console.WriteLine("Cuenta Bancaria :" + this.CuentaBancaria + "\tPuntos :" + this.Puntos);
        }

    }
}
