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
        public string Enfermedades { set; get; }
        public string Vacunado { set; get; }
        public string Descripcion { set; get; }
        public Uri Imagen { set; get; }
        public BitmapImage Foto {set; get; }
    

        public Animal(string Nombre, string Estado, string Raza, string FechaEntrada, string Sexo, string Chip, int Edad, string Tamanio, string PPP, string Enfermedades, string Vacunado, string Descripcion, Uri Imagen)
        {
            this.Nombre = Nombre;
            this.Estado = Estado;
            this.Raza = Raza;
            this.FechaEntrada = FechaEntrada;
            this.Sexo = Sexo;
            this.Chip = Chip;
            this.Edad = Edad;
            this.Tamanio = Tamanio;
            this.PPP = PPP;
            this.Enfermedades = Enfermedades;
            this.Vacunado = Vacunado;
            this.Descripcion = Descripcion;
            this.Imagen = Imagen;
        }

    }
}