using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Tiempo
    {
        private int hora;
        private int minutos;
        private int segundos;

        public Tiempo():this(0, 0, 0) //el this va a referenciar al ctor con parametros, esto apra no repetir codigo
        {
            /*
            hora = 0;
            minutos = 0;
            segundos = 0;
            */
        }
        public Tiempo(int h):this(h,0,0)
        {

        }
        public Tiempo(int h,int m) : this(h, m, 0)
        {

        }
        public Tiempo(int h,int m,int s) // referencia de :this
        {
            hora = h;
            minutos = m;
            segundos = s;
        }

        public int GetHora()
        {
            return this.hora;
        }
        public int GetMinutos()
        {
            return this.minutos;
        }

        //operadores logicos
        public static bool operator == (Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }
        public static bool operator != (Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }

        //conversion explicita
        // es como si hiciera:
        // int i = (int)t;
        public static explicit operator int(Tiempo t)
        {
            return t.hora;
        }
        public static implicit operator Tiempo(int i)
        {
            return new Tiempo(i);
        }
    }
}
