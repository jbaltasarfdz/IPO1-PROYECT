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
    /// Lógica de interacción para perrosPerdidosWindow.xaml
    /// </summary>
    public partial class avisoWindow : Window
    {
        private List<Aviso> listadoPerrosPerdidos;

        public avisoWindow()
        {
            InitializeComponent();

            listadoPerrosPerdidos = CargarListaAvisos();

            DataContext = listadoPerrosPerdidos;


        }

        private List<Aviso> CargarListaAvisos()
        {
            List<Aviso> listado = new List<Aviso>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Xmls/xmlAvisos.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var newAviso = new Aviso("", "", "", "", "", null);
                newAviso.NombrePerro = node.Attributes["NombrePerro"].Value;
                newAviso.Descripcion = node.Attributes["Descripcion"].Value;
                newAviso.NombreDueño = node.Attributes["NombreDueño"].Value;
                newAviso.Telefono = node.Attributes["Telefono"].Value;
                newAviso.Correo = node.Attributes["Correo"].Value;
                newAviso.Imagen = new Uri(Environment.CurrentDirectory + node.Attributes["Imagen"].Value);
                //newPerro.Foto = new BitmapImage(newPerro.Imagen);

                listado.Add(newAviso);
            }
            return listado;
        }



        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ventana para gestionar los avisos de los animales perdidos de la protectora", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
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
