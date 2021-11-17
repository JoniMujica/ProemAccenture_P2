using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static string Calcular(float operandoA,float operandoB,string operador)
        {
            string resultado;   
            switch (operador)
            {
                case "+":
                    resultado = (operandoA + operandoB).ToString();
                    break;
                case "-":
                    resultado = (operandoA - operandoB).ToString();
                    break;
                case "*":
                    resultado = (operandoA * operandoB).ToString();
                    break;
                case "/":
                    if (Validar(operandoB))
                    {
                        resultado = (operandoA + operandoB).ToString();
                    }
                    else
                    {
                        resultado = "No se puede dividir por 0!";
                    }
                    break;

                default:
                    resultado =  "ERROR, operador invalido!!";
                    break;
            }
            return resultado;
        }
        private static bool Validar(float operandoB)
        {
            return (operandoB != 0);
        }
    }
}
