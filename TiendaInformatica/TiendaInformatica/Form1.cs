using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaInformatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Producto p1 = new Producto("Samsung", "Galaxy", 2, 259),
                     p2 = new Producto("Samsung", "Galaxy", 2, 259);

            Ordenador o1 = new Ordenador("HP", "skkd", 5, 900, 4, 5);

            //if(p1 is Ordenador) imprimir
            //foreach(Producto p in ) { }
            textBoxResultado.Text = p1.Escribe() + "\r\n";
        }
    }
}
