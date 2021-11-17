using BibliotecaDeClases;
using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Joni",25000);
            Console.WriteLine(cuenta.Mostrar());
            cuenta.Ingresar(3000);
            Console.WriteLine(cuenta.Mostrar());
            cuenta.Retirar(30000);
            Console.WriteLine(cuenta.Mostrar());
        }
    }
}
