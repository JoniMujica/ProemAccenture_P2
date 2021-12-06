using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class DirectorTecnico : Persona
    {
        DateTime fechaNacimiento;
        private DirectorTecnico(string nombre):base(nombre)
        {
        }
        public DirectorTecnico(string nombre,DateTime fechaNacimiento):this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

    }
}
