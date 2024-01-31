using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_FORMS
{
    public class LogicaCalculadora
    {

        bool isPrimerNum = false;
        string primerNum = "";
        string segundoNum = "";
        int operacion = 0;
        int resultado = 0;

        public void generarOperacion(int op)
        {
            isPrimerNum=true;
            operacion = op;
        }

        //Funcion para hacer la cuenta
        public int operar(int operacion, string primerNum, string segundoNum)
        {
          
            switch (operacion) {
                case 1:
                    return Convert.ToInt32(primerNum) + Convert.ToInt32(segundoNum);
                case 2:
                    return Convert.ToInt32(primerNum) - Convert.ToInt32(segundoNum);
                case 3:
                    return Convert.ToInt32(primerNum) / Convert.ToInt32(segundoNum);
                case 4:
                    return Convert.ToInt32(primerNum) * Convert.ToInt32(segundoNum);
                default : return 0;
            }
        }

        public string refljearOperacion(string nro)
        {
            if (!isPrimerNum)
            {
                primerNum = sumarValor(nro, primerNum);
                return  primerNum.ToString() ;
            }
            else
            {
                segundoNum = sumarValor(nro, segundoNum);
                return segundoNum.ToString();
            }
        }
        //Funcion para registar los numeros a operar
        public string sumarValor(string nro, string Num)
        {
            return Num + nro;
        }

        internal string eliminar()
        {
            if (isPrimerNum == false && primerNum.Length > 0)
            {
                primerNum = primerNum.Remove(primerNum.Length - 1);
                return primerNum.ToString();
            }
            else if (segundoNum.Length > 0)
            {
                segundoNum = segundoNum.Remove(segundoNum.Length - 1);
                return segundoNum.ToString();
            }
                return "";
        }

        internal string Igual()
        {
            if (segundoNum == null)
            {
                return "0";
            }
            else
            {
                resultado = operar(operacion, primerNum, segundoNum);
                primerNum = resultado.ToString();
                segundoNum = "";
                operacion = 0;
                return resultado.ToString();
            }
        }

        internal void limpiar()
        {
            primerNum = "";
            segundoNum = "";
            isPrimerNum = false;
        }
    }
}
