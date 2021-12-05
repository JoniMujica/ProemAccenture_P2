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
