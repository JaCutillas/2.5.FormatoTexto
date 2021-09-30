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

        private void NegritaCheckBoxCliked(object sender, RoutedEventArgs e)
        {
            if (NegritaCheckBox.IsChecked == true)
            {
                SalidaTextBlock.FontWeight = FontWeights.Bold;
            }
            else
            {
                SalidaTextBlock.FontWeight = FontWeights.Normal;
            }
        }
        private void CursivaCheckBoxCliked(object sender, RoutedEventArgs e)
        {  
            if (CursivaCheckBox.IsChecked == true)
            {
                SalidaTextBlock.FontStyle = FontStyles.Italic;
            }
            else
            {
                SalidaTextBlock.FontStyle = FontStyles.Normal;
            }
        }
        private void CoolCheckBoxCliked(object sender, RoutedEventArgs e)
        {
            if (CoolCheckBox.IsChecked == true)
            {
                SalidaTextBlock.FontFamily = new FontFamily("Comic Sans MS");
            }
            else
            {
                SalidaTextBlock.FontFamily = new FontFamily("Segoe UI");
            }
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
