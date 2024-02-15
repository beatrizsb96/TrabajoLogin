using System.DirectoryServices.ActiveDirectory;
using System.Transactions;


namespace LoginRegistro
{
    public partial class Form1 : Form
    {
        
        public List<Class1> usuarios = new List<Class1>();
        public String nombre;
        public String correo;
        public String contrasena;
        public String validar_contrasena;
        public Form1()
        {
            InitializeComponent();
            label6.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contrasena != validar_contrasena)
            {
                label6.Visible = true;
            }
            else
            {
                Class1 usuario = new Class1(nombre, correo, contrasena);
                usuarios.Add(usuario);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                if (label6.Visible = true)
                {
                    label6.Visible = false;
                }

                Form2 form2 = new Form2(usuarios);
                form2.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            correo = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            contrasena = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            validar_contrasena = textBox4.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}