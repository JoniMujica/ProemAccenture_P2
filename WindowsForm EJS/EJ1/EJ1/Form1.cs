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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materia = CBbox.Text;
            Modal modal = new Modal(nombre,apellido, materia);
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre\nApellido","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nApellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modal.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBbox.Items.Add("Analisis 1");
            CBbox.Items.Add("Sistemas y Organizaciones");
            CBbox.Items.Add("Algegebra y Geometria Analitica");
            CBbox.Items.Add("Fisica I");
            CBbox.Items.Add("Algoritmos y Estructura de datos");
            CBbox.SelectedIndex = 0;
            CBbox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
