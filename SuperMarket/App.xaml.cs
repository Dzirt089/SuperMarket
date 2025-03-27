using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SuperMarket.Services;
using SuperMarket.Services.Interfaces;
using SuperMarket.ViewModel;
using SuperMarket.Views;

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
		services.AddSingleton<ShopViewModel>();
		services.AddSingleton<CartViewModel>();
		services.AddSingleton<ProfileViewModel>();
		services.AddSingleton<MainViewModel>();
	}

	/// <summary>
	/// OnStartup
	/// </summary>
	/// <param name="e"></param>
	protected override void OnStartup(StartupEventArgs e)
	{
		try
		{
			var navigationService = Host.Services.GetRequiredService<INavigationService>();
			MainViewModel mainVM = Host.Services.GetRequiredService<MainViewModel>();
			new MainWindow { DataContext = mainVM }.Show();
			base.OnStartup(e);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}

