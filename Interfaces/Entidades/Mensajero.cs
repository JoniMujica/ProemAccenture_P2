using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensajero : Persona, IMensajero
    {
        public void EnviarMensaje()
        {
            Console.WriteLine("Soy el mensajero y traigo un mensaje");
        }
    }
}
