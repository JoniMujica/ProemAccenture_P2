using Biblioteca;
using BibliotecaDeClases;
using System;
// using SC = System.Console; //ALIAS

namespace Clases_y_Metodos_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // SC.WriteLine("Hello World!"); //uso de ALIAS

            /*
            Cotizador.CotizarVentaDolares(45.2M);

            string texto = Cotizador.MostrarDatos();
            Console.WriteLine(texto);

            */

            ///ej 1
            /*
            int numero = 0;
            string tabla;
            bool CNV = false;
            do
            {
                Console.WriteLine("Ingrese un numero para hacer su tabla de multiplicacion: ");
                CNV = Int32.TryParse(Console.ReadLine(), out numero);
                if (CNV)
                {
                    tabla = Multiplicacion.Multiplicar(numero);
                    Console.WriteLine(tabla);
                }
                else
                {
                    Console.WriteLine("ERROR: el numero ingresado es invalido, por favor ingrese un valor numerico entero");
                }
            } while (!CNV);
            */


            //EJ2
            /*
            float operandoA;
            float operandoB;
            string operador;
            bool cnv = false, cv2 = false, cv3 = false;
            do
            {
                Console.WriteLine("Ingrese el operando A");
                cnv = float.TryParse(Console.ReadLine(), out operandoA);
                Console.WriteLine("Ingrese el operando B");
                cv2 = float.TryParse(Console.ReadLine(), out operandoB);
                Console.WriteLine("Ingrese la operacion:");
                operador = Console.ReadLine();
                if (string.IsNullOrEmpty(operador))
                    cv3 = false;

                string res = Calculadora.Calcular(operandoA, operandoB, operador);
                Console.WriteLine(res);
            } while (cnv && cv2 && cv3);
            */

            //EJERCICIO 3;
            /*
            double cuadrado = CalculadoraDeArea.CalcularAreaCuadrado(7.5);
            double triangulo = CalculadoraDeArea.CalcularAreaTriangulo(6, 4.5);
            double circulo = CalculadoraDeArea.CalcularAreaCirculo(6.5);
            Console.WriteLine("El area del cuadrado de longitud 7.5 es: {0}",cuadrado);
            Console.WriteLine("El area del triangulo de base 6.4 altura 4.5 es: {0}",triangulo);
            Console.WriteLine("El area del circulo de radio 6.5 es: {0}",circulo);
            */

            //EJERCICIO4
            /*
            float Base;
            float altura;
            bool cnv = false, cv2 = false;
            do
            {
                Console.WriteLine("Ingrese la medida de la base en CM");
                cnv = float.TryParse(Console.ReadLine(), out Base);
                Console.WriteLine("Ingrese la medida de la altura en CM");
                cv2 = float.TryParse(Console.ReadLine(), out altura);
            } while (!cnv && !cv2);

            double res = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(altura, 2));
            Console.WriteLine("La longitud de la hipotenusa es: {0}", res);
            */

            string bin = Conversor.ConvertirDecimalABinario(20);
            Console.WriteLine(bin);

            int numeroEntero = 1011010;
            string numStr = numeroEntero.ToString();
            Console.WriteLine(numStr[0]);
        }
    }
}
