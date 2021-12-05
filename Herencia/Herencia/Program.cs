using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Tomas", 20);
            Jugador jugador = new Jugador("Chacarita","Carpincho Malvado",20);
            Persona jugador2 = new Jugador("HLH", "Carpincho Malvado", 20);

            Console.WriteLine($"Persona: {persona.Mostrar()}");
            Console.WriteLine($"Jugador: {jugador.MostrarJugador()}");
            Console.WriteLine($"Jugador2: {((Jugador)jugador2).MostrarJugador()}");
        }
    }
    public class Persona
    {
        public string nombre;
        public int edad;
        private string direccion;
        public Persona(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        
        public string Mostrar()
        {
            return $"Nombre {nombre} - Edad {edad}";
        }
    }
    public class Jugador : Persona
    {
        string equipo;
        public Jugador(string equipo,string nombre,int edad):base(nombre,edad)
        {
            this.equipo = equipo;
        }
        public string MostrarJugador()
        {
            return $"{base.Mostrar()} - Equipo {equipo}";
        }

    }
}
