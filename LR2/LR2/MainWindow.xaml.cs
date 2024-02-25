using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LR2
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

        private Address Address { get; } = new();

        private void OnCountryInput(object sender, TextChangedEventArgs e)
            => Address.Country = TextBox_Country.Text;

        private void OnStreetInput(object sender, TextChangedEventArgs e)
            => Address.Street = TextBox_Street.Text;

        private void OnCodeInput(object sender, TextChangedEventArgs e)
            => Address.PostalCode = TextBox_Code.Text;

        private void OnCityInput(object sender, TextChangedEventArgs e)
            => Address.City = TextBox_City.Text;

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Address.ToString());
        }
    }
}