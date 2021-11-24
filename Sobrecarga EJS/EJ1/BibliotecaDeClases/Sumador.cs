using System;

namespace BibliotecaDeClases
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador():this(0)
        {
        }
        public Sumador(int num)
        {
            this.cantidadSumas = num;
        }
        public void Sumar()
        {
            this.cantidadSumas++;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador num)
        {
            return num.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

    }
}
