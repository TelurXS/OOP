using LR7.Commands;
using LR7.ViewModels;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace LR7;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow(App app)
	{
		InitializeComponent();
		ChangeThemeCommand = new RelayCommand<string>(ChangeTheme);
		ChangeLanguageCommand = new RelayCommand<string>(ChangeLanguage);

		DataContext = this;
		App = app;
	}

	public ICommand ChangeThemeCommand { get; init; }
	public ICommand ChangeLanguageCommand { get; init; }

	public App App { get; }

	private void ChangeTheme(string value)
	{
		ResourceDictionary theme = new ResourceDictionary();
		theme.Source = new Uri(value, UriKind.Relative);

		Application.Current.Resources.MergedDictionaries.Clear();
		Application.Current.Resources.MergedDictionaries.Add(theme);
		InvalidateVisual();
	}

	private void ChangeLanguage(string value)
	{
		Thread.CurrentThread.CurrentCulture = new CultureInfo(value);
		Thread.CurrentThread.CurrentUICulture = new CultureInfo(value);
		InvalidateVisual();
		App.Reload();
	}
}