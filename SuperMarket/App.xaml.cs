using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SuperMarket.Services;
using SuperMarket.Services.Interfaces;
using SuperMarket.ViewModel;

using System.Windows;

namespace SuperMarket;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	public static IHost Host { get; private set; }

	/// <summary>
	/// App
	/// </summary>
	public App()
	{
		Host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
			.ConfigureServices((context, services) =>
			{
				ConfigureServices(services);
			}).Build();
	}

	//Add Services in DI
	private static void ConfigureServices(IServiceCollection services)
	{
		services.AddSingleton<IProductService, ProductService>();
		services.AddSingleton<INavigationService, NavigationService>();
	}

	/// <summary>
	/// OnStartup
	/// </summary>
	/// <param name="e"></param>
	protected override void OnStartup(StartupEventArgs e)
	{
		try
		{
			var navigationService = new NavigationService();
			var mainVM = new MainViewModel(navigationService);

			new MainWindow { DataContext = mainVM }.Show();

			base.OnStartup(e);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}

