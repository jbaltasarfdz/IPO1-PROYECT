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

        }


        /// Mover foco al pulsar enter
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                //lblEstado.Content = "Se pulsó el enter ";
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
            settingsWindow settingswindow = new settingsWindow();
            settingswindow.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            userWindow userwindow = new userWindow();
            
            if (txtUsuario.Text == usuario && txtContrasena.Password == password)
            {
                userwindow.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error en el login", MessageBoxButton.OK, MessageBoxImage.Error);
                txtUsuario.Clear();
                txtContrasena.Clear();
                
            }
            
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
