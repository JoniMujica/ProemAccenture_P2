using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class  Circulo : Figura
    {
        private float radio;
        public Circulo(float radio)
        {
            this.radio = radio;
        }
        public override double CaulcularPerimetro()
        {
            return Math.PI * this.radio * 2;
        }

        public override double CaulcularSuperficie()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }
        public override string Dibujar()
        {
            return "Dibujando un circulo.....";
        }
    }
}
