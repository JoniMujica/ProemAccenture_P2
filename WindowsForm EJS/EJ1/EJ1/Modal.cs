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
    public partial class Modal : Form
    {
        string nombre;
        string apellido;
        string materia;
        public Modal()
        {
            InitializeComponent();
        }
        public Modal(string nombre,string apellido,string materia):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.materia = materia;
        }

        private void Modal_Load(object sender, EventArgs e)
        {
            txtTitulo1.Font = new Font(txtTitulo1.Font, FontStyle.Bold | FontStyle.Italic);
            this.txtTitulo1.Text = "¡Hola Windows Forms!";
            this.txtTitulo2.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materia}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo2_Click(object sender, EventArgs e)
        {

        }
    }
}
