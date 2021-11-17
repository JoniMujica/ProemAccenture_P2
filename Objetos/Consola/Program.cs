using BibliotecaDeClases;
using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota("lucy",21);

            //Console.WriteLine(Mascota.saludo);
            // Console.WriteLine(mascota.MostrarDatos());
            Console.WriteLine(mascota.GetNombre());
            mascota.SetNombre("Mia");
            Console.WriteLine(mascota.GetNombre());
        }
    }
}
