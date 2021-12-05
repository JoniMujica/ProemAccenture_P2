﻿using System;

namespace BibliotecaDeClases
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public Cliente(int numero):this(numero,"")
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1,Cliente c2)
        {
            return (c1.numero == c2.numero);
        }
        public static bool operator !=(Cliente c1,Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
