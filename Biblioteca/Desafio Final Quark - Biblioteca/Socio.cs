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
        private int cantidadMaximaDeRetiro; 
        private bool membresiaVIP;
        private List<Libro> ejemplarDevuelto = new List<Libro>();
        private List<Prestamo> ejemplarPedido = new List<Prestamo>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
        public int CantidadMaximaDeRetiro { get => cantidadMaximaDeRetiro; set => cantidadMaximaDeRetiro = value; }
        public bool MembresiaVIP { get => membresiaVIP; set => membresiaVIP = value; }
        internal List<Libro> EjemplarDevuelto { get => ejemplarDevuelto; set => ejemplarDevuelto = value; }
        internal List<Prestamo> EjemplarPedido { get => ejemplarPedido; set => ejemplarPedido = value; }

        public bool CupoDisponible(bool membresia, int cantidadRetiro)
        {
            this.membresiaVIP = membresia;
            this.CantidadMaximaDeRetiro = cantidadRetiro;

            if (membresia)
            {
                if(cantidadRetiro >= 3)
                {
                    Console.WriteLine("No puede retirar libros");
                    return false;
                }
                else
                {
                    Console.WriteLine("Puede retirar hasta 3 libros");
                    return true;
                }

            }
            else if (cantidadRetiro >= 1)
            {
                Console.WriteLine("No puede retirar libros");
                return false;
            }
            else
            {
                Console.WriteLine("Puede retirar hasta 1 libro");
                return true;
            }
        }

        public void PrestamoEjemplar(Libro pedido)
        {
            ejemplarPedido.Add(pedido);
        }

        public void DevolverEjemplar(Libro pedido)
        {
            ejemplarPedido.Remove(pedido);
            ejemplarDevuelto.Add(pedido);
        }
    }
}
