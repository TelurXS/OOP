using System.Windows;
using System.Windows.Controls;

namespace LR6
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

		private void OnTextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				var a = double.Parse(TextBox_A.Text);
				var b = double.Parse(TextBox_B.Text);

				if (a == 0)
					throw new ArgumentException("a cannot be zero");

				var result = -b / a;

				Label_Result.Content = result.ToString();
			}
			catch (Exception ex) 
			{
				Label_Result.Content = ex.Message;
			}
        }
    }
}