using Biblioteca;
using System;

namespace introduccion_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = Calculadora.sumar(2, 5);
            Console.WriteLine(resultado);

            string[] arr = { "banana", "pera", "manzana", "naranja" };
            foreach (string x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
