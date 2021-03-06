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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string usuario = "admin";
        private string password = "ipo1";

        public MainWindow()
        {
            InitializeComponent();
            App.DefineIdioma("es-ES");
        }


        /// Mover foco al pulsar enter
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                
                if (!String.IsNullOrEmpty(txtUsuario.Text)
                && ComprobarEntrada(txtUsuario.Text, usuario,
                txtUsuario))
                {
                    // habilitar entrada de contraseña y pasarle el foco
                    txtContrasena.IsEnabled = true;
                    txtContrasena.Focus();
                    // deshabilitar entrada de login
                    txtUsuario.IsEnabled = false;
                }
            }
        }

        /// Mejora en la usabilidad del login
        private Boolean ComprobarEntrada(string valorIntroducido, string valorValido, Control componenteEntrada)
        {
            Boolean valido = false;
            componenteEntrada.BorderThickness = new Thickness(2);
            if (valorIntroducido.Equals(valorValido))
            {
                // borde y background en verde
                componenteEntrada.BorderBrush = Brushes.Green;
                componenteEntrada.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de usuario --> check
                //imagenFeedBack.Source = imagCheck;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                componenteEntrada.BorderBrush = Brushes.Red;
                // imagen al lado de la entrada de usuario --> cross
                //imagenFeedBack.Source = imagCross;
                valido = false;
            }
            return valido;
        }


        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show((string)Resources["Ajustes"], (string)Resources["Enunciado"],
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                settingsWindow settingswindow = new settingsWindow();
                settingswindow.Show();
            }
            else
            {
                MessageBox.Show((string)Resources["Cancelado"], (string)Resources["Resultado"], MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            userWindow userwindow = new userWindow();
            
            if (txtUsuario.Text == usuario && txtContrasena.Password == password)
            {
                MessageBox.Show((string)Resources["Gracias"]);
                userwindow.Show();
            }
            else
            {
                MessageBox.Show((string)Resources["UsuarioError"], (string)Resources["ErrorU"], MessageBoxButton.OK, MessageBoxImage.Error);
                txtUsuario.Clear();
                txtContrasena.Clear();
                
            }
            
        }

        private void cbIdioma_CambioSeleccion(object sender, SelectionChangedEventArgs e)
        {
            string idioma = "";
            string dic = "";
            int cbi = cbIdiomas.SelectedIndex;
            switch (cbi)
            {
                case 0:
                    dic = "Español";
                    idioma = "es-ES";
                    break;
                case 1:
                    dic = "Inglés";
                    idioma = "en-UK";
                    break;
            }
            Resources.MergedDictionaries.Add(App.DefineIdioma(idioma));
            lblEstado.Content = Resources["Idioma" + dic];
        }

    }

    class ReglaRangoLongitudCaracteres : ValidationRule
    {
        public int MinimoCaracteres { set; get; }
        public int MaximoCaracteres { set; get; }
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int longitud = ((string)value).Length;
            if ((longitud < MinimoCaracteres) || (longitud > MaximoCaracteres))
                return new ValidationResult(false, "Longitud: " +
                MinimoCaracteres.ToString() + "-" + MaximoCaracteres.ToString() + " dígitos");
            return new ValidationResult(true, null);
        }
    }
}
