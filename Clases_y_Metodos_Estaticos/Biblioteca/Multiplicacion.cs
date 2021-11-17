using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Multiplicacion
    {
        public static string Multiplicar(int numero)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tabla de multiplicar del numero {0}{1}", numero,Environment.NewLine);
            for (int i = 1; i <= 10; i++)
            {
                sb.AppendFormat("{0} x {1} = {2}{3}", numero, i, numero * i,Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
