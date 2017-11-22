using System;


namespace Camaras
{
    class CamaraWEB : Camara
    {
        string resolucion, valorZoom;
        public CamaraWEB(string m, string o, int p, string res, string zoom)
            : base(m, o, p)
        {
            resolucion = res;
            valorZoom = zoom;
        }
        public void escribe()
        {
            Console.WriteLine("Marca: " + getMarca() + "\nObjetivo: " + getObjetivo() + "\nPeso: " + getPeso() + "\nresolución: " + resolucion + "\nValor zoom: " + valorZoom);
        }
        public void vacia()
        {
            vaciarCam();
            resolucion = "";
            valorZoom = "";
        }
        public string getRes() { return resolucion; }
        public void cambioRes(string res)
        {
            resolucion = res;
        }
        
    }
   
}
