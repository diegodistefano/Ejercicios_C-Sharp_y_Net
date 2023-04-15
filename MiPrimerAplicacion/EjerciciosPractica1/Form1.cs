using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPractica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Inicializando programa en C#");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Programa finalizado");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Blue;
            if (txtBox.Text == "")
                txtBox.BackColor = Color.Red;
            else
                txtBox.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            lbl.BackColor = Color.Cyan;
            lbl.Cursor = Cursors.Hand;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = System.Drawing.SystemColors.Control;
            lbl.Cursor = Cursors.Arrow;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
