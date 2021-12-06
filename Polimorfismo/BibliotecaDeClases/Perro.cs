using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Perro : Animal
    {
        /*
        public new string EmitirSonido() //no polimorfica
        {
            return "Woof";
        }*/
        //string nombre;
        int edad;
        //metodos abstractos
        public override string Saludar()
        {
            return "Hola Soy un perrito 2 " + nombre;
        }

        public override string EmitirSonido() //override invalida/redefine/sobreescribe un metodo virtual de la clase base
        {
            //return "Woof";
            return $"{base.EmitirSonido()} Woof";
        }
        public override string ToString()
        {
            return "Soy un perrito";
        }
        public override bool Equals(object obj)
        {
            Perro perro = obj as Perro;
            //return this.nombre == ((Perro)obj).nombre;
            return perro is not null && this.nombre == perro.nombre;
        }

        public override int GetHashCode()
        {
            return (nombre,edad).GetHashCode();
        }
    }
}
