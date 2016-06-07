using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Editorial
    {
        private string _nombreEditorial;
        private int _año;
        public Editorial()
        { }
        public string NombreEditorial
        {
            set { this._nombreEditorial = value; }
            get { return this._nombreEditorial; }
        }

        public int Año 
        {
            set { this._año = value; }
            get { return this._año; }
        }
    }
}
