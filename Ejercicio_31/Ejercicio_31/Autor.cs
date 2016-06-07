using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Autor
    {
        private string _nombreAutor;
        public Autor()
        { }
        public string NombreAutor
        {
            set { this._nombreAutor = value; }
            get { return this._nombreAutor; }
        }
    }
}
