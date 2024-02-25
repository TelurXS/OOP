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

namespace Task6
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

        private void OnTextInput(object sender, TextChangedEventArgs e)
            => CalculateResult();

        private void CalculateResult()
        {
            try
            {
                var a = TextBox_A.Text.Split(",").Select(x => x.Trim());
                var b = TextBox_B.Text.Split(",").Select(x => x.Trim());

                if (a.Count() <= b.Count())
                    throw new ArgumentException($"Count of B must be less than count of A");

                var result = b.All(x => a.Contains(x));
                Label_Result.Content = result.ToString();
            }
            catch (Exception ex)
            {
                Label_Result.Content = ex.Message;
            }
        }
    }
}