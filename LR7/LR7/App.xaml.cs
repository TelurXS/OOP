using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace LR7;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	public App()
	{
		Services.AddSingleton(this);
		Services.AddTransient<MainWindow>();

		Provider = Services.BuildServiceProvider();
	}

	private ServiceCollection Services { get; } = new();
	private ServiceProvider Provider { get; }

	protected override void OnStartup(StartupEventArgs e)
	{
		var window = Provider.GetRequiredService<MainWindow>();
		window.Show();
	}

	public void Reload()
	{
		var window = Current.MainWindow;
		Current.MainWindow = Provider.GetRequiredService<MainWindow>();
		Current.MainWindow.Show();
		window.Close();
	}
}
