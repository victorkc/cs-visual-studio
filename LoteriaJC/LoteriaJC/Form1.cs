using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaJC
{
    public partial class Form1 : Form
    {
        ArrayList arrayCheckBox = new ArrayList();
        ArrayList arrayNumeros = new ArrayList();
        int seleccionMaxima, seleccionCajas = 0;
        bool fechaCorrecta = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            arrayCheckBox.Add(caja1);
            arrayCheckBox.Add(caja2);
            arrayCheckBox.Add(caja3);
            arrayCheckBox.Add(caja4);
            arrayCheckBox.Add(caja8);
            arrayCheckBox.Add(caja7);
            arrayCheckBox.Add(caja6);
            arrayCheckBox.Add(caja5);
            arrayCheckBox.Add(caja12);
            arrayCheckBox.Add(caja11);
            arrayCheckBox.Add(caja10);
            arrayCheckBox.Add(caja9);
            arrayCheckBox.Add(caja16);
            arrayCheckBox.Add(caja15);
            arrayCheckBox.Add(caja14);
            arrayCheckBox.Add(caja13);

            for (int i = 1; i <= 16; i++)
                arrayNumeros.Add(i); //luego poner a 0 y sumar 1 al poner numeros.

        }
        private void borrarTodo()
        {
            for (int i = 0; i < 16; i++)
            {
                ((CheckBox)arrayCheckBox[i]).Checked = false;
            }
        }

        private void boxApuesta_SelectedIndexChanged(object sender, EventArgs e) //SELECCION
        {
            radioButtonManual.Enabled = true;
            radioButtonAutomatica.Enabled = true;
            fecha.Enabled = true;
            apuestaLoteria.Enabled = true;
            button1.Enabled = true;
            reintegro.Enabled = true;

            Random rnd = new Random();
            int eleccionCaja;
            eleccionCaja = rnd.Next(1, 10);
            reintegro.Text = eleccionCaja.ToString();

            for (int i = 0; i < 16; i++)
                ((CheckBox)arrayCheckBox[i]).Enabled = true;
            borrarTodo();

            if (boxApuesta.SelectedIndex == 0)
                seleccionMaxima = 4;
            else
                if (boxApuesta.SelectedIndex == 1)
                seleccionMaxima = 6;
            else
                if (boxApuesta.SelectedIndex == 2)
                seleccionMaxima = 8;
            if (radioButtonAutomatica.Checked)
            {
                for (int i = 0; i < 16; i++)
                {
                    ((CheckBox)arrayCheckBox[i]).Enabled = false;
                    ((CheckBox)arrayCheckBox[i]).Checked = false;
                    for (int j = 0; j < seleccionMaxima; j++)
                    {
                        eleccionCaja = rnd.Next(0, 15);
                        ((CheckBox)arrayCheckBox[eleccionCaja]).Checked = true;
                    }
                }
            }

        }
        private void radioButtonManual_CheckedChanged_1(object sender, EventArgs e) //MANUAL
        {
            if (radioButtonManual.Checked)
            {
                for (int i = 0; i < 16; i++)
                {
                    ((CheckBox)arrayCheckBox[i]).Enabled = true;
                    ((CheckBox)arrayCheckBox[i]).Checked = false;
                }
            }
        }

        private void radioButtonAutomatica_CheckedChanged_1(object sender, EventArgs e)//AUTOMATICO
        {
            if (radioButtonAutomatica.Checked)
            {
                Random rnd = new Random();
                int eleccionCaja;

                for (int i = 0; i < 16; i++)
                {
                    ((CheckBox)arrayCheckBox[i]).Enabled = false;
                    ((CheckBox)arrayCheckBox[i]).Checked = false;
                    for (int j = 0; j < seleccionMaxima; j++)
                    {
                        eleccionCaja = rnd.Next(0, 15);
                        ((CheckBox)arrayCheckBox[eleccionCaja]).Checked = true;
                    }
                }
            }
        }

        private void revisaCaja(ref CheckBox box) //AUMENTA O REDUCE LA SELECCION DE CAJAS
        {
            if (box.Checked)
            {
                if (seleccionCajas >= seleccionMaxima)
                    box.Checked = false;
                seleccionCajas++;
                //reintegro.Text = seleccionCajas.ToString();
            }
            else
                seleccionCajas--;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja1);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja2);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja3);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja4);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja5);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja6);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja7);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja8);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja9);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja10);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja11);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja12);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja13);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja14);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja15);
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            revisaCaja(ref caja16);
        }

        private void button1_Click(object sender, EventArgs e) // VALIDAR APUESTA
        {
            if (fechaCorrecta == false || seleccionMaxima != seleccionCajas)
            {
                string mensage = "Los datos de la fecha o numero de selecciones es incorrecta";
                string titulo = "Error de datos";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show(mensage, titulo, opciones, MessageBoxIcon.Error);
            }
            else
            {
                groupBox2.Enabled = true;
                apuestaLoteria.Enabled = false;
                resguardo.BeginUpdate(); //Añade cosas a la lista
                
                resguardo.Items.Add("Reintegro " + reintegro.Text);
                for (int i = 0; i <16; i++)
                    if (((CheckBox)arrayCheckBox[i]).Checked)
                        resguardo.Items.Add("Número: " + (i+1));
                
                
                resguardo.EndUpdate(); // Repinta y muestra los nuevos objetos.
            }
        }

        private void apostar_Click(object sender, EventArgs e) // APOSTAR DE NUEVO
        {
            boxApuesta.SelectedIndex = -1;
            groupBox2.Enabled = false;
            apuestaLoteria.Enabled = true;

            radioButtonManual.Enabled = false;
            radioButtonAutomatica.Enabled = false;
            fecha.Enabled = false;
            button1.Enabled = false;
            reintegro.Enabled = false;
            reintegro.Text = "";
            borrarTodo();
            seleccionCajas = 0;
            fecha.Value = DateTime.Today;
            for (int i = 0; i < 16; i++)
                ((CheckBox)arrayCheckBox[i]).Enabled = false;


            }

        private void salir_Click(object sender, EventArgs e) // SALIR DE APLICACION
        {
            string mensage = "¿Realmente desea salir ? ";
            string titulo = "Salir";
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensage, titulo, opciones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fecha_ValueChanged(object sender, EventArgs e) // FECHA CHECKEO
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaElegida = fecha.Value;
            int result = DateTime.Compare(fechaElegida, fechaHoy);
            if (result < 0)
            {
                fechaCorrecta = false;
                string mensage = "La fecha debe ser igual o mayor a la fecha actual.";
                string titulo = "Error de fecha";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show(mensage, titulo, opciones, MessageBoxIcon.Error);
            }
            else
                fechaCorrecta = true;
        }
    }
}
