using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Proyecto
{
    class Voluntario
    {
        public string nombre { set; get; }
        public string apellidos { set; get; }
        public string sexo { set; get; }
        public string ID { set; get; }
        public int edad { set; get; }
        public string telefono { set; get; }
        public string correo { set; get; }
        public string horario { set; get; }
        public string zona { set; get; }
        public string veterinario { set; get; }
        public Uri Imagen { set; get; }
        public BitmapImage Foto {set; get; }
    

        public Voluntario(string nombre, string apellidos, string sexo, string ID, int edad, string telefono, string correo, string horario, string zona, string veterinario, Uri Imagen)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.ID = ID;
            this.edad = edad;
            this.telefono = telefono;
            this.correo = correo;
            this.horario = horario;
            this.zona = zona;
            this.veterinario = veterinario;
            this.Imagen = Imagen;
        }

    }
}