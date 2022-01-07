﻿using System;
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
    public partial class avisoWindow : Window
    {
        private List<Aviso> listadoAvisos;

        public avisoWindow()
        {
            InitializeComponent();

            listadoAvisos = CargarListaAvisos();

            DataContext = listadoAvisos;


        }

        private List<Aviso> CargarListaAvisos()
        {
            List<Aviso> listado = new List<Aviso>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Xmls/xmlAvisos.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var newAviso = new Aviso("", "", "", "", "", "", "", "", "", null);
                newAviso.nombre = node.Attributes["nombre"].Value;
                newAviso.sexo = node.Attributes["sexo"].Value;
                newAviso.raza = node.Attributes["raza"].Value;
                newAviso.tamanio = node.Attributes["tamanio"].Value;
                newAviso.descripcion = node.Attributes["descripcion"].Value;
                newAviso.fechaPerdida = node.Attributes["fechaPerdida"].Value;
                newAviso.zonaPerdida = node.Attributes["zonaPerdida"].Value;
                newAviso.telefono = node.Attributes["telefono"].Value;
                newAviso.correo = node.Attributes["correo"].Value;
                newAviso.Imagen = new Uri(Environment.CurrentDirectory + node.Attributes["Imagen"].Value);
                //newAviso.Foto = new BitmapImage(newAviso.Imagen);

                listado.Add(newAviso);
            }
            return listado;
        }

        private void btnAniadir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a añadir un nuevo aviso a la base de datos, ¿Desea continuar?", "Añadir Aviso", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha añadido correctamente un nuevo aviso.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                var nuevoAviso = new Aviso("...", "...", "...", "...", "...", "...", "...", "...", "...", new Uri("Images/silueta.jpg", UriKind.Relative));
                // Añadimos una nueva película a la lista de películas (listadoPeliculas)
                listadoAvisos.Add(nuevoAviso);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaAvisos.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción","Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a eliminar un aviso de la base de datos, ¿Desea continuar?", "Eliminar Aviso",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha eliminado correctamente el aviso seleccionado.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                listadoAvisos.RemoveAt(cbListaAvisos.SelectedIndex);
                // Actualizaremos tanto el ListBox como el DataGrid para que las dos vistas
                // queden actualizadas
                cbListaAvisos.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Va a editar la información de aviso de la base de datos, ¿Desea continuar?", "Editar Aviso",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Se ha editado correctamente la información correspondiente al aviso seleccionado.", "Resultado", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                cbListaAvisos.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ventana para gestionar la información de los avisos de perros perdidos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
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
