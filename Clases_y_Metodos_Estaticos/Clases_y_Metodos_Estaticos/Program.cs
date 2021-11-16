using BibliotecaDeClases;
using System;
// using SC = System.Console; //ALIAS

namespace Clases_y_Metodos_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // SC.WriteLine("Hello World!"); //uso de ALIAS
            Cotizador.CotizarVentaDolares(45.2M);
            Console.WriteLine("Hello World!");
        }
    }
}
