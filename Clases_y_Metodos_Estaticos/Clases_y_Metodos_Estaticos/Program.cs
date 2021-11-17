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

        }
    }
}
