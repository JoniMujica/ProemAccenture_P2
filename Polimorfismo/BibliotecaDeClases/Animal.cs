using System;

namespace BibliotecaDeClases
{
    public class Animal
    {
        public virtual string EmitirSonido() //con el virtual puedo invalidar/redefinir un metoro por clase derivada
        {
            return "Emitiendo sonido...";
        }
    }
}
