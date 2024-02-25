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

namespace Task4
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
                var x1 = double.Parse(TextBox_X1.Text);
                var y1 = double.Parse(TextBox_Y1.Text);
                var x2 = double.Parse(TextBox_X2.Text);
                var y2 = double.Parse(TextBox_Y2.Text);
                var x3 = double.Parse(TextBox_X3.Text);
                var y3 = double.Parse(TextBox_Y3.Text);
                var x4 = double.Parse(TextBox_X4.Text);
                var y4 = double.Parse(TextBox_Y4.Text);

                var result = IsConvex(x1, y1, x2, y2, x3, y3, x4, y4);
                Label_Result.Content = result.ToString();
            }
            catch (Exception ex)
            {
                Label_Result.Content = ex.Message;
            }
        }

        private bool IsConvex(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            List<double> orientations = 
            [
                (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1),
                (x3 - x2) * (y4 - y2) - (y3 - y2) * (x4 - x2),
                (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3),
            ];

            return orientations.All(x => x > 0) || orientations.All(x => x < 0);
        }
    }
}