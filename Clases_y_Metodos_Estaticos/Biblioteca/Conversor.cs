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

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numStr = numeroEntero.ToString();
            int cant = numStr.Length;
          //  int res = 0;
            
            for (int i = cant; i >= 0; i--)
            {

            }
            return 0;
        }
    }
}
