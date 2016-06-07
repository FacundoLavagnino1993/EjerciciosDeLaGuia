using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Pez:Animal,Mascota
    {
        private string _nombre;

        public Pez(int patas):base(patas)
        { 
            
        }

        public override void comer()
        {
            Console.WriteLine("Este animal come plancton.");
        }

        public override void caminar()
        {
            base.caminar();
        }

        public void jugar()
        {
            Console.WriteLine("Este animal no juega.");
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
    }
}
