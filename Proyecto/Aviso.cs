using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Proyecto
{
    class Aviso
    {
        public string nombre { set; get; }
        public string sexo { set; get; }
        public string raza { set; get; }
        public string tamanio { set; get; }
        public string descripcion { set; get; }
        public string fechaPerdida { set; get; }
        public string zonaPerdida { set; get; }
        public string telefono { set; get; }
        public string correo { set; get; }
        public Uri Imagen { set; get; }
        public BitmapImage Foto { set; get; }

        public Aviso(string nombre, string sexo, string raza, string tamanio, string descripcion, string fechaPerdida, string zonaPerdida, string telefono, string correo, Uri imagen)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.raza = raza;
            this.tamanio = tamanio;
            this.descripcion = descripcion;
            this.fechaPerdida = fechaPerdida;
            this.zonaPerdida = zonaPerdida;
            this.telefono = telefono;
            this.correo = correo;
            Imagen = imagen;
        }
    }
}
