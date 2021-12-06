using System;

namespace Entidades
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando forma.....";
        }
        public abstract double CaulcularSuperficie();
        public abstract double CaulcularPerimetro();
    }
}
