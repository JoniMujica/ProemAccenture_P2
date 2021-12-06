using System;

namespace BibliotecaDeClases
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }
        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
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
    public class SobreSobrescrito : Sobreescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
