using BibliotecaDeClases;
using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            int res = calculadora.Sumar(2, 5);
            Console.WriteLine(res);

            res = calculadora.Sumar(2,5,9);

            Console.WriteLine(res);

            Tiempo t1 = new Tiempo();
            Tiempo t2 = new Tiempo(23, 15, 8);
            Tiempo t3 = new Tiempo(23, 15, 8);
            Tiempo t4 = t1;
            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1.Equals(t4));
            Console.WriteLine("============================");
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
            Console.WriteLine(t3 == t2);
            Console.WriteLine(t3 != t2);

            
            float f = 4.5f;
            int i = (int)t2; //Conversion explicita
            /*
            int entero = 1;
            float flotante = entero; //Conversion implicita
            */
            int hora = 12;
            Tiempo t5 = hora; //Conversion implicita
            Console.WriteLine(i);

            Console.WriteLine(t5.GetHora());
            Console.WriteLine(t5.GetMinutos());
        }
    }
}
