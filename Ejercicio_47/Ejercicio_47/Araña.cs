using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Araña:Animal, Mascota
    {
        public Araña(int patas):base(patas)
        {}

        public override void comer()
        {
            Console.WriteLine("Este animal come insectos.");
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
            get { return "Sin nombre"; }
            set { }
        }

    

    }
}
