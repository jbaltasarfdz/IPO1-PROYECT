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
    public partial class padrinoWindow : Window
    {
        Padrino padrino1 = new Padrino("Enrique","García López","Hombre","01234567X","33","777000111","EnriqueGL@correoprueba.com", "ES01 0011 1122 2233 3344 4455","50 €","Mensual","23/12/2021",null);

        public padrinoWindow()
        {
            InitializeComponent();
            DataContext = padrino1;
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
            MessageBox.Show("Ventana para ver toda la información relacionada con los padrinos/madrinas", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
