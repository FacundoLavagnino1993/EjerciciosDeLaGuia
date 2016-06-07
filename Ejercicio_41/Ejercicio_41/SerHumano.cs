using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    class SerHumano
    {
        private string _nombre;
        private double _altura;
        private double _peso;
        private string _sexo;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public double Altura
        {
            get { return this._altura; }
            set { this._altura = value; }
        }

        public double Peso
        {
            get { return this._peso; }
            set { this._peso = value; }
        }

        public string Sexo
        {
            get { return this._sexo; }
            set { this._sexo = value; }
        }

        public void Comer(string comida)
        {
            Console.Write(this._nombre+ " Ya comio " + comida);
        } 

        public void Dormir()
        {
            Console.WriteLine(this._nombre+" Debe dormir 8 hs por dia.\n");
        }
        
    }
}
