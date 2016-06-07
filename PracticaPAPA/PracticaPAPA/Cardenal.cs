using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPAPA
{
    class Cardenal
    {
        private int _cantVotosRecibidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;

        private Cardenal()
        {
            this._cantVotosRecibidos = 0;    
        }

        public Cardenal(string nombre,string nombrePapal):this()
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre,string nombrePapal, ENacionalidades nacionalidad):this(nombre,nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }

        public int getCantidadVotosRecibidos()
        {
            return this._cantVotosRecibidos;
        }

        private string Mostrar()
        {
            return string.Concat(ObtenerNombreYNombrePapal() + " \nNacionalidad : " + this._nacionalidad + " \nCantidad de votos recibidos : " + this._cantVotosRecibidos);
        }

        public static string Mostrar(Cardenal c)
        {
            return c.Mostrar();
        }

        public string ObtenerNombreYNombrePapal()
        {
            
            return  string.Concat("\nEl cardenal " + this._nombre + " se llamara 'PAPA' " + this._nombrePapal + ".");
         
        }

        public static bool operator !=(Cardenal c1,Cardenal c2)
        {
            return !(c1 == c2);
        }

        public static Cardenal operator ++(Cardenal c)
        {
            c._cantVotosRecibidos++;
            return c;
        }

        public static bool operator ==(Cardenal c1,Cardenal c2)
        {
            bool rta = false;
            if(c1._nombre == c2._nombre && c1._nombrePapal == c2._nombrePapal && c1._nacionalidad == c2._nacionalidad)
            {
                rta = true;
            }
            return rta;
        }




    }

    enum ENacionalidades
    {
        Italiano, Polaco, Español, Argentino, Nigeriano
    }
}
