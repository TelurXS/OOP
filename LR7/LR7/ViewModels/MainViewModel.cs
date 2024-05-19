using LR7.Commands;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

namespace LR7.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
	private readonly Uri DARK_THEME_URI = new Uri("/Resources/Themes/Dark.xaml", UriKind.Relative);
	private readonly Uri LIGHT_THEME_URI = new Uri("/Resources/Themes/Light.xaml", UriKind.Relative);

	public ICommand ChangeThemeToDarkCommand { get; }
	public ICommand ChangeThemeToLightCommand { get; }

	public MainViewModel()
	{
		ChangeThemeToDarkCommand = new RelayCommand<object>(ChangeThemeToDark);
		ChangeThemeToLightCommand = new RelayCommand<object>(ChangeThemeToLight);
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	protected void OnPropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	private void ChangeTheme(Uri uri)
	{
		ResourceDictionary theme = new ResourceDictionary();
		theme.Source = uri;

		Application.Current.Resources.MergedDictionaries.Clear();
		Application.Current.Resources.MergedDictionaries.Add(theme);
		Application.Current.MainWindow.InvalidateVisual();
	}

	public void ChangeThemeToDark(object parameter)
	{
		ChangeTheme(DARK_THEME_URI);
	}

	public void ChangeThemeToLight(object parameter)
	{
		ChangeTheme(LIGHT_THEME_URI);
	}
}
