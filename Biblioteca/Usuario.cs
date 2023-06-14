using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        private string? nombreCompleto;
        private string? nombreUsuario;
        private string? email;
        private string? contraseña;

        public Usuario(string? nombreCompleto, string? nombreUsuario, string? email, string? contraseña)
        {
            this.nombreCompleto = nombreCompleto;
            this.nombreUsuario = nombreUsuario;
            this.email = email;
            this.contraseña = contraseña;
        }

        public string? NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string? NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string? Email { get => email; set => email = value; }
        public string? Contraseña { get => contraseña; set => contraseña = value; }


    }
}
