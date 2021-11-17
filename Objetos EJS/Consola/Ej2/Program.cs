using BibliotecaDeClases;
using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante("Joni","Mujica","204377-1");
            Estudiante est2 = new Estudiante("Javi", "escalada", "48342-4");
            Estudiante est3 = new Estudiante("Yamila", "Jurado", "196751-7");

            est1.SetNotaPrimerParcial(7);
            est1.SetNotaSegundoParcial(8);
            est2.SetNotaPrimerParcial(5);
            est2.SetNotaSegundoParcial(3);
            est3.SetNotaPrimerParcial(8);
            est3.SetNotaSegundoParcial(9);

            Console.WriteLine(est1.Mostrar());
            Console.WriteLine(est2.Mostrar());
            Console.WriteLine(est3.Mostrar());
        }
    }
}
