using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SuperMarket.Services;
using SuperMarket.Services.Interfaces;

using System.Configuration;
using System.Data;
using System.Windows;

namespace SuperMarket;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	public static IHost Host { get; private set; }
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
		services.AddScoped<IProductService, ProductService>();
	}
}

