namespace LoginRegistro
{
    public partial class Form1 : Form
    {

        public List<String> usuarios = new List<string>();
        public String nombre;
        public String correo;
        public String contrasena;
        public String validar_contrasena;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
    }
}