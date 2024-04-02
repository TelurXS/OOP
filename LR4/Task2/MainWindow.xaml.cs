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

namespace Task2;

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
            var lines = TextBox_Values.Text.Split("\n");
            var values = lines.Select(x => x.Split(" ").Select(y => int.Parse(y)));

            (int height, int width) = GetMatrixSize(values);
            var matrix = ToMatrix(values, height, width);

            Label_BottomRight.Content = matrix[height - 1, width - 1];
            Label_UpperLeft.Content = matrix[0, 0];
            Label_Matrix.Content = ToString(matrix);
        }   
        catch (Exception ex)
        {
            Label_Matrix.Content = ex.Message;
        }
    }

    private int[,] ToMatrix(IEnumerable<IEnumerable<int>> values, int height, int width)
    {
        int[,] matrix = new int[height, width];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                try
                {
                    var value = values.ElementAt(y).ElementAt(x);
                    matrix[y, x] = value;
                }
                catch
                {
                    matrix[y, x] = 0;
                }
            }
        }

        return matrix;
    }

    private (int, int) GetMatrixSize(IEnumerable<IEnumerable<int>> values)
    {
        var height = values.Count();
        var width = values.MaxBy(x => x.Count())?.Count() ?? 0;
        return (height, width);
    }

    private string ToString(int[,] matrix)
    {
        StringBuilder builder = new StringBuilder();

        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                builder.Append(matrix[y, x]);
                builder.Append(' ');
            }

            builder.AppendLine();
        }

        return builder.ToString();
    }
}

