using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para animalWindow.xaml
    /// </summary>
    public partial class animalWindow : Window
    {
        static string relativePath = "Images/images.jpg";
        private Animal animal1 = new Animal("Jesús", "Apadrinado", "Perro", "29-12-2021", "Macho", "ABCD69", 22, "mediano",  "PPP", "", "Vacunado", "Es él", new Uri(uriString: relativePath, UriKind.Relative));
        public animalWindow()
        {
            InitializeComponent();
            DataContext = animal1;
        }

        private List<Animal> CargarListaPerros()
        {
            List<Animal> listado = new List<Animal>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Xmls/xmlPerros.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var newPerro = new Animal("", "", "", "", "", "", 0, "", "", null, "", "", null);
                newPerro.Nombre = node.Attributes["Nombre"].Value;
                newPerro.Estado = node.Attributes["Estado"].Value;
                newPerro.Raza = node.Attributes["Raza"].Value;
                newPerro.FechaEntrada = node.Attributes["FechaEntrada"].Value;
                newPerro.Sexo = node.Attributes["Sexo"].Value;
                newPerro.Chip = node.Attributes["Chip"].Value;
                newPerro.Edad = Convert.ToInt32(node.Attributes["Edad"].Value);
                newPerro.Tamanio = node.Attributes["Tamanio"].Value;
                newPerro.PPP = node.Attributes["PPP"].Value;
                newPerro.Enfermedades =  node.Attributes["Enfermedades"].Value;
                newPerro.Vacunado = node.Attributes["Vacunado"].Value;
                newPerro.Descripcion = node.Attributes["Descripcion"].Value;
                newPerro.Imagen = new Uri(Environment.CurrentDirectory + node.Attributes["Imagen"].Value);
                newPerro.Foto = new BitmapImage(newPerro.Imagen);

                listado.Add(newPerro);
            }
            return listado;    
        }
    }
}
