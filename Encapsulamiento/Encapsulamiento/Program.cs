using System;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona p1 = new Persona(45);
            //p1.Edad = -45;
            Console.WriteLine("La edad es: {0}",p1.Edad);

            Enumeramiento e1 = new Enumeramiento();
            e1.ColorFavorito = Enumeramiento.Color.Azul;
            //e1.ColorFavorito = (Enumeramiento.Color) 100;
            Console.WriteLine($"Color favorito {e1.ColorFavorito}"); //acceder al nombre de la enumeracion
            Console.WriteLine((int)e1.ColorFavorito); //acceder al valor del color favorito enum
            
        }
    }
    class Persona
    {
        private int edad;
        public Persona(int edad)
        {
            this.edad = edad;
        }
        public int Edad
        {
            get //devuelve el valor del tipo de datos especificado
            {
                return edad;
            }
            /*
            set
            {
                /*
                if (value>0)
                {
                    edad = value; //asigna al valor al atributo
                }
                
                edad = value; //asigna al valor al atributo
            }
            */
        }
    }
}
