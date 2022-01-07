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
        Usuario usuario1 = new Usuario("admin","ipo1","Juan","Gonzalez Lopez", "JuanGL@correoprueba.com", DateTime.Now);

        public userWindow()
        {
            InitializeComponent();
            DataContext = usuario1;
        }

        private void btnGestionListadoPerros_Click(object sender, RoutedEventArgs e)
        {
            animalWindow animalwindow = new animalWindow();
            animalwindow.Show();
        }

        private void btnGestionVoluntarios_Click(object sender, RoutedEventArgs e)
        {
            voluntarioWindow voluntariowindow = new voluntarioWindow();
            voluntariowindow.Show();
        }

        private void btnGestionSocios_Click(object sender, RoutedEventArgs e)
        {
            socioWindow sociowindow = new socioWindow();
            sociowindow.Show();
        }

        private void btnGestionAvisos_Click(object sender, RoutedEventArgs e)
        {
            avisoWindow avisowindow = new avisoWindow();
            avisowindow.Show();
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a salir de la aplicación, ¿Desea continuar?", "Salir aplicación",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se va a salir de la aplicación.", "Salir aplicación", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(1);
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ventana para seleccionar el tipo de gestión a realizar", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
