using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              
        private void suma_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Sumar suma = new Sumar(); //instancie, o
                                      //hice un nuevo objeto suma
                                      //llamar al metodo de clase
                                      //suma operar
            textBox3.Text = suma.operar
            (int.Parse(textBox1.Text), 
            int.Parse(textBox2.Text)).ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Restar resta = new Restar(); //instancie, o
                                      //hice un nuevo objeto suma
                                      //llamar al metodo de clase
                                      //suma operar
            textBox3.Text = resta.operar
            (int.Parse(textBox1.Text),
            int.Parse(textBox2.Text)).ToString();
        }

        private void Mulriplicar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Multiplicar multi = new Multiplicar(); //instancie, o
                                      //hice un nuevo objeto suma
                                      //llamar al metodo de clase
                                      //suma operar
            textBox3.Text = multi.operar
            (int.Parse(textBox1.Text),
            int.Parse(textBox2.Text)).ToString();
        }

        private void Limpa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
