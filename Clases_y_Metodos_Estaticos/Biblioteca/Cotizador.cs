using System;
using System.Text;

namespace BibliotecaDeClases
{
    public static class Cotizador
    {
        private const decimal pesosPorDolarComprado = 96.75M;
        /// <summary>
        /// Cotiza la venta de un monto en dolares y retorna el costo en pesos
        /// </summary>
        /// <param name="montoDolares">Cantidad de dolares que se desean vender</param>
        /// <returns>Costo en pesos de la venta de dolares</returns>
        public static decimal CotizarVentaDolares(decimal montoDolares)
        {
            return 23.4M;
        }
        public static string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hola "); // misma linea
            //stringBuilder.Append("Usuario "); //misma linea
            //stringBuilder.AppendFormat($"Usuario {Environment.NewLine}"); //Le da formato al Append, "Environment.NewLine" es una nueva linea (salto de linea)
            stringBuilder.AppendFormat("Usuario {0}", Environment.NewLine);
            stringBuilder.AppendLine("Esta es la clase de: "); //salto de linea al final
            stringBuilder.Append("Programacion .NET"); //misma linea
            return stringBuilder.ToString();
        }
    }
}
