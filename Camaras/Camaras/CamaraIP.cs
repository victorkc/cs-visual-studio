using System;


namespace Camaras
{
    class CamaraIP : Camara
    {
        string ip, mac;

        public CamaraIP(string m, string o, int p, string ip, string mac)
            : base(m, o, p)
        {
            this.ip = ip;
            this.mac = mac;
        }

        public void escribe()
        {
            Console.WriteLine("Marca: " + getMarca() + "\nObjetivo: " + getObjetivo() + "\nPeso: " + getPeso() + "\nIP: " + ip + "\nMAC: " + mac);
        }
        public void vacia()
        {
            vaciarCam();
            ip = "";
            mac = "";
        }
        public string getIP()
        {
            return ip;
        }
        public void cambioIP(string ip)
        {
            this.ip = ip;
        }
        public string getMAC() { return mac; }
        public void cambioMAC(string mac)
        {
            this.mac = mac;
        }
    }
}
