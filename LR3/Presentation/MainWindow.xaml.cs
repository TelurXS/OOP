using LR3.Numbers;
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

namespace Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string INTEGER = nameof(Integer);
        private const string REAL = nameof(Real);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_NumberLeftType_SelectionChanged(object sender, SelectionChangedEventArgs e)
            => OnValuesChanged();

        private void ComboBox_NumberRightType_SelectionChanged(object sender, SelectionChangedEventArgs e)
            => OnValuesChanged();

        private void TextBox_NumberLeft_TextChanged(object sender, TextChangedEventArgs e)
            => OnValuesChanged();

        private void TextBox_NumberRight_TextChanged(object sender, TextChangedEventArgs e)
            => OnValuesChanged();

        private void OnValuesChanged()
        {
            try
            {
                var leftValue = double.Parse(TextBox_NumberLeft.Text);
                var rightValue = double.Parse(TextBox_NumberRight.Text);

                var leftType = (ComboBox_NumberLeftType.SelectedItem as ComboBoxItem)?.Content.ToString();
                var rightType = (ComboBox_NumberRightType.SelectedItem as ComboBoxItem)?.Content.ToString();

                Number left = leftType switch
                {
                    INTEGER => new Integer(leftValue),
                    REAL => new Real(leftValue),
                    _ => throw new ArgumentException("Wrong type format")
                };

                Number right = rightType switch
                {
                    INTEGER => new Integer(rightValue),
                    REAL => new Real(rightValue),
                    _ => throw new ArgumentException("Wrong type format")
                };

                Label_Result.Content = (left + right).Value.ToString();
            }
            catch (Exception ex) 
            {
                Label_Result.Content = ex.Message;
            }
        }
    }
}