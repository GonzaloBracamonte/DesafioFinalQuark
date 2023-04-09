using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Quark___Biblioteca
{
    internal class Socio
    {
        private String nombre;
        private String apellido;
        private int id;
        private String ejemplaresRetirados;
        private int cantidadMaximaDeRetiro; 
        private bool membresiaVIP;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
        public string EjemplaresRetirados { get => ejemplaresRetirados; set => ejemplaresRetirados = value; }
        public int CantidadMaximaDeRetiro { get => cantidadMaximaDeRetiro; set => cantidadMaximaDeRetiro = value; }

        public bool CupoDisponible(bool membresia)
        {
            if(membresia)
            {
                Console.WriteLine("Puede retirar hasta 3 libros");
                return true;

            }
            else
            {
                Console.WriteLine("Puede retirar solo 1 libro");
                return false;
            }
        }

        public void PrestamoEjemplar()
        {

        }

        public void DevolverEjemplar()
        {

        }
    }
}
