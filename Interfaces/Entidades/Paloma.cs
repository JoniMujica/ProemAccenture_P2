using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paloma : IMensajero
    {
        public int count
        {
            set
            {

            }
        }

        public void EnviarMensaje()
        {
            Console.WriteLine("Soy una paloma mensajera y traigo mensaje");
        }
    }
}
