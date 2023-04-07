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

       Funciones funcionesExt = new Funciones();

        bool valPrimerNum = false;
        string primerNum = "";
        string segundoNum = "";
        int operacion = 0;
        int resultado = 0;

        private void btnSuma_Click(object sender, EventArgs e)
        {
            valPrimerNum = true;
            operacion = 1;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            valPrimerNum = true;
            operacion = 2;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valPrimerNum = true;
            operacion = 3;
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            valPrimerNum = true;
            operacion = 4;
        }



        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (segundoNum != null)
            {
                resultado = funcionesExt.operar(operacion, primerNum, segundoNum);
                visor.Text = resultado.ToString();
                primerNum = resultado.ToString();
                segundoNum = "";
                operacion = 0;
            }
            else
            {
                MessageBox.Show("Ingresar operacion deseada y otro numero");
            }
            }

       



        //10 BUTTONS DE NUMEROS
        private void button0_Click(object sender, EventArgs e)
        {
            if(valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("0", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("0", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("1", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("1", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("2", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
               segundoNum = funcionesExt.sumarValor("2", segundoNum);
               visor.Text = segundoNum.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("3", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("3", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("4", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("4", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("5", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("5", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("6", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("6", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("7", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("7", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("8", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("8", segundoNum);
                visor.Text = segundoNum.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false)
            {
                primerNum = funcionesExt.sumarValor("9", primerNum);
                visor.Text = primerNum.ToString();
            }
            else
            {
                segundoNum = funcionesExt.sumarValor("9", segundoNum);
                visor.Text= segundoNum.ToString();
            }
        }




        //AC
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (valPrimerNum == false && primerNum.Length>0)
            {
                primerNum = primerNum.Remove(primerNum.Length-1);
                visor.Text = primerNum.ToString();
            }
            else if(segundoNum.Length>1 && segundoNum.Length>0)
            {
                segundoNum =  segundoNum.Remove(segundoNum.Length-1);
                visor.Text = segundoNum.ToString();
            }
            else
            {
                MessageBox.Show("No puede borrar");
            }
            
        }


        //Restart
        private void btnAC_Click(object sender, EventArgs e)
        {
                primerNum = "";
                segundoNum = "";
                visor.Text = "";
                valPrimerNum = false;
           
        }
    }




    }

