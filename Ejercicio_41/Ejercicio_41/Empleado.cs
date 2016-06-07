using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    class Empleado:SerHumano
    {
        private int _sueldo;
        public int Sueldo
        {
            get { return this._sueldo; }
            set { this._sueldo = value; }
        }
        public Empleado(){}
        
        public Empleado(string nom, double altura, double peso, string sexo)
        {
            Nombre = nom;
            Altura = altura;
            Peso = peso;
            Sexo = sexo;
        }

        public void Trabajar()
        {
           
            if(this.Sueldo < 10000)
            {
                Console.WriteLine(this.Nombre+" Trabaja en un puesto de operario.\n");
            }
            else
            {
                Console.WriteLine(this.Nombre+"Trabaja en un puesto administrativo.\n");
            }

        }
    }
}
