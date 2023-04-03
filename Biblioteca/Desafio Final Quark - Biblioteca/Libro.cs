using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Quark___Biblioteca
{
    internal class Libro:Ejemplar
    {
        private String nombre;
        private int ISBN;
        private String autor;
        private int ejemplaresPrestamo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public string Autor { get => autor; set => autor = value; }
        public int EjemplaresPrestamo { get => ejemplaresPrestamo; set => ejemplaresPrestamo = value; }
        
        public void AgregarEjemplar()
        {

        }

        public bool EjemplaresDisponibles()
        {
            return false;
        }

        public void PrestarEjemplar()
        {

        }

        public void ReingresoEjemplar()
        {

        }
        
    }
}
