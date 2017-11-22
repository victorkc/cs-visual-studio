using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaras
{
    class Camara
    {
        string marca, objetivo;
        int peso;

        public Camara(string m, string o, int p)
        {
            marca = m;
            objetivo = o;
            peso = p;
        }
        public void vaciarCam()
        {
            marca = "";
            objetivo = "";
            peso = 0;
        }
        public string getMarca() { return marca; }
        public string getObjetivo() { return objetivo; }
        public int getPeso() { return peso; }
        public void modPeso() { peso = 12; }
        public void cambioMarca(string marca)
        {
            this.marca = marca;
        }
    }
}
