using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPAPA
{
    class Conclave
    {
        private int _canMaxCardenales;
        private List<Cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private Cardenal _papa;
        public  static int cantidadVotaciones;
        public  static DateTime fechaVotacion;
        

        static Conclave()
        {
            cantidadVotaciones = 0;
            fechaVotacion = DateTime.Now;
        }

        public Conclave()
        {
            this._canMaxCardenales = 1;
            this._lugarEleccion = "Capilla Sixtina";
            this._cardenales = new List<Cardenal>();
        }
        private Conclave(int CantidadCardenales):this()
        {
            this._canMaxCardenales = CantidadCardenales;
        }

        public Conclave(int CantidadCardenales, string lugarEleccion):this()
        {

        }

        private static void ContarVotos(Conclave conclave)
        {
            int indice = 0;
            foreach (Cardenal item in conclave._cardenales)
            {
                if(item.getCantidadVotosRecibidos() >= conclave._cardenales[indice].getCantidadVotosRecibidos() )
                {
                    indice = conclave._cardenales.IndexOf(item);
                }
            }

            conclave._habemusPapa = true;
            conclave._papa = conclave._cardenales[indice];

        }

        public static explicit operator bool(Conclave con)
        {
            bool rta = false;
            if(con._habemusPapa == true)
            {
                rta = true;
            }

            return rta;
        }

        private bool HayLugar()
        {
            bool rta = false;
                if(this._canMaxCardenales > this._cardenales.Count)
                {
                    rta = true;
                }

                return rta;
        }

        public static implicit operator Conclave(int cantidadCardenales)
        {
            return new Conclave(cantidadCardenales);
        }
        
        public string Mostrar()
        {
            string rta = "";
            if(this._habemusPapa == true)
            {
                rta = string.Concat("\nLugar de votacion: " + this._lugarEleccion + "\nFecha : " + fechaVotacion + "\nCantidad de votaciones: " + cantidadVotaciones + "\nHabemus PAPA!!!" + this._papa.ObtenerNombreYNombrePapal());
            }
            else 
            {
                rta = string.Concat("\nLugar de votacion: " + this._lugarEleccion + "\nFecha : " + fechaVotacion + "\nCantidad de votaciones: " + cantidadVotaciones + "\nNo Habemus PAPA!!!" + mostrarCardenales());
            }

            return rta;
        }

        private string mostrarCardenales()
        {
            string respuesta = "";

            foreach (Cardenal item in _cardenales)
            {
                respuesta += Cardenal.Mostrar(item);

            }

            return respuesta;
        }

        public static bool operator !=(Conclave con, Cardenal c)
        {
            return !(con == c);
        }

        public static Conclave  operator +(Conclave con, Cardenal c)
        {
            if(con.HayLugar() == true && !(con == c))
            {
                con._cardenales.Add(c);
            }

            return con;
        }

        public static bool operator ==(Conclave con, Cardenal c)
        {
            bool rta = false;
            foreach (Cardenal item in con._cardenales)
            {
                if(c == item)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static void VotarPapa(Conclave conclave)
        {
            Random ram = new Random();
            
                int indicePapal = ram.Next(0, conclave._cardenales.Count - 1);
                conclave._cardenales[indicePapal]++;
                ContarVotos(conclave);
            
        }

            
       
    }
}
