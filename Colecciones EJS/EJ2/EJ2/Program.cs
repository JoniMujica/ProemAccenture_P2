using BibliotecaDeClases;
using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo(5,"River");
            Jugador j1 = new Jugador(41969931,"Jonathan");
            Jugador j2 = new Jugador(41969931, "Jonathan");
            Jugador j3 = new Jugador(41969931, "Jonathan");
            Jugador j4 = new Jugador(41969931, "Jonathan");
            Jugador j5 = new Jugador(41969931, "Jonathan");

            bool res1 = equipo1 + j1;
            bool res2 = equipo1 + j2;
            bool res3 = equipo1 + j3;
            bool res4 = equipo1 + j4;
            bool res5 = equipo1 + j5;
            if (res1 && res2 && res3 && res4 && res5)
            {
                Console.WriteLine("Se agrego el jugador:\n{0}\n{1}\n{2}\n{3}\n{4}",j1.MostrarDatos(), j2.MostrarDatos(), j3.MostrarDatos(), j4.MostrarDatos(), j5.MostrarDatos());
            }

            if (j1 == j2)
            {
                Console.WriteLine("Tienen el mismo DNI");
            }

        }
    }
}
