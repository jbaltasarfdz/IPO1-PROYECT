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
    /// Lógica de interacción para userWindow.xaml
    /// </summary>
    public partial class userWindow : Window
    {
        public userWindow()
        {
            InitializeComponent();
        }

        private void btnGestionListadoPerros_Click(object sender, RoutedEventArgs e)
        {
            animalWindow animalwindow = new animalWindow();
            animalwindow.Show();
        }

        private void btnGestionVoluntarios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGestionSocios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGestionAvisos_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
