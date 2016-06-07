using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    class Gerente:SerHumano
    {
        private int _sueldo;
        
        public int Sueldo
        {
            get { return this._sueldo; }
            set { this._sueldo = value; }
        }

        public Gerente()
        {}
        
        public Gerente(string nom, double altura, double peso, string sexo)
        {
            Nombre = nom;
            Altura = altura;
            Peso = peso;
            Sexo = sexo;
        }
        public int SueldoTotal()
        {
            int sueldo;
            sueldo = this._sueldo * 2;
            return sueldo;
        }
        
        
        
        
        
    }
}
