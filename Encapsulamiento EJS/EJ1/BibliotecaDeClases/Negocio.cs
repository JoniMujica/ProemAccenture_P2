using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                if (!this.clientes.Contains(value))
                {
                    this.clientes.Enqueue(value);
                }
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
        public static bool operator ==(Negocio n,Cliente c)
        {
            foreach (Cliente x in n.clientes)
            {
                if (x == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n,Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n,Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
    }
}
