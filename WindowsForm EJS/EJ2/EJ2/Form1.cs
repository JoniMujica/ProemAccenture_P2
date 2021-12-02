using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Paises.Items.Add("Argentina");
            Paises.Items.Add("Chile");
            Paises.Items.Add("Uruguay");
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string genero = "";
            if (RadMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (RadFemenino.Checked)
            {
                genero = "Femenino";
            }
            else
            {
                genero = "No Binario";
            }
            //string pais = Paises.SelectedIndex.ToString();
            string pais = Paises.GetItemText(Paises.SelectedItem);
            string[] cursos = new string[3];
            if (CHOp1.Checked)
            {
                cursos[0] = CHOp1.Text;
            }
            if (CHOp2.Checked)
            {
                cursos[1] = CHOp2.Text;
            }
            if (CHOp3.Checked)
            {
                cursos[2] = CHOp3.Text;
            }
            int edad = Convert.ToInt32(edadList.Value);
            Ingresante ingresante = new Ingresante(nombre,direccion,genero,pais,cursos,edad);
            DatosIngresante FormuDatos = new DatosIngresante(ingresante);
            FormuDatos.Show();

        }
    }
}
