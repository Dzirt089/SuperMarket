using Microsoft.Extensions.DependencyInjection;

using SuperMarket.Services.Interfaces;
using SuperMarket.ViewModel;

namespace SuperMarket.Services
{
	public class NavigationService : INavigationService
	{
		private readonly IServiceProvider _serviceProvider;

		public NavigationService(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public ViewModelBase CurrentViewModel { get; private set; }
		public event Action? CurrentViewModelChanged;

		public void NavigateTo<T>() where T : ViewModelBase
		{
			CurrentViewModel = _serviceProvider.GetRequiredService<T>();
			CurrentViewModelChanged?.Invoke();
		}
	}

}
