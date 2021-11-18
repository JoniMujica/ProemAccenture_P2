using System;

namespace BibliotecaDeClases
{
    public class Boligrafo
    {
        private short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            short dif = (short)(this.tinta - gasto);
            int aux = 0;
            string print = "";
            if (this.tinta > 0)
            {
                if (dif > 0)
                {
                    aux = gasto;
                    SetTinta((short)(-1*gasto));
                }
                else if (dif <= 0)
                {
                    aux = this.tinta;
                    SetTinta((short)(-1 * this.tinta));
                }

                for (int i = 0; i < aux; i++)
                {
                    print += '*'.ToString();
                }
                dibujo = print;
                //SetTinta((short)(this.tinta - gasto));
                return true;
            }
            else
            {
                dibujo = "";
                return false;
            }

        }
        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - this.tinta));
        }
        private void SetTinta(short tinta)
        {
            if (tinta <= 0)
            {
                if (this.tinta + tinta >= 0)
                {
                    this.tinta += tinta;
                }
            }
            if (tinta > 0)
            {
                if (this.tinta + tinta <= cantidadTintaMaxima)
                {
                    this.tinta += tinta;
                }
            }
        }
    }
}
