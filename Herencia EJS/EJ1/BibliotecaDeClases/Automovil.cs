using System;

namespace BibliotecaDeClases
{
    
    public class Automovil :VehiculoTerrestre
    {
        //short cantidadRuedas;
        //short cantidadPuertas;
        short cantidadManchas;
        int cantidadPasajeros;
        //Colores color;

        public Automovil(short cantidadRuedas, short cantidadPuertas, short cantidadManchas, int cantidadPasajeros, Colores color):base(cantidadRuedas,cantidadPuertas,color)
        {
            //this.cantidadRuedas = cantidadRuedas;
            //this.cantidadPuertas = cantidadPuertas;
            //this.cantidadManchas = cantidadManchas;
            this.cantidadPasajeros = cantidadPasajeros;
            //this.color = color;
        }
    }
}
