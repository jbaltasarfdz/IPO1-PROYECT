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
    public partial class socioWindow : Window
    {
        private List<Socio> listadoSocios;

        public socioWindow()
        {
            InitializeComponent();

            listadoSocios = cargarListaSocios();

            DataContext = listadoSocios;


        }

        private List<Socio> cargarListaSocios()
        {
            List<Socio> listado = new List<Socio>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Xmls/xmlSocios.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var newSocio = new Socio("", "", "", "", "", "", "", "", "", "", "", null);
                newSocio.nombre = node.Attributes["nombre"].Value;
                newSocio.apellidos = node.Attributes["apellidos"].Value;
                newSocio.sexo = node.Attributes["sexo"].Value;
                newSocio.ID = node.Attributes["ID"].Value;
                newSocio.edad = node.Attributes["edad"].Value;
                newSocio.telefono = node.Attributes["telefono"].Value;
                newSocio.correo = node.Attributes["correo"].Value;
                newSocio.cuenta = node.Attributes["cuenta"].Value;
                newSocio.ayuda = node.Attributes["ayuda"].Value;
                newSocio.pago =  node.Attributes["pago"].Value;
                newSocio.tipo = node.Attributes["tipo"].Value;
                newSocio.Imagen = new Uri(Environment.CurrentDirectory + node.Attributes["Imagen"].Value);
                //newSocio.Foto = new BitmapImage(newSocio.Imagen);

                listado.Add(newSocio);
            }
            return listado;
        }

        private void btnAniadir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a añadir un nuevo socio a la base de datos, ¿Desea continuar?", "Añadir socio", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha añadido correctamente un nuevo socio.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                var nuevoSocio = new Socio("...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", new Uri("Images/user.png", UriKind.Relative));
                // Añadimos una nueva película a la lista de películas (listadoPeliculas)
                listadoSocios.Add(nuevoSocio);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaSocios.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción","Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a eliminar un socio de la base de datos, ¿Desea continuar?", "Eliminar socio",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha eliminado correctamente el socio seleccionado.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                listadoSocios.RemoveAt(cbListaSocios.SelectedIndex);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaSocios.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a editar la información de socio de la base de datos, ¿Desea continuar?", "Editar socio",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha editado correctamente la información correspondiente al socio seleccionado.", "Resultado", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cbListaSocios.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

       /* private void txtEstado_TextChanged(object sender, TextChangedEventArgs e)
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
        } */

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
