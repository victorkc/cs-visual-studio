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
        public void nuevoPrograma(string n, string tc, int d) //CREA UN NUEVO PROGRAMA TV
        {
            nombre = n;
            tipoContenidos = tc;
            duracion = d;
        }
        public void borrarPrograma() //BORRA PROGRAMA TV
        {
            nombre = "Nada";
            tipoContenidos = "Nada";
            duracion = 0;
        }
        public void modDuracion(int n) //CAMBIA LA DURACION
        {
            duracion += n;
        }
        public string escribir() //DICE LOS DATOS DEL PROGRAMA
        {
            return ", Nombre de programa: " + nombre + ", duración: " + Convert.ToString(duracion) + " min, tipo: " + tipoContenidos;
            //Console.WriteLine(nombre + ", duración: " + duracion + ", tipo: " + tipoContenidos);
        }
        public int duracionPrograma() //DEVUELVE LA DURACION
        {
            return duracion;
        }

    }
}
