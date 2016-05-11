using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Gerente:SerHumano
    {
        private int _edad;
        public SerHumano UnHumano;

        public Gerente(int Edad, string Nombre, string Sexo)
            : base(Nombre, Sexo)
        {
            this._edad = Edad;
        }

        public Gerente(SerHumano Persona)
            : base(Persona.Nombre, Persona.Sexo)
        {
            this.UnHumano = Persona;
        }

        public void EsMayor()
        {
            if (this._edad > 40)
            {
                Console.WriteLine("Es un hombre mayor");
            }
            else
            {
                Console.WriteLine("Es un hombre joven");
            }
        }
    }
}