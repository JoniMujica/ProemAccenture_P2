using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        private Euro()
        {
            cotzRespectoDolar = 1 / 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Dolar(Euro E)
        {
            return new Dolar(E.cantidad / cotzRespectoDolar);
        }
        public static explicit operator Pesos(Euro E)
        {
            return (Pesos)((Dolar)E); //pasamos Euro a Dolar y Dolar a Peso (esta en la clase Dolar)
        }

        //sobrecarga implicita de Double 
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.cantidad == d.GetCantidad());
        }
        public static bool operator != (Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator == (Euro e ,Pesos p)
        {
            return (e.cantidad == p.GetCantidad());
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator == (Euro e , Euro e2)
        {
            return (e.cantidad == e2.cantidad);
        }
        public static bool operator !=(Euro e, Euro e2)
        {
            return !(e == e2);
        }

        public static Euro operator -(Euro e,Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        public static Euro operator -(Euro e,Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
    }
}
