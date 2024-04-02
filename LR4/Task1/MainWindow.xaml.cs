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

namespace Task1
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

        private void TextBox_Values_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var values = TextBox_Values.Text.Split().Select(x => int.Parse(x)).ToArray();

                Label_Product.Content = values.Where(x => x > 0).Aggregate((prev, next) => prev * next).ToString();

                var min = values.Min();

                Label_Sum.Content = values.TakeWhile(x => x > min).Sum();

                Label_Evens.Content = string.Join(", ", values.Where((value, index) => index % 2 == 0).Order());
                Label_Odds.Content = string.Join(", ", values.Where((value, index) => index % 2 == 1).Order());
            }
            catch (Exception ex) 
            {
                Label_Product.Content = ex.Message;
            }
        }
    }
}