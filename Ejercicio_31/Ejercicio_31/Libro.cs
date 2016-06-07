using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Libro
    {
        private string _ISBM;
        private string _titulo;
        private Autor _autor = new Autor();
        private Editorial _editorial = new Editorial();
        private Int64 _cantidadEjemplares;
         
        

        public Libro()
        { }
        public Libro(string indice, string titulo, string autor, string editorial, Int64 cantidad)
        {
            this._ISBM = indice;
            this._titulo = titulo;
            this._autor.NombreAutor = autor;
            this._editorial.NombreEditorial = editorial;
            this._cantidadEjemplares = cantidad;       
        }

        public static void Prestar(List<Libro> Lista,string indice)
        {
            

            foreach (Libro item in Lista)
            {
                if (item._ISBM == indice)
                {
                    Console.WriteLine("\nLibro : " + item._titulo + "\nAutor : " + item._autor.NombreAutor);
                    if(item._cantidadEjemplares > 1)
                    {
                        Console.WriteLine("\nEste Libro se puede prestar...\n\nConfirma prestamo?\nSi(s) || No(n)");
                        if(Console.ReadLine()=="s")
                        {
                            Console.WriteLine("Libro prestado!!!");
                            item._cantidadEjemplares--;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Este libro no se puede prestar\n");
                    }
                }

            }
        }

        public static void Devolver(List<Libro> Lista, string indice)
        {
            foreach (Libro item in Lista)
            {
                if(item._ISBM == indice)
                {
                    Console.WriteLine("\nLibro : " + item._titulo + "\nAutor : " + item._autor.NombreAutor);
                    Console.WriteLine("\nConfirmando devolucion... \n\nDevolucion ok");
                    item._cantidadEjemplares++;
                    Console.Write("Cantidad de ejemplares de libro : " + item._titulo + " actualizado, ahora cuenta con " + item._cantidadEjemplares + " ejemplares.\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Error... ISBN sin informacion en base de datos.\n");
                    break;
                }
            }
        }
        
       
        
        
       

 

    }
}
