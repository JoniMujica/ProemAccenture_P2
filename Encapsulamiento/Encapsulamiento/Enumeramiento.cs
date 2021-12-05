using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Enumeramiento
    {
        Color colorFavorito;

        public Color ColorFavorito
        {
            get
            {
                return colorFavorito;
            }
            set
            {
                colorFavorito = value;
            }
        }

        public enum Color
        {
            Rojo,Verde = 100,Azul
        }
    }
}
