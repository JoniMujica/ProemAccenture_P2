using System;

namespace BibliotecaDeClases
{
    public class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi metodo ToString sobreescrito";
        }
        public override bool Equals(object obj)
        {
            //return obj is not null && this.GetType() == obj.GetType();
            return obj is not null && obj.GetType() == typeof(Sobreescrito);
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
