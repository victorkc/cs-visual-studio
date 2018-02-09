using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInformatica
{
    class Ordenador : Producto
    {
        private float velocidad;
        private int puertos;

        public Ordenador() : base("Ninguna", "DELL", 2000, 400)
        {

        }

        public Ordenador(string m, string n, int r, float p, float v, int puer) : base(m, n, r, p)
        {
            velocidad = v;
            puertos = puer;
        }

        public override string Escribe()
        {
            return base.Escribe() +
                " Velocidad: " + velocidad + 
                " Puertos: " + puertos;
        }

    }
}
