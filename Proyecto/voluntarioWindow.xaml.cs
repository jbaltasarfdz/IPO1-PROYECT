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
    public partial class voluntarioWindow : Window
    {
        private List<Voluntario> listadoVoluntarios;

        public voluntarioWindow()
        {
            InitializeComponent();

            listadoVoluntarios = CargarListaVoluntarios();

            DataContext = listadoVoluntarios;


        }

        private List<Voluntario> CargarListaVoluntarios()
        {
            List<Voluntario> listado = new List<Voluntario>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Xmls/xmlVoluntarios.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var newVoluntario = new Voluntario("", "", "", "", 0, "", "", "", "", "", null);
                newVoluntario.nombre = node.Attributes["nombre"].Value;
                newVoluntario.apellidos = node.Attributes["apellidos"].Value;
                newVoluntario.sexo = node.Attributes["sexo"].Value;
                newVoluntario.ID = node.Attributes["ID"].Value;
                newVoluntario.edad = Convert.ToInt32(node.Attributes["edad"].Value);
                newVoluntario.telefono = node.Attributes["telefono"].Value;
                newVoluntario.correo = node.Attributes["correo"].Value;
                newVoluntario.horario = node.Attributes["horario"].Value;
                newVoluntario.zona = node.Attributes["zona"].Value;
                newVoluntario.veterinario =  node.Attributes["veterinario"].Value;
                newVoluntario.Imagen = new Uri(Environment.CurrentDirectory + node.Attributes["Imagen"].Value);
                //newPerro.Foto = new BitmapImage(newPerro.Imagen);

                listado.Add(newVoluntario);
            }
            return listado;
        }

        private void btnAniadir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a añadir un nuevo voluntario a la base de datos, ¿Desea continuar?", "Añadir Voluntario", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha añadido correctamente un nuevo voluntario.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                var nuevoVoluntario = new Voluntario("...", "...", "...", "...", 0, "...", "...", "...", "...", "...", new Uri("Images/siluetavoluntario.jpg", UriKind.Relative));
                // Añadimos una nueva película a la lista de películas (listadoPeliculas)
                listadoVoluntarios.Add(nuevoVoluntario);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaVoluntarios.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción","Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a eliminar un voluntario de la base de datos, ¿Desea continuar?", "Eliminar Voluntario",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha eliminado correctamente el voluntario seleccionado.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                listadoVoluntarios.RemoveAt(cbListaVoluntarios.SelectedIndex);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaVoluntarios.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a editar la información de voluntario de la base de datos, ¿Desea continuar?", "Editar Voluntario",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha editado correctamente la información correspondiente al perro seleccionado.", "Resultado", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cbListaVoluntarios.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        /*private void txtEstado_TextChanged(object sender, TextChangedEventArgs e)
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
        }*/
    }
}
