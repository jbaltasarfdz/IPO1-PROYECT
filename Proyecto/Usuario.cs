using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Usuario
    {
        public string IDUsuario { set; get; }
        public string Password { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Correo { set; get; }
        public DateTime FechaAcceso { set; get; }


        public Usuario(string idUsuario, string password, string nombre, string apellidos, string correo, DateTime fechaAcceso)
        {
            IDUsuario = idUsuario;
            Password = password;
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            FechaAcceso = fechaAcceso;
        }
    }
}
