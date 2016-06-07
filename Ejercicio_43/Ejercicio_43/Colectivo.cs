using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
    public abstract class Colectivo
    {
        protected string _patente;
        protected string _marca;
        protected double _cantidadDeAsientos;
        protected double _distancia;
        public double CantidadDeAsientos
        {
            get { return this._cantidadDeAsientos; }
        }
        public Colectivo()
        { }
        public Colectivo(string patente, string marca, double cantidadAsientos)
        {
            this._patente = patente;
            this._marca = marca;
            this._cantidadDeAsientos = cantidadAsientos;
        }

        
        

        
        public static bool ValidarAsientos(double cantidadAsientos, double cantidadPasajeros)
        {
            bool rta = false;
            if(cantidadAsientos > cantidadPasajeros)
            { rta = true; }
            return rta;
        }

        public virtual void SetearKm(double km)
        {
            this._distancia = km;
        }

        public abstract double indicarVelocidad();
    }
}
