using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Ingresante
    {
        string[] cursos = new string[3];
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Ingresante(string nombre,string direccion,string genero,string pais,string [] cursos,int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}{1}",this.nombre,Environment.NewLine);
            sb.AppendFormat("Direccion: {0}{1}", this.direccion, Environment.NewLine);
            sb.AppendFormat("Edad: {0}{1}", this.edad, Environment.NewLine);
            sb.AppendFormat("Genero: {0}{1}", this.genero, Environment.NewLine);
            sb.AppendFormat("Pais: {0}{1}", this.pais, Environment.NewLine);
            sb.AppendFormat("Cursos:{0}", Environment.NewLine);
            for (int i = 0; i < cursos.Length; i++)
            {
                if (!string.IsNullOrEmpty(cursos[i]))
                {
                    sb.AppendFormat("{0}{1}", this.cursos[i], Environment.NewLine);
                }
            }
            return sb.ToString();
        }
    }
}
