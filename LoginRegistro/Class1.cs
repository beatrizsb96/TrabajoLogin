using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegistro
{
    public class Class1
    {
        public String nombre;
        public String correo;
        public String contrasena;

        public Class1(string nombre, string correo, string contrasena)
        {
            
            this.nombre = nombre;
            this.correo = correo;
            this.contrasena = contrasena;
        }


        public String getNombre() {  return nombre; }
        public String getCorreo() { return correo; }
        
        public String getContrasena() {  return contrasena; }

    }
}
