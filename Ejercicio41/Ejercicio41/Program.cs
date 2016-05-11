using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            SerHumano UnHumano = new SerHumano("Franco", "Masculino");
            Gerente OtroHumano = new Gerente(36, "Norberto", "Masculino");
            Empleado OtroHumanoMas = new Empleado(400, "Natalia", "Femenino");


            Gerente NuevoGerente = new Gerente(OtroHumanoMas);

            UnHumano.MostrarString();
            UnHumano.Comer();
            UnHumano.Dormir();

            OtroHumano.MostrarString();
            OtroHumano.Comer();
            OtroHumano.Dormir();
            OtroHumano.EsMayor();

            OtroHumanoMas.MostrarString();
            OtroHumanoMas.Comer();
            OtroHumanoMas.Dormir();
            OtroHumanoMas.SueldoMayor();

            NuevoGerente.MostrarString();

            Console.ReadKey();
        }
    }
}