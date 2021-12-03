using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> diccionario;
        public Form1()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
        }
        private void ContarPalabras(string texto)
        {
            char[] separadores = new char[] { ' ', ',', '.', ':', ';', '\t', '\n' };
            string[] palabras = texto.Split(separadores, StringSplitOptions.RemoveEmptyEntries); //separa las palabras por espacio o algunos de los caracteres de "separadores" (y elimina vacios) y los va acumulando al array
            foreach (string palabra in palabras)
            {
                if (diccionario.ContainsKey(palabra))
                {
                    diccionario[palabra]++;
                }
                else
                {
                    diccionario.Add(palabra, 1);
                }
            }
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string eliminarPalabra = string.Empty;
            int i = 0;
            while (i < 3)
            {
                foreach (KeyValuePair<string, int> elemento in diccionario)
                {
                    if (diccionario.Values.Max() == elemento.Value)
                    {
                        sb.AppendLine($"{elemento.Key} - {elemento.Value}");
                        eliminarPalabra = elemento.Key;
                        break;
                    }
                }
                if (diccionario.Remove(eliminarPalabra))
                {
                    i++;
                }
            }
            return sb.ToString();
        }
        
        private void BTNCalcular_Click(object sender, EventArgs e)
        {
            ContarPalabras(RTBtxt.Text);
            MessageBox.Show(Mostrar());
        }
    }
}
