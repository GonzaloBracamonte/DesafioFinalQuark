using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Quark___Biblioteca
{
    internal class Ejemplar
    {
        private int numeroDeEdicion;
        private int ubicacion;

        public int NumeroDeEdicion { get => numeroDeEdicion; set => numeroDeEdicion = value; }
        public int Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}
