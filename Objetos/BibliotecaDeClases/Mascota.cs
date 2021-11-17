using System;

namespace BibliotecaDeClases
{
    public class Mascota
    {
        //areibutos
        private string nombre;
        private int edad;

        public static string saludo;
        
        static Mascota() //static se usa para una entidad que tendra el mismo valor para todos los objetos, se puede decir que se usa para inicializar un onjeto
        {
            Mascota.saludo = "Hola";
        }

        //constructor
        public Mascota(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //metodos

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string MostrarDatos()
        {
            return $"{Mascota.saludo} mi nombres es {nombre} y tengo {edad} años";
        }
    }
}
