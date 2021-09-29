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

namespace FormatoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AzulRadioButton.IsChecked = true;
        }

        private void EntradaTextBlockChanged(object sender, TextChangedEventArgs e) 
        {
            SalidaTextBlock.Text = EntradaTextBox.Text;
        }

        private void NegritaCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            SalidaTextBlock.FontWeight = FontWeights.Bold;
        }
        private void CursivaCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            SalidaTextBlock.FontStyle = FontStyles.Italic;
        }
        private void CoolCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            SalidaTextBlock.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void AzulRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            SalidaTextBlock.Foreground = Brushes.DeepSkyBlue;
        }

        private void RojoRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            SalidaTextBlock.Foreground = Brushes.Tomato;
        }

        private void VerdeRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            SalidaTextBlock.Foreground = Brushes.LimeGreen;
        }
    }
}
