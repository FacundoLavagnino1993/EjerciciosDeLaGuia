using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public abstract class Animal
    {
        private int _patas;
        


        public Animal(int patas)
        { 
            this._patas = patas;
        }

        public virtual void caminar()
        {
            Console.WriteLine("Este animal camina sobre " + this._patas + " patas.");
        }

        public abstract void comer();
        

    }
}
