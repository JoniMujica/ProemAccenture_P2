using BibliotecaDeClases;
using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            Perro perro = new Perro();
            Animal fatiga = new Perro();
            Gato gato = new Gato();
            Animal salen = new Gato();

            //Console.WriteLine(animal.EmitirSonido());
            Console.WriteLine(perro.EmitirSonido());
            Console.WriteLine(perro.Saludar());
            //Console.WriteLine(perro.ToString());
            Console.WriteLine(fatiga.EmitirSonido());
            Console.WriteLine(fatiga.Saludar());

            Console.WriteLine(gato.EmitirSonido());
            Console.WriteLine(gato.Saludar());
            //Console.WriteLine(gato.ToString());
            Console.WriteLine(salen.EmitirSonido());
            Console.WriteLine(salen.Saludar());

        }
    }
}
