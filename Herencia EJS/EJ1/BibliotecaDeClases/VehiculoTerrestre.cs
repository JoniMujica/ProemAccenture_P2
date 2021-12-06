using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}
