using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDePc
{
    class Computadora
    {
        private bool _estaEncendida = false;
        private CPU.EMarca _marca;
        private float _peso;
        private CPU.EProcesador _procesador;

        public Computadora(bool Encendida, CPU.EMarca Marca, float Peso, CPU.EProcesador Procesador)
        {
            this._estaEncendida = Encendida;
            this._marca = Marca;
            this._peso = Peso;
            this._procesador = Procesador;
        }
        public bool getEncendido()
        {
            return this._estaEncendida;
        }
        
        public CPU.EMarca getMarca()
        {
            return this._marca;
        }
        
        public float getPeso()
        {
            return this._peso;
        }

        public CPU.EProcesador getProcesador()
        {
            return this._procesador;
        }

        public void setEncendido(bool encendido)
        {
            this._estaEncendida = encendido;
        }

        public void setMarca(CPU.EMarca marca)
        {
            this._marca = marca;
        }

        public void setPeso(float peso)
        {
            this._peso = peso;
        }

        public void setProcesador(CPU.EProcesador procesador)
        {
            this._procesador = procesador;
        }
    }
}

namespace CPU
{
    enum EMarca
    {
        Asus, Apple, Samsung, Toshiba, IBM
    }

    enum EProcesador
    {
        Intel_Core_I7, ADM_Phenom_II, ADM_Athlon_II, Intel_Celeron_430, ADM_Sempron_145
    }
}