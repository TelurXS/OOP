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

namespace Task7
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
                var text = TextBox_Text.Text;

                var result = text
                    .Split()
                    .Select(x => x.Trim())
                    .Where(x => x.ToLower().StartsWith("b"))
                    .Count();

                Label_Result.Content = result.ToString();
            }
            catch (Exception ex)
            {
                Label_Result.Content = ex.Message;
            }
        }
    }
}