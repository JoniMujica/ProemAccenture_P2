using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas,short cantidadCompetidores):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadCompetidores = cantidadVueltas;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores:{this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas:{this.cantidadCompetidores}");
            return sb.ToString();
        }
        public static bool operator -(Competencia c,AutoF1 a)
        {
            if (c.competidores.Count > 0)
            {
                c.competidores.Remove(a);
                a.SetEstadoCompetencia(false);
                a.SetVueltasRestantes(0);
                a.SetCantidadCombustible(0);
                return true;
            }
            return false;
        }
        public static bool operator +(Competencia c,AutoF1 a)
        {
            Random aleatorio = new Random();
            if (c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Add(a);
                a.SetEstadoCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)aleatorio.Next(15, 100));
                return true;
            }
            return false;
        }

        public static bool operator == (Competencia c,AutoF1 a)
        {
            foreach (AutoF1 auxvehiculo in c.competidores)
            {
                if (auxvehiculo == a)
                {
                    return true;
                    break;
                }
            }

            return false;
        }
        public static bool operator != (Competencia c,AutoF1 a)
        {
            return !(c == a);
        }
    }
}
