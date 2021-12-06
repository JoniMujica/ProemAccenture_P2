using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Moto : VehiculoTerrestre
    {
        //short cantidadRuedas;
        //short cantidadPuertas;
        short cilindradas;

       // Colores color;

        public Moto(short cantidadRuedas, short cantidadPuertas, short cilindradas, Colores color):base(cantidadRuedas,cantidadPuertas,color)
        {
            //this.cantidadRuedas = cantidadRuedas;
           //this.cantidadPuertas = cantidadPuertas;
            this.cilindradas = cilindradas;
            //this.color = color;
        }
    }
}
