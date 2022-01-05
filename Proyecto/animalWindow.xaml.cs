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
        private List<Animal> listadoPerros;

        public animalWindow()
        {
            InitializeComponent();

            listadoPerros = CargarListaPerros();

            DataContext = listadoPerros;


        }

        private List<Animal> CargarListaPerros()
        {
            List<Animal> listado = new List<Animal>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Xmls/xmlPerros.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var newPerro = new Animal("", "", "", "", "", "", 0, "", "", "", "", "", null);
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
                //newPerro.Foto = new BitmapImage(newPerro.Imagen);

                listado.Add(newPerro);
            }
            return listado;
        }

        private void btnAniadir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a añadir un nuevo perro a la base de datos, ¿Desea continuar?", "Añadir Perro", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha añadido correctamente un nuevo perro.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                var nuevoPerro = new Animal("...", "...", "...", "...", "...", "...", 0, "...", "...", "...", "...", "...",
                                new Uri("Images/silueta.jpg", UriKind.Relative));
                // Añadimos una nueva película a la lista de películas (listadoPeliculas)
                listadoPerros.Add(nuevoPerro);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaPerros.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción","Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a eliminar un perro de la base de datos, ¿Desea continuar?", "Eliminar Perro",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha eliminado correctamente el perro seleccionado.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                listadoPerros.RemoveAt(cbListaPerros.SelectedIndex);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaPerros.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a editar la información de perro de la base de datos, ¿Desea continuar?", "Editar Perro",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha editado correctamente la información correspondiente al perro seleccionado.", "Resultado", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cbListaPerros.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void txtEstado_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtEstado.Text == "Apadrinado" || txtEstado.Text == "apadrinado" || txtEstado.Text == "APADRINADO")
            {
                btnInformacionApadrinado.IsEnabled = true;
                btnInformacionApadrinado.Visibility = Visibility.Visible;
            }
            else
            {
                btnInformacionApadrinado.IsEnabled = false;
                btnInformacionApadrinado.Visibility = Visibility.Hidden;
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ventana para gestionar la información de los animales de la protectora", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
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
    }
}
