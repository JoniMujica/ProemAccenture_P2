using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Camion : VehiculoTerrestre
    {
        //short cantidadRuedas;
        //short cantidadPuertas;
        short cantidadManchas;
        int pesoCarga;
        //Colores color;

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadManchas, int pesoCarga, Colores color):base(cantidadRuedas,cantidadPuertas,color)
        {
            //this.cantidadRuedas = cantidadRuedas;
            //this.cantidadPuertas = cantidadPuertas;
            this.cantidadManchas = cantidadManchas;
            this.pesoCarga = pesoCarga;
            //this.color = color;
        }
    }
}
