using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        static float promedioGoles;
        private int totalGoles;
        private Jugador()
        {
            dni = 0;
            nombre = "";
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni,string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni,string nombre,int totalGoles,int totalPartidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;

            promedioGoles = (float)totalGoles / (float)partidosJugados;
        }
        public float GetPromedioGoles()
        {
            return promedioGoles;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI:{this.dni}");
            sb.AppendLine($"Nombre:{this.nombre}");
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados}");
            sb.AppendLine($"Promedio de goles: {this.GetPromedioGoles()}");
            sb.AppendLine($"Total Goles:{this.totalGoles}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
