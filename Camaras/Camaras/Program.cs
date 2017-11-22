using System;

namespace Camaras
{
    class Program
    {
        static void Main(string[] args)
        {
            CamaraIP camaraip1 = new CamaraIP("Canon","300mm", 5, "172.16.8.45","164.458.356.458");
            CamaraIP camaraip2 = new CamaraIP("Canon", "450mm", 8, "172.15.3.85", "124.158.336.555");
            CamaraWEB camaraWeb1 = new CamaraWEB("Sonya", "350mm", 2,"25Mpx","2.5");
            CamaraWEB camaraWeb2 = new CamaraWEB("Sonya", "550mm", 3,"30Mpx","3.2");

            camaraip1.modPeso();
            camaraip2.modPeso();
            //camaraip1.vacia();
            //camaraip2.vacia();

            camaraip1.cambioIP(camaraip2.getIP());
            camaraip2.cambioMAC(camaraip1.getMAC());
            camaraWeb2.cambioRes(camaraWeb1.getRes());
            camaraWeb1.cambioMarca(camaraip1.getMarca());


            camaraip1.escribe();
            Console.WriteLine();
            camaraip2.escribe();
            Console.WriteLine();
            camaraWeb1.escribe();
            Console.WriteLine();
            camaraWeb2.escribe();
            Console.WriteLine();

            Console.ReadKey();
        }

    }
}
