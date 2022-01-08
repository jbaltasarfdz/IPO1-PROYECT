using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ResourceDictionary DefineIdioma(string idioma)
        {
            var resourceDictionary = new ResourceDictionary();
            switch (idioma)
            {
                case "en-UK": resourceDictionary.Source = new
                    Uri("/Recursos/StringRecursos.en-UK.xaml", UriKind.Relative);
                        break;
                case "es-ES": resourceDictionary.Source = new
                    Uri("/Recursos/StringRecursos.es-ES.xaml", UriKind.Relative);
                        break;
            }
            return resourceDictionary;
        }
    }
}
