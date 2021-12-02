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
    public partial class DatosIngresante : Form
    {
        Ingresante ingresante;
        public DatosIngresante()
        {
            InitializeComponent();
        }
        public DatosIngresante(Ingresante ingresante):this()
        {
            this.ingresante = ingresante;
        }

        private void DatosIngresante_Load(object sender, EventArgs e)
        {
            LBLDatos.Text = ingresante.Mostrar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
