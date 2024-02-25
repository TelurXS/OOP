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

namespace Task2
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
                var v = double.Parse(TextBox_V.Text);
                var v1 = double.Parse(TextBox_V1.Text);
                var t1 = double.Parse(TextBox_T1.Text);
                var t2 = double.Parse(TextBox_T2.Text);

                var result = (v + v1) * t1 + (v - v1) * t2;
                Label_Result.Content = result.ToString();
            }
            catch (Exception ex)
            {
                Label_Result.Content = ex.Message;
            }
        }
    }
}