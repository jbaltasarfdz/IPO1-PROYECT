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
        public string email { set; get; }
        public string cuentaBancaria { set; get; }
        public int ayudaEuros { set; get; }
        public string opcionPago { set; get; }
        public string tipoSocio { set; get; }
        public Uri Imagen { set; get; }
        public BitmapImage Foto {set; get; }
    

        public Socio(string nombre, string apellidos, string sexo, string ID, string edad, string telefono, string email, string cuentaBancaria, int  ayudaEuros, string opcionPago, string tipoSocio, Uri Imagen)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.ID = ID;
            this.edad = edad;
            this.telefono = telefono;
            this.email = email;
            this.cuentaBancaria = cuentaBancaria;
            this.ayudaEuros = ayudaEuros;
            this.opcionPago = opcionPago;
            this.tipoSocio = tipoSocio;
            this.Imagen = Imagen;
        }

    }
}