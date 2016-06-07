using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
    class largaDistancia:Colectivo
    {
        private double _cantidadDePasajeros;
        private string _destino;
        private double _precioPasajes;
        

        public double CantidadDePasajeros
        {
            get { return this._cantidadDePasajeros; }
            set { this._cantidadDePasajeros = value; }
        }

        public double PrecioPasajes
        {
            get { return this._precioPasajes; }
            set { this._precioPasajes = value; }
        }

        public string Destino
        {
            get { return this._destino; }
            set { this._destino = value; }
        }
        public largaDistancia(string patente, string marca, double cantidadAsientos):base(patente,marca,cantidadAsientos)
        { }

        private double calcularGanancia()
        {
            double total;
            total = this._precioPasajes * this._cantidadDePasajeros;
            return total;
        }

        public override void SetearKm(double km)
        {
            this._distancia = km;
        }

        public override double indicarVelocidad()
        {
            double velProm = 80;
            return velProm;
        }

        private Single calculaLlegada()
        {
            Single llegada;
            return llegada = (Single)(this._distancia / this.indicarVelocidad()) * 60;
        }

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t        Viaje Larga Distancia");
            Console.WriteLine("\nDatos del Micro:\nMarca: " + this._marca + "\tPatente: " + this._patente + "\tCantidad de asientos: " + this._cantidadDeAsientos);
            Console.WriteLine("\nDatos del Viaje:\nDestino: " + this._destino + "\tPrecio del boleto: $" + this._precioPasajes + "\tBoletos vendidos: " + this._cantidadDePasajeros + "\nDistancia (km): " + this._distancia + "\tTiempo de viaje: " + this.calculaLlegada() + " Min." + "\tGanancia total: $" + this.calcularGanancia());
        }
        
    }
}
