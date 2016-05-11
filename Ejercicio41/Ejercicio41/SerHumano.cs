using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class SerHumano
    {
        private string _nombre;
        private Single _peso;
        private Single _altura;
        private string _sexo;

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Sexo
        {
            get { return _sexo; }
        }

        public SerHumano(string nombre, string sexo)
        {
            this._nombre = nombre;
            this._sexo = sexo;
        }

        public SerHumano(Single peso, Single altura, string nombre, string sexo): this(nombre, sexo)
        {
            this._peso = peso;
            this._altura = altura;
        }


        public string Comer()
        {
            string rta;
            rta = "Come mucho";
            return rta;
        }

        public void Dormir()
        {
            Console.WriteLine("Duerme peola");
        }

        public void MostrarString()
        {
            Console.WriteLine("Nombre : " + Nombre + "\nSexo : " + Sexo);
        }
    }
}
