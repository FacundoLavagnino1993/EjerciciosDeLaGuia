using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Alumno
    {
        //Atribute.
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        private string _apellido;
        private int _legajo;
        private string _nombre;

        //Constructor.
        public Alumno(string apellido, int legajo, string nombre)
        {
            this._apellido = apellido;
            this._legajo = legajo;
            this._nombre = nombre;
        }

        //Methods.
        public void CalcularFinal()
        {
            
            Random rmd = new Random();

            if (!(this._nota1 >= 4 && this._nota2 >= 4))
            {
                this._notaFinal = -1;
            }
            else
            {
                this._notaFinal = rmd.Next(2, 10);
                
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }
        public void Mostrar()
        {
            Console.WriteLine("Alumno : " + this._apellido + " " + this._nombre + "\nLegajo : " + this._legajo + "\n\nNota Primer Parcial : " + this._nota1 + "\nNota Segundo Parcial : " + this._nota2 + "\n");
            if (this._notaFinal != -1)
            {
                Console.WriteLine("Nota Final : " + this._notaFinal + "\n");

            }

        }
    }
}