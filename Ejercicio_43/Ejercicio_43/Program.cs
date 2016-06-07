using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
    class Program
    {
        static void Main(string[] args)
        {
           // Colectivo colectivo = new Colectivo();
            cortaDistancia microUno = new cortaDistancia("ABC123","Mercedez-Benz",28);
            mediaDistancia microDos = new mediaDistancia("BBB123","WolskVagen",50);
            largaDistancia microTres = new largaDistancia("CCC555","Marcopolo",78);
            int opcion;
            double opcionDos;
            string destino;
            bool salir = false;

            do
            {
                
                Console.Clear();
                Console.WriteLine("\t\t\t       Menu De Viajes\n\nLugar de salida : Retiro\n");
                Console.WriteLine("Viaje de: (1) Corta Distancia (2) Media Distancia (3) Larga Distancia (4) Salir.");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1 :
                        Console.Clear();
                        Console.WriteLine("\t\t\tMenu De Viajes De Corta Distancia\n");
                        Console.WriteLine("Indique cantidad de pasajes vendidos: ");
                        opcionDos = int.Parse(Console.ReadLine());
                        if(Colectivo.ValidarAsientos(microUno.CantidadDeAsientos, opcionDos) == false)
                        {
                            
                            Console.WriteLine("Supera maximo de pasajeros permitido\n");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            microUno.CantidadDePasajeros = opcionDos;
                        }
                        Console.WriteLine("Destino : (1) Avellaneda (2) San Justo (3) Escobar (4) Volver");
                        destino = Console.ReadLine();
                        if(destino=="1")
                        {
                            microUno.Destino = "Avellaneda";
                            microUno.PrecioPasajes = 8;
                            microUno.SetearKm(9);
                        }
                        else if (destino == "2")
                        {
                            microUno.Destino = "San Justo";
                            microUno.PrecioPasajes = 15;
                            microUno.SetearKm(28);
                        }
                        else if(destino=="3")
                        {
                            microUno.Destino = "Escobar";
                            microUno.PrecioPasajes = 25;
                            microUno.SetearKm(50);
                        }
                        else if(destino=="4")
                        {
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Destino inexsistente\n");
                        }
                        Console.Clear();
                        microUno.Mostrar();
                        Console.ReadKey();
                        break;
                    case 2 :
                        Console.Clear();
                        Console.WriteLine("\t\t\tMenu De Viajes De Media Distancia\n");
                        Console.WriteLine("Indique cantidad de pasajes vendidos: ");
                        opcionDos = int.Parse(Console.ReadLine());
                        if(Colectivo.ValidarAsientos(microDos.CantidadDeAsientos, opcionDos) == false)
                        {
                            
                            Console.WriteLine("Supera maximo de pasajeros permitido\n");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            microDos.CantidadDePasajeros = opcionDos;
                        }
                        Console.WriteLine("Destino : (1) Zarate (2) Chivilcoy (3) Cañuelas (4) Volver");
                        destino = Console.ReadLine();
                        if(destino=="1")
                        {
                            microDos.Destino = "Zarate";
                            microDos.PrecioPasajes = 50;
                            microDos.SetearKm(90);
                        }
                        else if (destino == "2")
                        {
                            microDos.Destino = "Chivilcoy";
                            microDos.PrecioPasajes = 90;
                            microDos.SetearKm(173);
                        }
                        else if(destino=="3")
                        {
                            microDos.Destino = "Escobar";
                            microDos.PrecioPasajes = 40;
                            microDos.SetearKm(70);
                        }
                        else if(destino=="4")
                        {
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Destino inexsistente\n");
                        }
                        Console.Clear();
                        microDos.Mostrar();
                        Console.ReadKey();
                        break;                    
                        
                    case 3 :
                        Console.Clear();
                        Console.WriteLine("\t\t\tMenu De Viajes De Larga Distancia\n");
                        Console.WriteLine("Indique cantidad de pasajes vendidos: ");
                        opcionDos = int.Parse(Console.ReadLine());
                        if(Colectivo.ValidarAsientos(microTres.CantidadDeAsientos, opcionDos) == false)
                        {
                            
                            Console.WriteLine("Supera maximo de pasajeros permitido\n");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            microTres.CantidadDePasajeros = opcionDos;
                        }
                        Console.WriteLine("Destino : (1) Mar Del Plata (2) Rosario (3) Bahia Blanca (4) Volver");
                        destino = Console.ReadLine();
                        if(destino=="1")
                        {
                            microTres.Destino = "Mar Del Plata";
                            microTres.PrecioPasajes = 890;
                            microTres.SetearKm(415);
                        }
                        else if (destino == "2")
                        {
                            microTres.Destino = "Rosario";
                            microTres.PrecioPasajes = 570;
                            microTres.SetearKm(300);
                        }
                        else if(destino=="3")
                        {
                            microTres.Destino = "Bahia Blanca";
                            microTres.PrecioPasajes = 1020;
                            microTres.SetearKm(640);
                        }
                        else if(destino=="4")
                        {
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Destino inexsistente\n");
                        }
                        Console.Clear();
                        microTres.Mostrar();
                        Console.ReadKey();
                        break;
                        
                    case 4 :
                        Console.Clear();
                        Console.WriteLine("\t\t\t           Salir.\nConfirme salida: Si(s)||No(n)");
                        if(Console.ReadLine()=="s")
                        {
                            salir = true;
                        }
                        break;
                }
            } while (salir != true);

            
            Console.ReadKey();
        }
    }
}
