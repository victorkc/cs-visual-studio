using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInformatica
{
    class Producto
    {
        private string marca, nombre;
        private float precio;
        private int ram;

        public Producto()
        {
            marca = "VACIA";
            nombre = "NINGUNO";
            precio = 0;
            ram = 0;
        }

        public Producto(string m, string n, int r, float p)
        {
            marca = m;
            nombre = n;
            ram = r;
            precio = p;
        }

        virtual public string Escribe()
        {
            return "Marca: " + marca +
                " Nombre: " + nombre +
                " Precio: " + precio +
                " RAM: " + ram;
        }

    }
}
