using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Proyecto
{
    class Socio
    {
        public string nombre { set; get; }
        public string apellidos { set; get; }
        public string sexo { set; get; }
        public string ID { set; get; }
        public string edad { set; get; }
        public string telefono { set; get; }
        public string correo { set; get; }
        public string cuenta { set; get; }
        public string ayuda { set; get; }
        public string pago { set; get; }
        public string tipo { set; get; }
        public Uri Imagen { set; get; }
        public BitmapImage Foto {set; get; }
    

        public Socio(string nombre, string apellidos, string sexo, string ID, string edad, string telefono, string correo, string cuenta, string  ayuda, string pago, string tipo, Uri Imagen)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.ID = ID;
            this.edad = edad;
            this.telefono = telefono;
            this.correo = correo;
            this.cuenta = cuenta;
            this.ayuda = ayuda;
            this.pago = pago;
            this.tipo = tipo;
            this.Imagen = Imagen;
        }

    }
}