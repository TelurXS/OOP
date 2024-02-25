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

namespace Task5
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
                var a = int.Parse(TextBox_A.Text);
                var b = int.Parse(TextBox_B.Text);
                var c = int.Parse(TextBox_C.Text);
                var d = int.Parse(TextBox_D.Text);

                if (a == 0)
                    throw new ArgumentException("A cannot equals zero");

                if (d == 0)
                    throw new ArgumentException("D cannot equals zero");

                var builder = new StringBuilder();

                for (int x = -Math.Abs(d); x <= Math.Abs(d); x++)
                {
                    if (x == 0)
                        continue;

                    if (d % x != 0)
                        continue;

                    double y = (a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d);

                    if (y != 0)
                        continue;

                    builder.AppendLine($"x = {x}, y = {y}");
                }

                if (builder.Length == 0)
                    builder.AppendLine("There are no solutions");

                Label_Result.Content = builder.ToString();
            }
            catch (Exception ex)
            {
                Label_Result.Content = ex.Message;
            }
        }
    }
}