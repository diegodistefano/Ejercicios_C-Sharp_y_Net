using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSegundaAplicacion
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((textBoxApellido.Text == "") || (textBoxNombre.Text == "") || (textBoxEdad.Text == "") || (textBoxDireccion.Text == ""))
            {
            {
                if (textBoxApellido.Text == "")
                    textBoxApellido.BackColor = Color.Red;
                else
                    textBoxApellido.BackColor = System.Drawing.SystemColors.Control;
            }
            {
                if (textBoxNombre.Text == "")
                    textBoxNombre.BackColor = Color.Red;
                else
                    textBoxNombre.BackColor = System.Drawing.SystemColors.Control;
            }
            {
                if (textBoxEdad.Text == "")
                    textBoxEdad.BackColor = Color.Red;
                else
                    textBoxEdad.BackColor = System.Drawing.SystemColors.Control;
            }
            {
                if (textBoxDireccion.Text == "")
                    textBoxDireccion.BackColor = Color.Red;
                else
                    textBoxDireccion.BackColor = System.Drawing.SystemColors.Control;
            }
            }
             else
            {
            string apellido = textBoxApellido.Text;
            string nombre = textBoxNombre.Text;
            string edad = textBoxEdad.Text;
            string direccion = textBoxDireccion.Text;

            string mensaje = "Nombre y Apellido: " + nombre + " " + apellido + "." + "\r\n" + "EDAD: " + edad + "." + "\r\n" + "DIRECCIÓN: " + direccion + ".";

            this.textBoxResultado.Text += mensaje;
            }

        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
