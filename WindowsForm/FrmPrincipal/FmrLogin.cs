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
    public partial class FmrLogin : Form
    {
        public FmrLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNEnviar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtBUsuario.Text;
            string pass = this.txtPW.Text;
            /*
            bool esAdmin = checkBox1.Checked;
            bool seleccionado = radioButton1.Checked;*/
            //DialogResult result = MessageBox.Show($"Hola {nombre} es Admin: {esAdmin}","Bienvenida",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
            /*
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("yes");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Selecciono NO");
            }*/

            if (nombre == "joni" && pass == "asd123")
            {
                FrmMenu frmMenu = new FrmMenu(nombre);
                frmMenu.Show();
            }
        }

    }
}
