using System;

namespace BibliotecaDeClases
{
    public class Calculadora
    {
        public int Sumar(int operador1,int operador2)
        {
            return operador1 + operador2;
        }
        public int Sumar(int operador1, int operador2, int operador3)
        {
            return operador1 + operador2 + operador3;
        }
        public float Sumar(float operador1, float operador2)
        {
            return operador1 + operador2;
        }
        public float Sumar(float operador1, float operador2, float operador3)
        {
            return operador1 + operador2 + operador3;
        }
        public string Sumar(float operador1, string mensaje)
        {
            return operador1 + " " + mensaje;
        }
        public float Sumar(string operador1, float operador2)
        {
            return operador2 + float.Parse(operador1);
        }

        public string Sumar(short operando, string usuario)
        {
            return "";
        }
    }
}
