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
    public class Provincial:Llamada
    {
        public  Franja _franjaHoraria = 0;
      
        
        public Provincial()
        { }

        public Provincial(Franja miFranja, Llamada unaLlamada)
        { }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        { }

        public float CostoLlamada
        {
            get { return this.calcularCosto(); }
        }


        private float calcularCosto()
        {
            float valor;
            valor = this._duracion * (float)this._franjaHoraria;
            return valor;
        }

        public void Mostrar()
        {
            base.Mostrar();
            StringBuilder texto = new StringBuilder("\nFranja : " + this._franjaHoraria + "\tCosto de la llamada : " + this.CostoLlamada);
        }
            
    }
}
