using System;

namespace TASKILLER
{
    public class Usuario
    {
        public Guid Id  { get; set; }
        public String Nombre { get; set; }
        public String Apellido {  get; set; }
        public String Mail { get; set;}
        public String Contrasena { get; set; }
        public Guid Rol { get; set; }

        public Usuario() { }
        public Usuario(string nombre, String apellido, String mail, String contrasena, Guid rol )
        {
            this.Id = Guid.NewGuid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Contrasena = contrasena;
            this.Rol = rol;
        }
      
    }
}

