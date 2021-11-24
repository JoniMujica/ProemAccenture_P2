using System;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Pesos()
        {
            cotzRespectoDolar = 102.65;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad,double cotizacion):this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / cotzRespectoDolar);
        }
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        public static bool operator == (Pesos p, Dolar d)
        {
            return p.cantidad == d.GetCantidad();
        }
        public static bool operator != (Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator == (Pesos p, Euro e)
        {
            return p.cantidad == e.GetCantidad();
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p.cantidad == e.GetCantidad());
        }
        public static bool operator == (Pesos p, Pesos p2)
        {
            return p.cantidad == p2.cantidad;
        }
        public static bool operator !=(Pesos p, Pesos p2)
        {
            return !(p == p2);
        }
        public static Pesos operator +(Pesos P , Dolar D)
        {
            return new Pesos(P.cantidad + ((Pesos)D).cantidad);
        }
        public static Pesos operator +(Pesos P, Euro E)
        {
            return new Pesos(P.cantidad + ((Pesos)E).cantidad);
        }
        public static Pesos operator -(Pesos P, Dolar D)
        {
            return new Pesos(P.cantidad - ((Pesos)D).cantidad);
        }
        public static Pesos operator -(Pesos P, Euro E)
        {
            return new Pesos(P.cantidad - ((Pesos)E).cantidad);
        }
    }
}
