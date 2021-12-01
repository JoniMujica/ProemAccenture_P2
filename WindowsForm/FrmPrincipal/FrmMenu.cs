using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmMenu : Form
    {

        string nombreUsuario;
        public FrmMenu(string nombre):this() //pasa informacion de un form a otro
        {
            this.nombreUsuario = nombre;
        }
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.label2.Text = $"Bienvenido {nombreUsuario}";
        }
    }
}
