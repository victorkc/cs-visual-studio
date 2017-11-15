using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Programa
    {
        string nombre, tipoContenidos;
        int duracion;
        public Programa()
        {
            nombre = "Nada";
            tipoContenidos = "Nada";
            duracion = 0;
        }
        public void nuevoPrograma(string n, string tc, int d)
        {
            nombre = n;
            tipoContenidos = tc;
            duracion = d;
        }
        public void borrarPrograma()
        {
            nombre = "Nada";
            tipoContenidos = "Nada";
            duracion = 0;
        }
        public void modDuracion(int n)
        {
            duracion += n;
        }
        public string escribir()
        {
            return nombre + ", duración: " + duracion.ToString() + " min, tipo: " + tipoContenidos;
            //Console.WriteLine(nombre + ", duración: " + duracion + ", tipo: " + tipoContenidos);
        }

    }
}
