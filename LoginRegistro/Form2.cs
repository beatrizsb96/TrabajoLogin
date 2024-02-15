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
            string correoIngresado = textBox1.Text;
            string contrasenaIngresada = textBox2.Text;

            //MessageBox.Show($"Correo ingresado: {correoIngresado}");
            //MessageBox.Show($"Contraseña ingresada: {contrasenaIngresada}");

            foreach (Class1 usuario in usuarios)
            {
                //MessageBox.Show($"Correo almacenado: {usuario.getCorreo()}");
                //MessageBox.Show($"Contraseña almacenada: {usuario.getContrasena()}");
                if (usuario.getCorreo() == correoIngresado && usuario.getContrasena() == contrasenaIngresada)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    return;
                }
            }

            MessageBox.Show("Correo o contraseña incorrectos");
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
