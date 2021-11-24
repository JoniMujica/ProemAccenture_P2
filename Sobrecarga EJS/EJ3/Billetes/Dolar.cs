using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        //conversion explicita
        // es como si hiciera:
        // int i = (int)t;

        public static explicit operator Euro(Dolar D)
        {
            return new Euro(D.cantidad*1.17);
        }
        public static explicit operator Pesos(Dolar D)
        {
            return new Pesos(D.cantidad * 102.65);
        }
        public static implicit operator Dolar(int a)
        {
            return new Dolar(a);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == e.GetCantidad();
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.cantidad == p.GetCantidad();
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator !=(Dolar d, Dolar e)
        {
            return !(d == e);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).GetCantidad());
        } 
        public static Dolar operator +(Dolar d ,Euro E)
        {
            return new Dolar(d.cantidad + ((Dolar)E).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Pesos P)
        {
            return new Dolar(d.cantidad + ((Dolar)P).GetCantidad());
        }
    }
}
