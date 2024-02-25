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

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int REQUIRED_LENGTH = 3;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTextInput(object sender, TextChangedEventArgs e)
            => CalculateResult();

        private void CalculateResult()
        {
            try
            {
                var number = TextBox_Number.Text;

                if (number.ToString().Length != REQUIRED_LENGTH)
                {
                    Label_Result.Content = "Provided number is not in valid format";
                    return;
                }

                var result = number
                    .Sum(x => char.IsNumber(x) 
                        ? int.Parse(x.ToString()) 
                        : throw new ArgumentException($"Number cannot contain symbol '{x}'"));

                Label_Result.Content = (result % 2 == 0).ToString();
            }
            catch (Exception ex)
            {
                Label_Result.Content = ex.Message;
            }
        }
    }
}