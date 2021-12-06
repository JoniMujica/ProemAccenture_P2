using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
        string nombre;
        long dni;

        public Persona(string nombre) : this(nombre, 0)
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{nombre}");
            sb.AppendLine($"Dni:{dni}");
            return sb.ToString();
        }

    }
}
