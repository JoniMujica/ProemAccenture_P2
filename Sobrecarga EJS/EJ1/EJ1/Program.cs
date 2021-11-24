using BibliotecaDeClases;
using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(7);
            long test1 = s1.Sumar(4, 6);
           // int a = (int)s1;
            Console.WriteLine("{0} : {1}", test1, (int)s1);

            Sumador s2 = new Sumador(7);
            Sumador s3 = new Sumador(7);

            bool d = s2 | s3;
            Console.WriteLine(d);

            long res = s2 + s3;
            Console.WriteLine(res);
        }
    }
}
