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

namespace Reproductor__Star_Wars_IX_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pantalla.LoadedBehavior = MediaState.Manual;
        }

        private void BotonPlay_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Play();
        }

        private void BotonPause_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Pause();
        }

        private void RadioTrailer2_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioTrailer1.IsChecked == true)
            {
                Pantalla.Source = new Uri(@"C:\Users\alumno\trailer1.mp4");
            }
            else if (RadioTrailer2.IsChecked == true)
            {
                Pantalla.Source = new Uri(@"C:\Users\alumno\trailer2.mp4");
            }
        }

        private void BotonStop_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Stop();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if(CheckSilence.IsChecked == true)
            {
                Pantalla.Volume = 0;
            }
            else
            {
                Pantalla.Volume = 50;
            }
        }
    }
}
