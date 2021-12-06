using System;

namespace BibliotecaDeClases
{
    public abstract class Animal
    {
        protected string nombre;
       // public abstract string Nombre { get; set; };
        public abstract string Saludar();
        public virtual string EmitirSonido() //con el virtual puedo invalidar/redefinir un metoro por clase derivada
        {
            return "Emitiendo sonido..." + nombre;
        }
    }
}
