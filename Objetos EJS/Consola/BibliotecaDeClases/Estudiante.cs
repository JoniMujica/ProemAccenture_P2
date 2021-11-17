using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre,string apellido,string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        private float CalcularPromedio()
        {
            return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===========Estudiante===========");
            sb.AppendLine($"Estudiante: {nombre} {apellido} {legajo}");
            sb.AppendLine($"Nota Primer y segundo Parcial: {notaPrimerParcial} y {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            double aux = CalcularNotaFinal();
            if (aux != -1)
            {
                sb.AppendLine($"nota final: {aux}");
            }
            else
            {
                sb.AppendLine($"nota final: Alumno desaprobado");
            }
            // sb.AppendLine($"Nota Final {}")

            return sb.ToString();
        }


        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >=4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 10);
            }
            return -1;
        }
    }
}
