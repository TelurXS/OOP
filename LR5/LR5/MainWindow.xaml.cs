using System.Windows;
using System.Windows.Controls;

namespace LR5
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

		private void OnTextChanged(object sender,TextChangedEventArgs e)
		{
			try
			{
				char c0 = char.Parse(TextBox_C0.Text);
				char c1 = char.Parse(TextBox_C1.Text);
				char c2 = char.Parse(TextBox_C2.Text);

				int value = int.Parse($"{c0}{c1}{c2}");

				Label_Result.Content = value.ToString();
			}
			catch (Exception ex)
			{
				Label_Result.Content = ex.Message;
			}
		}
	}
}