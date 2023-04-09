using Desafio_Final_Quark___Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Quark___Biblioteca
{
    internal class Libro
    {
        private String nombre;
        private int ISBN;
        private String autor;
        private List<Libro> libros = new List<Libro>();
        private List<Ejemplar> ejemplares = new List<Ejemplar>();
        private List<Prestamo> prestados = new List<Prestamo>();


        public string Nombre { get => nombre; set => nombre = value; }
        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public string Autor { get => autor; set => autor = value; }
        internal List<Libro> Libros { get => libros; }
        internal List<Ejemplar> Ejemplares { get => ejemplares; }
        internal List<Prestamo> Prestados { get => prestados; }

        public void AgregarEjemplar(Libro libro)
        {
            libros.Add(libro);
        }
  
        public bool EjemplaresDisponibles(Ejemplar ejemplar)
        {
            
            if(ejemplar > 0)
            {
                Console.WriteLine("Se puede retirar un ejemplar");
                return true;
            }
            else
            {
                Console.WriteLine("No es posible retirar un ejemplar");
                return false;
            }
        }

        public void PrestarEjemplar(Ejemplar ejemplar )
        {
            ejemplares.Remove(ejemplar);
            prestados.Add(ejemplar);
        }

        public void ReingresoEjemplar(Ejemplar ejemplar)
        {
            prestados.Remove(ejemplar);
            ejemplares.Add(ejemplar);
        }

    }
}
