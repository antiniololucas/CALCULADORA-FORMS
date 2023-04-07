using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_FORMS
{
    public class Funciones
    {


        //Funcion para hacer la cuenta
        public int operar(int operacion, string primerNum, string segundoNum)
        {
            int resultado = 0;
            switch (operacion)
            {
                case 0: MessageBox.Show("Seleccionar Operacion"); break;
                case 1:
                    resultado = Convert.ToInt32(primerNum) + Convert.ToInt32(segundoNum); break;
                case 2:
                    resultado = Convert.ToInt32(primerNum) - Convert.ToInt32(segundoNum); break;
                case 3:
                    resultado = Convert.ToInt32(primerNum) / Convert.ToInt32(segundoNum); break;
                case 4:
                    resultado = Convert.ToInt32(primerNum) * Convert.ToInt32(segundoNum); break;
                default: resultado = 0; break;
            }
            
            return resultado;
        }

        
        //Funcion para registar los numeros a operar
        public string sumarValor(string nro, string Num)
        {
            
            Num += nro;

            return Num;
        }
    }
}
