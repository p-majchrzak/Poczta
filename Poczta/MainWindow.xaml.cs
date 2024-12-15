
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Poczta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SprawdzCene_Click(object sender, RoutedEventArgs e)
        {
            if(Pocztowka.IsChecked == true)
            {
                Cena.Content = "Cena: 1 zł";
                Zdjecie.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.RelativeOrAbsolute));
            }
            if (List.IsChecked == true)
            {
                Cena.Content = "Cena: 1.5 zł";
                Zdjecie.Source = new BitmapImage(new Uri("list.png", UriKind.RelativeOrAbsolute));
            }
            if (Paczka.IsChecked == true)
            {
                Cena.Content = "Cena: 10 zł";
                Zdjecie.Source = new BitmapImage(new Uri("paczka.png", UriKind.RelativeOrAbsolute));
            }
        }
        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            Regex kodZabezpieczenieIlosc = new Regex("^.{5}$");
            if(kodZabezpieczenieIlosc.IsMatch(KodPocztowy.Text))
            {
                Regex kodZabezpieczenieIloscZnaki = new Regex("^[0-9]+$");
                if(kodZabezpieczenieIloscZnaki.IsMatch(KodPocztowy.Text))
                {
                    MessageBox.Show("Dane przesyłki zostały wprowadzone");
                }
                else
                {
                    MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
        }
    }
}