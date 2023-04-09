using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Quark___Biblioteca
{

    internal class Prestamo
    {
        //Posee ejemplar, socio, fecha de prestamo
        private int fechaDePrestamo; //son 5 dias
        //private Libro ejemplar;
        //private Socio socio;

        public int FechaDePrestamo { get => fechaDePrestamo; set => fechaDePrestamo = value; }
        
        //Generar constructor que tome como parametro al socio y al ejemplar
        public Prestamo(string socio, int ejemplar, int fecha) 
        {
            //this.socio = socio;
            //this.ejemplar = ejemplar;
            this.fechaDePrestamo= fecha;
        }
    }
}
