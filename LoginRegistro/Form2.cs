using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistro
{
    public partial class Form2 : Form
    {
        public List<Class1> usuarios;
        public Form2(List<Class1> usuariosRegistrados)
        {
            InitializeComponent();
            usuarios = usuariosRegistrados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correoIngresado = textBox3.Text;
            string contrasenaIngresada = textBox2.Text;
            string nombreIngresado = textBox1.Text;

            foreach (Class1 usuario in usuarios)
            {
                if (usuario.getNombre() == nombreIngresado && usuario.getCorreo() == correoIngresado && usuario.getContrasena() == contrasenaIngresada)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    return;
                }
            }

            MessageBox.Show("Campos incorrectos, inténtalo de nuevo");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
