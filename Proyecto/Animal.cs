using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Proyecto
{
    class Animal
    {
        public string Nombre { set; get; }
        public string Estado { set; get; }
        public string Raza { set; get; }
        public String FechaEntrada { set; get; }
        public string Sexo { set; get; }
        public string Chip { set; get; }
        public int Edad { set; get; }
        public string Tamanio { set; get; }
        public string PPP { set; get; }
        public List<string> Enfermedades = new List<string>();
        public string Vacunado { set; get; }
        public string Descripcion { set; get; }
        public Uri Imagen { set; get; }
        public BitmapImage Foto {set; get; }
    

        public Animal(string nombre, string estado, string raza, string fechaEntrada, string sexo, string chip, int edad, string tamanio, string ppp, List<string> enfermedades, string vacunado, string descripcion, Uri imagen)
        {
            Nombre = nombre;
            Estado = estado;
            Raza = raza;
            FechaEntrada = fechaEntrada;
            Sexo = sexo;
            Chip = chip;
            Edad = edad;
            Tamanio = tamanio;
            PPP = ppp;
            this.Enfermedades = enfermedades;
            Vacunado = vacunado;
            Descripcion = descripcion;
            Imagen = imagen;
        }

    }
}