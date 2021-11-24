using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder st = new StringBuilder();
            //int cociente = numeroEntero;
            int res;
            while (numeroEntero != 1)
            {
                res = numeroEntero % 2;
                st.Append(res);
                //numeroEntero = numeroEntero / 2;
                numeroEntero /= 2;
                if (numeroEntero == 1 || numeroEntero == 0)
                {
                    st.Append(numeroEntero);
                }
            }
            /* string aux = st.ToString();
             Console.WriteLine(aux);
             string rev = new string(aux.Reverse().ToArray());*/
            return new string(st.ToString().Reverse().ToArray());
        }

        public static int ConvertirBinarioADecimal(int binario)
        {
            int exp, digito;
            double resultado = 0;
            exp = 0;
            while (binario > 0)
            {
                digito = (int)binario % 10;
                resultado = resultado + digito * Math.Pow(2.0, exp);
                exp++;
                binario = binario / 10;
            }
            return (int)resultado;
        }
    }
}