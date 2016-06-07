using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    enum TipoLlamada
    {
        Local, Provincial, Todas,
    }

    public enum Franja
    {
        Franja_1, 
        Franja_2,
        Franja_3,
    }

    public class Provincial:Llamada
    {
        public Franja _franjaHoraria;
        
      
        
        public Provincial()
        { }

        public Provincial(Franja miFranja, Llamada unaLlamada)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get { return this.calcularCosto(); }
        }


        private float calcularCosto()
        {
            float resultado = 0;

            if (this._franjaHoraria == Franja.Franja_1)
            {
                resultado = this._duracion * 0.99f;
            }
            else if (this._franjaHoraria == Franja.Franja_2)
            {
                resultado = this._duracion * 
            }
            
            return 0;
        }

        public void MostrarP()
        {
            base.Mostrar();
            StringBuilder texto = new StringBuilder("\nFranja : " + this._franjaHoraria + "\tCosto de la llamada : " + this.CostoLlamada);
        }
            
    }
}
