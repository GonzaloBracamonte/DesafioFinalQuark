using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Quark___Biblioteca
{
    internal class SocioVIP: Socio
    {
        private int cuotaMensual;
        //La cantidad maxima de retiro SocioVIP es de 3

        public int CuotaMensual { get => cuotaMensual; set => cuotaMensual = value; }
    
        public int Prueba()
        {
            return Id;
        }
    }
}
