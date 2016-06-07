using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        public float area;
        public float lado;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;

        public Rectangulo(Punto _vertice1, Punto _vertice3)
        {
            this.vertice1 = _vertice1;
            this.vertice3 = _vertice3;
        }

    }


}
