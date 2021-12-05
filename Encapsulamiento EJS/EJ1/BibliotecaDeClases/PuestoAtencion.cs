using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;


        public int NumeroActual
        {
            get
            {
                return numeroActual;
            }
            set
            {
                numeroActual++;
            }
        }
        public bool Atender(Cliente c)
        {
            Thread.Sleep(900);
            return true;
        }
        public PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto):this()
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
