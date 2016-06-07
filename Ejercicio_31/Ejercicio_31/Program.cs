using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro LibroI = new Libro("1", "El Escarabajo De Oro", "E. A. Poe", "Atlantida", 20);
            Libro LibroII = new Libro("2", "Rayuela", "J. Borges", "Rio De La Plata", 35);
            Libro LibroIII = new Libro("3", "Cielo Azul", "V. Mortensen", "SerteFacil", 1);
            List<Libro> ListaDeLibros = new List<Libro>();
            
            string respuesta;
            string dato;
            bool rta = false;
            int opcion;
            string ISBN;

            ListaDeLibros.Add(LibroI);
            ListaDeLibros.Add(LibroII);
            ListaDeLibros.Add(LibroIII);
            
            Console.WriteLine("\t\t\t      BIBLIOTECA\n\n");



            do
            {
                
                Console.WriteLine("Menu de opciones : (1) Prestamos || (2) Devoluciones || (3) Salir\n");
                dato = Console.ReadLine();
                int.TryParse(dato, out opcion);
                while(opcion != 1 && opcion != 2 && opcion != 3)
                {
                    Console.WriteLine("Opcion incorrecta. Reingrese:");
                    dato = Console.ReadLine();
                    int.TryParse(dato, out opcion);
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese ISBN: ");
                        ISBN = Console.ReadLine();
                        Libro.Prestar(ListaDeLibros, ISBN);
                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Devolucion de libro prestado.\n\nIngrese ISBN: ");
                        ISBN = Console.ReadLine();
                        Libro.Devolver(ListaDeLibros, ISBN);
                        break;

                    case 3:
                        Console.WriteLine("Desea salir del programa ? S = si || N = no");
                        respuesta = Console.ReadLine();
                        while (respuesta != "S" && respuesta != "N")
                        {
                            Console.WriteLine("Desea salir del programa ? S = si || N = no");
                            respuesta = Console.ReadLine();
                        }
                        if (respuesta == "S")
                        {
                            rta = true;
                        }

                        break;
                }
                
            } while (rta == false);

            Console.ReadKey();


        }
    }
}
