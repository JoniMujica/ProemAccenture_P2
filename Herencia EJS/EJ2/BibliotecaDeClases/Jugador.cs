using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        static float promedioGoles;
        private int totalGoles;
        public Jugador(int dni, string nombre):base(nombre,dni)
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni,string nombre,int totalGoles,int totalPartidos):this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;

            promedioGoles = (float)totalGoles / (float)partidosJugados;
        }
        public float GetPromedioGoles()
        {
            return promedioGoles;
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados}");
            sb.AppendLine($"Promedio de goles: {this.GetPromedioGoles()}");
            sb.AppendLine($"Total Goles:{this.totalGoles}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
