using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Gato:Animal
    {
        public override string EmitirSonido()
        {
            return "MIAW";
        }
        public override string Saludar()
        {
            return $"Hola soy un gato {EmitirSonido()}";
        }
    }
}
