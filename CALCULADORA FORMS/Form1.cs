using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       LogicaCalculadora Calculadora = new LogicaCalculadora();

        //Botones especiales de operar
        private void btnSuma_Click(object sender, EventArgs e)
        {
            Calculadora.generarOperacion(1);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Calculadora.generarOperacion(2);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Calculadora.generarOperacion(3);
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            Calculadora.generarOperacion(4);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string res = Calculadora.Igual();
            if (res != "0")
            {
                visor.Text = res;
            }
        }


        //10 BUTTONS DE NUMEROS
        private void button0_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            visor.Text = Calculadora.refljearOperacion("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.refljearOperacion("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
           visor.Text = Calculadora.refljearOperacion("9");
        }
        
        public void cambiarVisor (string contenido)
        {
            visor.Text = contenido;
        }


        //AC
        private void btnDel_Click(object sender, EventArgs e)
        {
            visor.Text = Calculadora.eliminar();
        }

        //Restart
        private void btnAC_Click(object sender, EventArgs e)
        {
            Calculadora.limpiar();
            visor.Text = "";
        }
    }
    }

