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

        private void OnTextInput(object sender, TextChangedEventArgs e) 
            => CalculateResult();

        private void CalculateResult()
        {
            try 
            {
                var a = double.Parse(TextBox_A.Text);
                var b = double.Parse(TextBox_B.Text);
                var c = double.Parse(TextBox_C.Text);
                var d = double.Parse(TextBox_D.Text);

                var result = ((a / b) * (b / d)) - ((a * b - c) / c * d);
                Label_Result.Content = result.ToString();
            } 
            catch (Exception ex) 
            {
                Label_Result.Content = ex.Message;
            }
        }
    }
}