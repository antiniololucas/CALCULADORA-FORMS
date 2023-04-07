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

            if (operacion == 1) {
                resultado = Convert.ToInt32(primerNum) + Convert.ToInt32(segundoNum); }
            else if (operacion == 2) {
                resultado = Convert.ToInt32(primerNum) - Convert.ToInt32(segundoNum); }
            else if (operacion == 3) {
                resultado = Convert.ToInt32(primerNum) / Convert.ToInt32(segundoNum); }
            else { 
                resultado = Convert.ToInt32(primerNum) * Convert.ToInt32(segundoNum);}
            
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
