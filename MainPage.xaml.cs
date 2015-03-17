using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ColorApp.Resources;
using System.Windows.Media;

namespace ColorApp
{
    public partial class MainPage : PhoneApplicationPage
    {   
        private bool amarillo;
        private bool azul;
        private bool rojo;
        private bool? verdadero;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rectFijo.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            rectFijo.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            rectFijo.Fill = new SolidColorBrush(Colors.Red);
        }
        
        private void actualizarMezclaColores()
        {
            if (amarillo & !azul & !rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Yellow);
                return;
            }
            if (!amarillo & azul & !rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Blue);
                return;
            }
            if (!amarillo & !azul & rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Red);
                return;
            }
            if (amarillo & azul & !rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Green);
                return;
            }
            if (amarillo & !azul & rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Orange);
                return;
            }
            if (amarillo & azul & rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Brown);
                return;
            }

            if (!amarillo & !azul & !rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Black);
                return;
            }
            if (!amarillo & azul & rojo)
            {
                rectMezcla.Fill = new SolidColorBrush(Colors.Purple);
                return;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            amarillo = (bool) chkAmarillo.IsChecked;
            actualizarMezclaColores();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            azul = (bool) chkAzul.IsChecked;
            actualizarMezclaColores();
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            rojo = (bool) chkRojo.IsChecked;
            actualizarMezclaColores();
        }
        
        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}