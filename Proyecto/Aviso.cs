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
        public string NombrePerro { set; get; }
        public string Descripcion { set; get; }
        public string NombreDueño { set; get; }
        public string Telefono { set; get; }
        public string Correo { set; get; }
        public Uri Imagen { set; get; }
        public BitmapImage Foto { set; get; }

        public Aviso(string nombrePerro, string descripcion, string nombreDueño, string telefono, string correo, Uri imagen)
        {
            NombrePerro = nombrePerro;
            Descripcion = descripcion;
            NombreDueño = nombreDueño;
            Telefono = telefono;
            Correo = correo;
            Imagen = imagen;
        }
    }
}
