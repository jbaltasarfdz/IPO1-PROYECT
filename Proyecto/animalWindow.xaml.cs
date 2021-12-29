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

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para animalWindow.xaml
    /// </summary>
    public partial class animalWindow : Window
    {
        static string relativePath = "Images/images.jpg";
        private Animal animal1 = new Animal("Jesús", "Apadrinado", "Perro", "29-12-2021", "Macho", "ABCD69", 22, "mediano",  "PPP", null, "Vacunado", "Es él", new Uri(uriString: relativePath, UriKind.Relative));
        public animalWindow()
        {
            InitializeComponent();
            DataContext = animal1;
        }

        //private List<Perro> CargarListaPerros()
        //{  C:\Users\Carlos\Documents\GitHub\IPO1-PROYECT\Proyecto\Images\

        //}
    }
}
