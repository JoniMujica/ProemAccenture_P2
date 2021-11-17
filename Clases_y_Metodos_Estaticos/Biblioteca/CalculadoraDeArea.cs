using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class CalculadoraDeArea { 
    
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double Base,double altura)
        {
            return (Base * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return (3.14 * radio * radio);
        }
    }
}
