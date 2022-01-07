using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Proyecto
{
    class Padrino
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
        public string fechaApadrinamiento { set; get; }
        public Uri Imagen { set; get; }

        public Padrino(string nombre, string apellidos, string sexo, string id, string edad, string telefono, string correo, string cuenta, string ayuda, string pago, string fechaApadrinamiento, Uri Imagen)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sexo = sexo;
            ID = id;
            this.edad = edad;
            this.telefono = telefono;
            this.correo = correo;
            this.cuenta = cuenta;
            this.ayuda = ayuda;
            this.pago = pago;
            this.fechaApadrinamiento = fechaApadrinamiento;
            this.Imagen = Imagen;
        }
    }
}
