using BibliotecaDeClases;
using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dib1,dib2;
            Boligrafo bol1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo bol2 = new Boligrafo(50, ConsoleColor.Red);
            Console.WriteLine(bol1.GetColor());
            Console.WriteLine(bol2.GetColor());
            Console.WriteLine(bol1.GetTinta());
            Console.WriteLine(bol2.GetTinta());
            bool res1 = bol1.Pintar(70,out dib1);
            bool res2 = bol2.Pintar(50, out dib2);
            Console.WriteLine(dib1);
            Console.WriteLine(dib2);
            Console.WriteLine(res2);
            Console.WriteLine(bol2.GetTinta());
            //bol2.Recargar();
            Console.WriteLine(bol2.GetTinta());
            res2 = bol2.Pintar(10, out dib2);
            Console.WriteLine(dib2);
            Console.WriteLine(res2);
            Console.WriteLine(bol2.GetTinta());
        }
    }
}
